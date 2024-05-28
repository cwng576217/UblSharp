using System;
using System.Collections.Generic;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace UblSharp
{
    public partial class InvoiceType
    {
        public InvoiceType()
        {

        }

        public InvoiceType(string id, DateTime issueDateTime, CodeType invoiceTypeCode, string documentCurrencyCode, SupplierPartyType supplierParty, CustomerPartyType customerParty, List<TaxTotalType> taxTotal, MonetaryTotalType legalMonetaryTotal)
        {
            // UTC time
            DateTime utcTime = new DateTime(issueDateTime.Year, issueDateTime.Month, issueDateTime.Day, issueDateTime.Hour, issueDateTime.Minute, issueDateTime.Second, DateTimeKind.Utc);

            ID = id;
            IssueDate = utcTime.ToString("yyyy-MM-dd");
            IssueTime = utcTime.ToString("HH:mm:ss") + "Z";
            InvoiceTypeCode = invoiceTypeCode;
            DocumentCurrencyCode = documentCurrencyCode;
            AccountingSupplierParty = supplierParty;
            AccountingCustomerParty = customerParty;
            TaxTotal = taxTotal;
            LegalMonetaryTotal = legalMonetaryTotal;
        }
    }
}
