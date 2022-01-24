using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class View1
    {
        public string? SaleTitle { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public long InvoiceId { get; set; }
        public string? PaymentType { get; set; }
        public string CheckoutEmployee { get; set; } = null!;
        public decimal? SalesTaxPercent { get; set; }
        public decimal? InvoiceTotalNoTax { get; set; }
        public int? CountOfItemsSold { get; set; }
        public decimal? InvoiceTotalWtax { get; set; }
        public decimal? TotalItemTax { get; set; }
    }
}
