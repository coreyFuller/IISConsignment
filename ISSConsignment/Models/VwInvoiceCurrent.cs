using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwInvoiceCurrent
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyFacebook { get; set; }
        public string? CompanyTwitter { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? SaleWebsite { get; set; }
        public string? StorePhone { get; set; }
        public string? StoreAddr1 { get; set; }
        public string? StoreAddr2 { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public string? StoreZip { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public long CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? MailAddr1 { get; set; }
        public string? MailCity { get; set; }
        public string? MailState { get; set; }
        public string? MailZip { get; set; }
        public long InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public decimal? TotalInvoiceAmtWithTax { get; set; }
        public string? PromoCode { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public long InvoiceDetailId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public bool DefaultSale { get; set; }
    }
}
