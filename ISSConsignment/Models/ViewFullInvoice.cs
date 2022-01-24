using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class ViewFullInvoice
    {
        public long ConsignmentSaleId { get; set; }
        public string? CompanyName { get; set; }
        public string? SaleTitle { get; set; }
        public long CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? Phone { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeNumber { get; set; } = null!;
        public string? JobTitle { get; set; }
        public bool IsAdmin { get; set; }
        public string? Expr1 { get; set; }
        public string? Expr2 { get; set; }
        public string? Expr3 { get; set; }
        public string? Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public decimal? TotalInvoiceAmtWithTax { get; set; }
        public string? InvoiceNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public long InvoiceDetailId { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public string? InvoiceDetailNotes { get; set; }
        public long SellerId { get; set; }
        public string SellerNumber { get; set; } = null!;
        public string? Expr4 { get; set; }
        public string? Expr5 { get; set; }
        public string? Expr6 { get; set; }
        public string? Expr7 { get; set; }
        public int SaleItemTypeId { get; set; }
        public string? CodeName { get; set; }
        public string? CodeDescription { get; set; }
    }
}
