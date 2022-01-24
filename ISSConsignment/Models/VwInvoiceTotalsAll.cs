using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwInvoiceTotalsAll
    {
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public string? CompanyName { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public long InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public string? PromoCode { get; set; }
        public int? Quantity { get; set; }
        public decimal LineItemTotal { get; set; }
        public decimal? LineItemTotalwTax { get; set; }
        public string? ModifiedByDevice { get; set; }
    }
}
