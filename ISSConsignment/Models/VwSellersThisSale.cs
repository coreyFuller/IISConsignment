using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwSellersThisSale
    {
        public long ConsignmentSaleId { get; set; }
        public string? SaleTitle { get; set; }
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
    }
}
