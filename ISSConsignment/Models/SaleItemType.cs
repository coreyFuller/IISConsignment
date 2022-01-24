using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class SaleItemType
    {
        public SaleItemType()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            SaleItems = new HashSet<SaleItem>();
        }

        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
        public string? SaleItemTypeNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}
