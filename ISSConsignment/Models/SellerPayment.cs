using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class SellerPayment
    {
        public long SellerPaymentId { get; set; }
        public long ConsignmentSaleId { get; set; }
        public long SellerId { get; set; }
        public long EmployeeId { get; set; }
        public string PaymentType { get; set; } = null!;
        public int CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? CheckMemo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? SellerPaymentNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ConsignmentSale ConsignmentSale { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual Seller Seller { get; set; } = null!;
    }
}
