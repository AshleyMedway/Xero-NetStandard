/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing TaxLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaxLineTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void AmountTest(string input)
        {
            JsonDoc.Assert<TaxLine, decimal?>(
                input: new JsonDoc.Number(nameof(TaxLine.Amount), input),
                toProperty: x => x.Amount,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'ManualTaxType'
        /// </summary>
        [Theory]
        [InlineData("ETPOMANUAL", ManualTaxType.ETPOMANUAL)]
        [InlineData("ETPRMANUAL", ManualTaxType.ETPRMANUAL)]
        [InlineData("PAYGMANUAL", ManualTaxType.PAYGMANUAL)]
        [InlineData("SCHEDULE5MANUAL", ManualTaxType.SCHEDULE5MANUAL)]
        [InlineData("SCHEDULE5STSLMANUAL", ManualTaxType.SCHEDULE5STSLMANUAL)]
        public void ManualTaxTypeTest(string input, ManualTaxType expected)
        {
            JsonDoc.Assert<TaxLine, ManualTaxType>(
                input: new JsonDoc.String(nameof(TaxLine.ManualTaxType), input),
                toProperty: x => x.ManualTaxType,
                shouldBe: expected
            );
        }
    }
}