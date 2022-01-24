using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class ViewSaleItemsSeller
    {
        public long SaleItemId { get; set; }
        public long SellerId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ReservePrice { get; set; }
        public string? SaleItemNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
        public string SellerNumber { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? Phone { get; set; }
        public string? PhoneAlt { get; set; }
        public string? Email { get; set; }
        public string? EmailAlt { get; set; }
        public string? MailAddr1 { get; set; }
        public string? MailCity { get; set; }
        public string? MailAddr2 { get; set; }
        public string? MailState { get; set; }
        public string? MailZip { get; set; }
        public string? ShipAddr1 { get; set; }
        public string? ShipAddr2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZip { get; set; }
        public string? SellerNotes { get; set; }
        public DateTime? Expr1 { get; set; }
    }
}
