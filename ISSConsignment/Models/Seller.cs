using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class Seller
    {
        public Seller()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            SaleItems = new HashSet<SaleItem>();
            SellerPayments = new HashSet<SellerPayment>();
        }

        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        /// <summary>
        /// This will show or hide Seller from Invoice dropdowns.
        /// </summary>
        public bool? DisplaySeller { get; set; }
        /// <summary>
        /// Does Seller want NO DISCOUNT on this item?
        /// </summary>
        public bool NoDiscount { get; set; }
        public decimal ProfitPercent { get; set; }
        public decimal ProcessFee { get; set; }
        public bool? PricedBySeller { get; set; }
        public bool? DonateLeftOver { get; set; }
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
        public string? ShipAddr1 { get; set; }
        public string? ShipAddr2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZip { get; set; }
        public string? SellerNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        public virtual ICollection<SellerPayment> SellerPayments { get; set; }
    }
}
