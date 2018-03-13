package com.sphereon.sdk.crypto.keys.api;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.sphereon.sdk.crypto.keys.handler.ApiException;
import com.sphereon.sdk.crypto.keys.model.CertificateBundleResponse;
import com.sphereon.sdk.crypto.keys.model.CertificateMetadataListResponse;
import com.sphereon.sdk.crypto.keys.model.KeyDecryptRequest;
import com.sphereon.sdk.crypto.keys.model.KeyDecryptResponse;
import com.sphereon.sdk.crypto.keys.model.KeyEncryptRequest;
import com.sphereon.sdk.crypto.keys.model.KeyEncryptResponse;
import com.sphereon.sdk.crypto.keys.model.KeySignRequest;
import com.sphereon.sdk.crypto.keys.model.KeySignResponse;
import com.sphereon.sdk.crypto.keys.model.KeyVerifyRequest;
import com.sphereon.sdk.crypto.keys.model.KeyVerifyResponse;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.bouncycastle.util.encoders.Hex;
import org.junit.Assert;
import org.junit.Test;

import javax.security.cert.CertificateException;
import java.io.ByteArrayInputStream;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.security.cert.Certificate;
import java.security.cert.CertificateFactory;
import java.security.spec.InvalidKeySpecException;
import java.text.ParseException;
import java.util.Base64;

import static com.sphereon.sdk.crypto.keys.model.KeySignRequest.AlgEnum.RS256;

public class CryptoKeysDemoTest extends AbstractApiTest {
    private static final Gson GSON = new GsonBuilder().setPrettyPrinting().create();
    private static Log log = LogFactory.getLog(CryptoKeysDemoTest.class);

    /**
     * This test relies on a config called 'demo' which should
     * be provisioned and connected to the sphereondemo keyvault and the client_id and client_secret provided in lastpass
     * See kb for details
     */
    public static final String CONFIG_NAME = "demo";
    public static final String DEMO_CERT_ALL_ID = "demo/certs/demoallcert/latest";
    public static final String X509_THUMBPRINT = "9380cffd786bcf4be297cd25529f45960dbce2b0";
    public static final String SHA_256 = "SHA-256";
    public static final String LATEST_VERSION = "latest";
    public static final String CERT_NAME = "demoallcert";
    public static final String SYM_KEY_NAME = "demokey";




