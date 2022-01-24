using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class ConsignmentSale
    {
        public ConsignmentSale()
        {
            Invoices = new HashSet<Invoice>();
            SaleItems = new HashSet<SaleItem>();
            SellerPayments = new HashSet<SellerPayment>();
        }

        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public decimal MinimumRequireDesc { get; set; }
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
        public DateTime? AcceptConsignorsStartDate { get; set; }
        public DateTime? AcceptConsignorsEndDate { get; set; }
        public DateTime? SaleStartDate { get; set; }
        public DateTime? SaleEndDate { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public bool UseDiscountSales { get; set; }
        public DateTime? DiscountSalesStartDate { get; set; }
        public DateTime? DiscountSalesEndDate { get; set; }
        public decimal DiscountSalesPercent { get; set; }
        public string? ConsignmentSaleNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        public virtual ICollection<SellerPayment> SellerPayments { get; set; }
    }
}
