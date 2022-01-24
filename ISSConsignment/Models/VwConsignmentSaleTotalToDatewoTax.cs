using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwConsignmentSaleTotalToDatewoTax
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public decimal? ConsignmentSaleSaleTotalToDatewoTax { get; set; }
    }
}