    @Test
    public void certificateSigning() throws ApiException, ParseException, CertificateException, NoSuchAlgorithmException, InvalidKeySpecException, java.security.cert.CertificateException {


        /**
         * Retrieve certificate metadata list and print certificate
         *
         * This is the minimal info needed about certificates like the x509 thumbprint and our key id
         */
        CertificateMetadataListResponse certsMeta = certApi.listCerts(CONFIG_NAME);
        Assert.assertNotNull(certsMeta);
        log.info(GSON.toJson(certsMeta.getCertificateMetadata().get(DEMO_CERT_ALL_ID)));


        /**
         * Retrieve the full (public) certificate response.
         *
         * Check the certificate thumbprint. Get the certificate bytes and convert them to a Java certificate that gets logged in human readable form
         */
        CertificateBundleResponse certResponse = certApi.getCert(CONFIG_NAME, CERT_NAME, LATEST_VERSION);
        log.info(GSON.toJson(certResponse.getCertificateBundle()));

        Assert.assertEquals(X509_THUMBPRINT, Hex.toHexString(certResponse.getCertificateBundle().getX509Thumbprint()));
        Certificate x509PublicCert = CertificateFactory
                .getInstance("X509")
                .generateCertificate(new ByteArrayInputStream(
                        certResponse.getCertificateBundle().getCer()
                ));

        log.error(x509PublicCert.toString());



        /**
         * Sign SHA-256 hash/digest using private key in Azure keyvault using RS256.
         */
        String input = "This is a demo text to show both sign/verify as encrypt/decrypt using asymmetric and symmetric keys";
        byte[] sha256Hash = MessageDigest.getInstance(SHA_256).digest(input.getBytes());

        KeySignRequest keySignRequest = new KeySignRequest().alg(RS256).digest(sha256Hash);
        KeySignResponse keySignResponse = contentApi.signUsingKey(CONFIG_NAME, CERT_NAME, LATEST_VERSION, keySignRequest);

        log.info(String.format("Signature for '%s' (%s) in hex: %s", keySignResponse.getKid(), RS256, keySignResponse.getHexSignature()));
        log.info(String.format("Signature for '%s' (%s) in base64: %s", keySignResponse.getKid(), RS256, Base64.getEncoder().encodeToString(keySignResponse.getBase64Signature())));



        /**
         * Verify signature with the hash
         */
        KeyVerifyRequest keyVerifyRequest = new KeyVerifyRequest()
                .alg(KeyVerifyRequest.AlgEnum.RS256)
                .base64Signature(keySignResponse.getBase64Signature())
                .digest(sha256Hash);
        KeyVerifyResponse keyVerifyResponse = contentApi.verifyUsingKey(CONFIG_NAME, CERT_NAME, LATEST_VERSION, keyVerifyRequest);

        log.info(String.format("Signature for '%s' (%s) verified %s in hex: %s", keyVerifyResponse.getKid(), RS256, keyVerifyResponse.getVerified() ? "successfully" : "NOT", keyVerifyResponse.getHexSignature()));
        log.info(String.format("Signature for '%s' (%s) verified %s in base64: %s", keyVerifyResponse.getKid(), RS256, keyVerifyResponse.getVerified() ? "successfully" : "NOT", Base64.getEncoder().encodeToString(keyVerifyResponse.getBase64Signature())));




        /**
         * Show that we can also sign/verify using a symmetric key and that the resulting signature differs for the same hash
         */
        KeySignResponse symKeySignResponse = contentApi.signUsingKey(CONFIG_NAME, SYM_KEY_NAME, LATEST_VERSION, keySignRequest);

        Assert.assertNotEquals(keySignResponse.getBase64Signature(), symKeySignResponse.getBase64Signature());
        log.info(String.format("Signature for '%s' (%s) in hex: %s", symKeySignResponse.getKid(), RS256, symKeySignResponse.getHexSignature()));
        log.info(String.format("Signature for '%s' (%s) in base64: %s", symKeySignResponse.getKid(), RS256, Base64.getEncoder().encodeToString(symKeySignResponse.getBase64Signature())));

        // Update signature in request to symmetric version just retrieved from response
        keyVerifyRequest.base64Signature(symKeySignResponse.getBase64Signature());
        KeyVerifyResponse symKeyVerifyResponse = contentApi.verifyUsingKey(CONFIG_NAME, SYM_KEY_NAME, LATEST_VERSION, keyVerifyRequest);
        log.info(String.format("Signature for '%s' (%s) verified %s in hex: %s", symKeyVerifyResponse.getKid(), RS256, symKeyVerifyResponse.getVerified() ? "successfully" : "NOT", symKeyVerifyResponse.getHexSignature()));
        log.info(String.format("Signature for '%s' (%s) verified %s in base64: %s", symKeyVerifyResponse.getKid(), RS256, symKeyVerifyResponse.getVerified() ? "successfully" : "NOT", Base64.getEncoder().encodeToString(symKeyVerifyResponse.getBase64Signature())));



        /**
         * Quick encrypt and decrypt of input using RSA with SHA-256 padding and mask function
         */
        KeyEncryptRequest keyEncryptRequest = new KeyEncryptRequest()
                .alg(KeyEncryptRequest.AlgEnum.RSA_OAEP_256)
                .input(input.getBytes());
        KeyEncryptResponse keyEncryptResponse = contentApi.encryptUsingKey(CONFIG_NAME, CERT_NAME, LATEST_VERSION, keyEncryptRequest);

        KeyDecryptRequest keyDecryptRequest = new KeyDecryptRequest()
                .alg(KeyDecryptRequest.AlgEnum.RSA_OAEP_256)
                .encrypted(keyEncryptResponse.getEncrypted());
        KeyDecryptResponse keyDecryptResponse = contentApi.decryptUsingKey(CONFIG_NAME, CERT_NAME, LATEST_VERSION, keyDecryptRequest);
        Assert.assertEquals(input, new String(keyDecryptResponse.getDecrypted()));

    }
}