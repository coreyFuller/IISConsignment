using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSellerSaleSaleItemsWithSaleItem
    {
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public bool DisplaySeller { get; set; }
        public bool NoDiscount { get; set; }
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
        public string? ShipAddr1 { get; set; }
        public string? ShipAddr2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZip { get; set; }
        public string? SellerNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? SaleWebsite { get; set; }
        public string? CompanyFacebook { get; set; }
        public string? CompanyTwitter { get; set; }
        public string? CompanyEmail { get; set; }
        public string? StorePhone { get; set; }
        public string? StoreAddr1 { get; set; }
        public string? StoreAddr2 { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public string? StoreZip { get; set; }
        public DateTime? AcceptConsignorsStartDate { get; set; }
        public DateTime? AcceptConsignorsEndDate { get; set; }
        public DateTime? SaleStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public bool UseDiscountSales { get; set; }
        public DateTime? DiscountSalesStartDate { get; set; }
        public DateTime? DiscountSalesEndDate { get; set; }
        public decimal? DiscountSalesPercent { get; set; }
        public string? ConsignmentSaleNotes { get; set; }
        public long SaleItemId { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReservePrice { get; set; }
        public bool SaleItemNoDiscount { get; set; }
        public string? SaleItemNotes { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
    }
}
