using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwConsignmentSaleTotalToDatewTax
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public decimal? ConsignmentSaleTotalToDate { get; set; }
        public int? SumOfSoldItems { get; set; }
    }
}
