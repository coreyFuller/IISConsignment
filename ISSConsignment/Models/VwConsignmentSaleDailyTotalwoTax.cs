using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwConsignmentSaleDailyTotalwoTax
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? ConsignmentSaleDailyTotalswoTax { get; set; }
    }
}
