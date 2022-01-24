using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSellerPayment
    {
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? StoreAddr1 { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public string? StoreZip { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? MailAddr1 { get; set; }
        public string? MailCity { get; set; }
        public string? MailState { get; set; }
        public string? MailZip { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeNumber { get; set; } = null!;
        public string ComputerId { get; set; } = null!;
        public string PaymentType { get; set; } = null!;
        public int CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? CheckMemo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? SellerPaymentNotes { get; set; }
        public long SellerPaymentId { get; set; }
    }
}
