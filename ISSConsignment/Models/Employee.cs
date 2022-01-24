using System;
using System.Collections.Generic;

namespace ISSConsignment.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Invoices = new HashSet<Invoice>();
            SellerPayments = new HashSet<SellerPayment>();
        }

        public long EmployeeId { get; set; }
        public string EmployeeNumber { get; set; } = null!;
        public string ComputerId { get; set; } = null!;
        public string? JobTitle { get; set; }
        public bool IsAdmin { get; set; }
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
        public string? EmployeeNotes { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedByUser { get; set; }
        public string? ModifiedByDevice { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SellerPayment> SellerPayments { get; set; }
    }
}
