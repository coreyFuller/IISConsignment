using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ISSConsignment.Models
{
    public partial class ISSConsignmentContext : DbContext
    {
        public ISSConsignmentContext()
        {
        }

        public ISSConsignmentContext(DbContextOptions<ISSConsignmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConsignmentSale> ConsignmentSales { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<SaleItem> SaleItems { get; set; } = null!;
        public virtual DbSet<SaleItemType> SaleItemTypes { get; set; } = null!;
        public virtual DbSet<Seller> Sellers { get; set; } = null!;
        public virtual DbSet<SellerPayment> SellerPayments { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        public virtual DbSet<ViewFullInvoice> ViewFullInvoices { get; set; } = null!;
        public virtual DbSet<ViewInvoiceInvoiceDetail> ViewInvoiceInvoiceDetails { get; set; } = null!;
        public virtual DbSet<ViewSaleItemsSeller> ViewSaleItemsSellers { get; set; } = null!;
        public virtual DbSet<VwConsignmentSaleDailyTotalwTax> VwConsignmentSaleDailyTotalwTaxes { get; set; } = null!;
        public virtual DbSet<VwConsignmentSaleDailyTotalwoTax> VwConsignmentSaleDailyTotalwoTaxes { get; set; } = null!;
        public virtual DbSet<VwConsignmentSaleTotalToDatewTax> VwConsignmentSaleTotalToDatewTaxes { get; set; } = null!;
        public virtual DbSet<VwConsignmentSaleTotalToDatewoTax> VwConsignmentSaleTotalToDatewoTaxes { get; set; } = null!;
        public virtual DbSet<VwInvoiceCurrent> VwInvoiceCurrents { get; set; } = null!;
        public virtual DbSet<VwInvoiceDetailAll> VwInvoiceDetailAlls { get; set; } = null!;
        public virtual DbSet<VwInvoiceDetailDisplay> VwInvoiceDetailDisplays { get; set; } = null!;
        public virtual DbSet<VwInvoiceDetailswConsignmentSaleId> VwInvoiceDetailswConsignmentSaleIds { get; set; } = null!;
        public virtual DbSet<VwInvoiceFull> VwInvoiceFulls { get; set; } = null!;
        public virtual DbSet<VwInvoiceRegisterClose> VwInvoiceRegisterCloses { get; set; } = null!;
        public virtual DbSet<VwInvoiceTotal> VwInvoiceTotals { get; set; } = null!;
        public virtual DbSet<VwInvoiceTotalsAll> VwInvoiceTotalsAlls { get; set; } = null!;
        public virtual DbSet<VwInvoiceTotalsAll1> VwInvoiceTotalsAll1s { get; set; } = null!;
        public virtual DbSet<VwInvoicesNoDetail> VwInvoicesNoDetails { get; set; } = null!;
        public virtual DbSet<VwSaleItemsAll> VwSaleItemsAlls { get; set; } = null!;
        public virtual DbSet<VwSaleItemsAvailable> VwSaleItemsAvailables { get; set; } = null!;
        public virtual DbSet<VwSellerPayment> VwSellerPayments { get; set; } = null!;
        public virtual DbSet<VwSellerSaleItem> VwSellerSaleItems { get; set; } = null!;
        public virtual DbSet<VwSellerSaleItemsSold> VwSellerSaleItemsSolds { get; set; } = null!;
        public virtual DbSet<VwSellerSaleSaleItemsWithSaleItem> VwSellerSaleSaleItemsWithSaleItems { get; set; } = null!;
        public virtual DbSet<VwSellersThisSale> VwSellersThisSales { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=desktop-oae44f2\\sqlexpress;Database=ISSConsignment;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsignmentSale>(entity =>
            {
                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.AcceptConsignorsEndDate).HasColumnType("date");

                entity.Property(e => e.AcceptConsignorsStartDate).HasColumnType("date");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFacebook)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTwitter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountSalesEndDate).HasColumnType("date");

                entity.Property(e => e.DiscountSalesPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.DiscountSalesStartDate).HasColumnType("date");

                entity.Property(e => e.MinimumRequireDesc)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((20.00))");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleEndDate).HasColumnType("date");

                entity.Property(e => e.SaleStartDate).HasColumnType("date");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SaleWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_CustomerName");

                entity.HasIndex(e => e.Phone, "IX_CustomerPhone");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.ComputerId, "IX_EmployeeComputerID")
                    .IsUnique();

                entity.HasIndex(e => e.LastName, "IX_EmployeeLastName");

                entity.HasIndex(e => e.EmployeeNumber, "IX_EmployeeNumber")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ComputerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComputerID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Cashier')");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => e.ConsignmentSaleId, "IX_InvoiceConsignmentSaleID");

                entity.HasIndex(e => e.EmployeeId, "IX_InvoiceEmployeeID");

                entity.HasIndex(e => e.Status, "IX_InvoiceStatus");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.InvoiceDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Cash')");

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpConvertedId).HasColumnName("TmpConvertedID");

                entity.Property(e => e.TotalInvoiceAmtWithTax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ConsignmentSale)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ConsignmentSaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_ConsignmentSales");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_Employees");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetailInvoiceID");

                entity.HasIndex(e => e.SaleItemTypeId, "IX_InvoiceDetailSaleItemTypeID");

                entity.HasIndex(e => e.SellerId, "IX_InvoiceDetailSellerID");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Sale Item')");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PercentDiscount)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_InvoiceDetails_Invoices");

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.SaleItemId)
                    .HasConstraintName("FK_InvoiceDetails_SaleItems");

                entity.HasOne(d => d.SaleItemType)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.SaleItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_SaleItemTypes");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_Sellers");
            });

            modelBuilder.Entity<SaleItem>(entity =>
            {
                entity.HasIndex(e => e.SaleItemTypeId, "IX_SaleItemType");

                entity.HasIndex(e => e.SaleItemId, "IX_SaleItems");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoDiscount).HasComment("Does Seller want NO DISCOUNT on this item?");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReservePrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleItemNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.HasOne(d => d.ConsignmentSale)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.ConsignmentSaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleItems_ConsignmentSales");

                entity.HasOne(d => d.SaleItemType)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.SaleItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleItems_SaleItemTypes");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleItems_Sellers");
            });

            modelBuilder.Entity<SaleItemType>(entity =>
            {
                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unknown')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleItemTypeNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasIndex(e => e.Email, "IX_SellerEmail");

                entity.HasIndex(e => e.LastName, "IX_SellerLastName");

                entity.HasIndex(e => e.SellerNumber, "IX_SellerNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "IX_SellerPhone");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.DisplaySeller)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("This will show or hide Seller from Invoice dropdowns.");

                entity.Property(e => e.DonateLeftOver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoDiscount).HasComment("Does Seller want NO DISCOUNT on this item?");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricedBySeller)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProcessFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((5.00))");

                entity.Property(e => e.ProfitPercent)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.6))");

                entity.Property(e => e.SellerNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellerPayment>(entity =>
            {
                entity.HasIndex(e => e.ConsignmentSaleId, "IX_SellerPaymentConsignmentSaleID");

                entity.HasIndex(e => e.EmployeeId, "IX_SellerPaymentEmployeeID");

                entity.HasIndex(e => e.SellerId, "IX_SellerPaymentSellerID");

                entity.Property(e => e.SellerPaymentId).HasColumnName("SellerPayment_ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Check')");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerPaymentNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConsignmentSale)
                    .WithMany(p => p.SellerPayments)
                    .HasForeignKey(d => d.ConsignmentSaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellerPayments_ConsignmentSales");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SellerPayments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellerPayments_Employees");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.SellerPayments)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SellerPayments_Sellers");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.CheckoutEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceTotalNoTax).HasColumnType("money");

                entity.Property(e => e.InvoiceTotalWtax)
                    .HasColumnType("decimal(25, 6)")
                    .HasColumnName("InvoiceTotalWTax");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.TotalItemTax).HasColumnType("decimal(24, 6)");
            });

            modelBuilder.Entity<ViewFullInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Full_Invoice");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expr3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expr5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expr6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalInvoiceAmtWithTax).HasColumnType("money");
            });

            modelBuilder.Entity<ViewInvoiceInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_InvoiceInvoiceDetail");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalInvoiceAmtWithTax).HasColumnType("money");
            });

            modelBuilder.Entity<ViewSaleItemsSeller>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SaleItemsSeller");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReservePrice).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwConsignmentSaleDailyTotalwTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwConsignmentSaleDailyTotalwTax");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.DailySalesTotal).HasColumnType("money");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwConsignmentSaleDailyTotalwoTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwConsignmentSaleDailyTotalwoTax");

                entity.Property(e => e.ConsignmentSaleDailyTotalswoTax).HasColumnType("money");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwConsignmentSaleTotalToDatewTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwConsignmentSaleTotalToDatewTax");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.ConsignmentSaleTotalToDate).HasColumnType("money");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwConsignmentSaleTotalToDatewoTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwConsignmentSaleTotalToDatewoTax");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.ConsignmentSaleSaleTotalToDatewoTax).HasColumnType("money");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwInvoiceCurrent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceCurrent");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFacebook)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTwitter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SaleWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalInvoiceAmtWithTax).HasColumnType("money");
            });

            modelBuilder.Entity<VwInvoiceDetailAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceDetailALL");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFacebook)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTwitter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.MinimumRequireDesc).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SaleWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SellerFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwInvoiceDetailDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceDetailDisplay");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwInvoiceDetailswConsignmentSaleId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceDetailswConsignmentSaleID");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");
            });

            modelBuilder.Entity<VwInvoiceFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceFull");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFacebook)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTwitter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SaleWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalInvoiceAmtWithTax).HasColumnType("money");
            });

            modelBuilder.Entity<VwInvoiceRegisterClose>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceRegisterClose");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.ComputerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComputerID");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.CustomerFirst)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Customer_First");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerLast)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Last");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeFirst)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Employee_First");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeLast)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Last");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceDetailNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.TotalInvoiceAmtWithTax).HasColumnType("money");
            });

            modelBuilder.Entity<VwInvoiceTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceTotals");

                entity.Property(e => e.CheckoutEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceTotalNoTax).HasColumnType("money");

                entity.Property(e => e.InvoiceTotalTax).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.InvoiceTotalWithTax).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<VwInvoiceTotalsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceTotalsALL");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.LineItemTotalwTax).HasColumnType("decimal(25, 6)");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<VwInvoiceTotalsAll1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceTotalsALL1");

                entity.Property(e => e.CctransNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCTransNumber");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SumOfLineItemTotalNoTax).HasColumnType("money");

                entity.Property(e => e.SumOfLineItemTotalwTax).HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<VwInvoicesNoDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoicesNoDetail");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");
            });

            modelBuilder.Entity<VwSaleItemsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSaleItemsAll");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReservePrice).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSaleItemsAvailable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSaleItemsAvailable");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReservePrice).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSellerPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSellerPayments");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CheckDate).HasColumnType("date");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComputerID");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDate).HasColumnType("date");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerPaymentId).HasColumnName("SellerPayment_ID");

                entity.Property(e => e.SellerPaymentNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSellerSaleItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSellerSaleItems");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProcessFee).HasColumnType("money");

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ReservePrice).HasColumnType("money");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSellerSaleItemsSold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSellerSaleItemsSold");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetail_ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemTotal).HasColumnType("money");

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentDiscount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProcessFee).HasColumnType("money");

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSellerSaleSaleItemsWithSaleItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSellerSaleSaleItemsWithSaleItems");

                entity.Property(e => e.AcceptConsignorsEndDate).HasColumnType("date");

                entity.Property(e => e.AcceptConsignorsStartDate).HasColumnType("date");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFacebook)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTwitter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.ConsignmentSaleNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountSalesEndDate).HasColumnType("date");

                entity.Property(e => e.DiscountSalesPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.DiscountSalesStartDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByDevice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ReservePrice).HasColumnType("money");

                entity.Property(e => e.SaleEndDate).HasColumnType("date");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItem_ID");

                entity.Property(e => e.SaleItemNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleItemTypeId).HasColumnName("SaleItemType_ID");

                entity.Property(e => e.SaleStartDate).HasColumnType("date");

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SaleWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNotes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddr2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSellersThisSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSellersThisSale");

                entity.Property(e => e.ConsignmentSaleId).HasColumnName("ConsignmentSale_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddr1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailState)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_ID");

                entity.Property(e => e.SellerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
