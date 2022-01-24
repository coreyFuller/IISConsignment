using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSellerSaleItemsSold
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
        public decimal? SalesTaxPercent { get; set; }
        public long InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public long InvoiceDetailId { get; set; }
        public long? SaleItemId { get; set; }
        public long SellerId { get; set; }
        public string? SellerNumber { get; set; }
        public bool? NoDiscount { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? ProcessFee { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? Phone { get; set; }
        public string? PhoneAlt { get; set; }
        public string? Email { get; set; }
        public string? EmailAlt { get; set; }
        public string? MailAddr1 { get; set; }
        public string? MailAddr2 { get; set; }
        public string? MailCity { get; set; }
        public string? MailState { get; set; }
        public string? MailZip { get; set; }
        public bool? PricedBySeller { get; set; }
        public bool? DonateLeftOver { get; set; }
        public bool? NoCount { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
    }
}
