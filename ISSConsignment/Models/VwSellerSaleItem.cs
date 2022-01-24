using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSellerSaleItem
    {
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public string? CompanyName { get; set; }
        public long SaleItemId { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public bool NoDiscount { get; set; }
        public decimal ProfitPercent { get; set; }
        public decimal ProcessFee { get; set; }
        public bool PricedBySeller { get; set; }
        public bool DonateLeftOver { get; set; }
        public bool NoCount { get; set; }
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
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReservePrice { get; set; }
        public bool Expr1 { get; set; }
    }
}
