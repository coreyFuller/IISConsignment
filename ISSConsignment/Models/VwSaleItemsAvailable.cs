using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSaleItemsAvailable
    {
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public bool DisplaySeller { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
        public long SaleItemId { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReservePrice { get; set; }
        public bool NoDiscount { get; set; }
        public string? SaleItemNotes { get; set; }
        public long? InvoiceDetailId { get; set; }
    }
}
