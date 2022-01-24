using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class VwInvoiceRegisterClose
    {
        public long ConsignmentSaleId { get; set; }
        public bool DefaultSale { get; set; }
        public string? SaleTitle { get; set; }
        public long CustomerId { get; set; }
        public string? CustomerFirst { get; set; }
        public string? CustomerLast { get; set; }
        public long EmployeeId { get; set; }
        public string ComputerId { get; set; } = null!;
        public string? EmployeeFirst { get; set; }
        public string? EmployeeLast { get; set; }
        public long InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? PaymentType { get; set; }
        public int? CheckNumber { get; set; }
        public string? CctransNumber { get; set; }
        public decimal? TotalInvoiceAmtWithTax { get; set; }
        public string? PromoCode { get; set; }
        public string? InvoiceNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }
        public long InvoiceDetailId { get; set; }
        public long? SaleItemId { get; set; }
        public long SellerId { get; set; }
        public int SaleItemTypeId { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PercentDiscount { get; set; }
        public decimal LineItemTotal { get; set; }
        public string? InvoiceDetailNotes { get; set; }
    }
}
