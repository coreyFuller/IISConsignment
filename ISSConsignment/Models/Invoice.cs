using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public long InvoiceId { get; set; }
        public long ConsignmentSaleId { get; set; }
        public long CustomerId { get; set; }
        public long EmployeeId { get; set; }
        public string? Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public decimal? TotalInvoiceAmtWithTax { get; set; }
        public string? PromoCode { get; set; }
        public string? InvoiceNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public long? TmpConvertedId { get; set; }

        public virtual ConsignmentSale ConsignmentSale { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
