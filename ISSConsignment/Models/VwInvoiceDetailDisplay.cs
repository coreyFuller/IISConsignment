using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwInvoiceDetailDisplay
    {
        public string SellerNumber { get; set; } = null!;
        public string? CodeName { get; set; }
        public string Description { get; set; } = null!;
        public int? Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public string? InvoiceDetailNotes { get; set; }
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public long InvoiceId { get; set; }
        public long InvoiceDetailId { get; set; }
        public long? SaleItemId { get; set; }
        public long SellerId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeDescription { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
    }
}
