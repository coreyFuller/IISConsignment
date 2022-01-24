using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class SaleItem
    {
        public SaleItem()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public long SaleItemId { get; set; }
        public long ConsignmentSaleId { get; set; }
        public long SellerId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReservePrice { get; set; }
        /// <summary>
        /// Does Seller want NO DISCOUNT on this item?
        /// </summary>
        public bool NoDiscount { get; set; }
        public string? SaleItemNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ConsignmentSale ConsignmentSale { get; set; } = null!;
        public virtual SaleItemType SaleItemType { get; set; } = null!;
        public virtual Seller Seller { get; set; } = null!;
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
