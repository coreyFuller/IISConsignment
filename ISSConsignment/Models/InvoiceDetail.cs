using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class InvoiceDetail
    {
        public long InvoiceDetailId { get; set; }
        public long InvoiceId { get; set; }
        public long? SaleItemId { get; set; }
        public long SellerId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public string? InvoiceDetailNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual SaleItem? SaleItem { get; set; }
        public virtual SaleItemType SaleItemType { get; set; } = null!;
        public virtual Seller Seller { get; set; } = null!;
    }
}
