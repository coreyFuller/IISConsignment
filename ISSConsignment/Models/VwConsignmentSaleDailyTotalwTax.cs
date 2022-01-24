using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwConsignmentSaleDailyTotalwTax
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? DailySalesTotal { get; set; }
        public int? CountofInvoices { get; set; }
    }
}
