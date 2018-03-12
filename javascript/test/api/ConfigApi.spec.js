/**
 * Crypto Keys
 * The Crypto Keys API allows you to import, create and work with symmetric and asymmetric keys and certificates to sign/verify digest values, encrypt/decrypt input, or hash and sign input values. The benefit is that you don't have to store secret keys in your application.  The API has an integration with Azure KeyVault, allowing you to store keys, secrets and certificates in FIPS 140-2 Level 2 validated Hardware Security Modules (HSM). The key will never leave the HSM, making it really secure, especially if you combine it with IP whitelisting      Interactive testing: A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.CryptoKeys);
  }
}(this, function(expect, CryptoKeys) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new CryptoKeys.ConfigApi();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('ConfigApi', function() {
    describe('createConfiguration', function() {
      it('should call createConfiguration successfully', function(done) {
        //uncomment below and update the code to test createConfiguration
        //instance.createConfiguration(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('deleteConfiguration', function() {
      it('should call deleteConfiguration successfully', function(done) {
        //uncomment below and update the code to test deleteConfiguration
        //instance.deleteConfiguration(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('getConfiguration', function() {
      it('should call getConfiguration successfully', function(done) {
        //uncomment below and update the code to test getConfiguration
        //instance.getConfiguration(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('updateConfiguration', function() {
      it('should call updateConfiguration successfully', function(done) {
        //uncomment below and update the code to test updateConfiguration
        //instance.updateConfiguration(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));
