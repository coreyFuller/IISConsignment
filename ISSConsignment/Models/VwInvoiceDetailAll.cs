using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwInvoiceDetailAll
    {
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
        public decimal? SalesTaxPercent { get; set; }
        public long CustomerId { get; set; }
        public string? CustFirstName { get; set; }
        public string? CustLastName { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeNumber { get; set; } = null!;
        public string? JobTitle { get; set; }
        public string? EmpFirstName { get; set; }
        public string? EmpLastName { get; set; }
        public string? EmpPhone { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public string? SellerFirstName { get; set; }
        public string? SellerLastName { get; set; }
        public string? SellerPhone { get; set; }
        public long InvoiceId { get; set; }
        public string? Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public string? PromoCode { get; set; }
        public string? InvoiceNotes { get; set; }
        public long InvoiceDetailId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public string? InvoiceDetailNotes { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
