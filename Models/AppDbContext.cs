using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BanHang.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-05TS1QQ;Initial Catalog=Project_BanHang;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.ToTable("Catalog");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CatalogName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Catalog_Name");
            });

            modelBuilder.Entity<Combo>(entity =>
            {
                entity.ToTable("Combo");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ComboName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Combo_Name");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("discount");

                entity.Property(e => e.DiscountMoney)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("discountMoney");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("endDate");

                entity.Property(e => e.ProductList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Product_List");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("startDate");

                entity.Property(e => e.TotalMoney)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("totalMoney");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.Username, "UQ__Customer__F3DBC572025E1FA3")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("address");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("birthDate");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.JoinDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("joinDate");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Username, "UQ__Employee__F3DBC572648A92F3")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("birthDate");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.JoinDate)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("joinDate");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("password");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Role_ID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("createdDate");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("Invoice_Name");

                entity.Property(e => e.ShipDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shipDate");

                entity.Property(e => e.ShipperId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Shipper_ID");

                entity.Property(e => e.TotalMoney)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("totalMoney");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("InvoiceDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComboId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Combo_ID");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Invoice_ID");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product_ID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CatalogId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Catalog_ID");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Product_Name");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__ProductD__9834FB9A45AFCFC4");

                entity.ToTable("ProductDetail");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product_ID");

                entity.Property(e => e.ProductDetail1)
                    .IsRequired()
                    .HasMaxLength(650)
                    .HasColumnName("Product_Detail");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Storage__9834FB9ADC7341FC");

                entity.ToTable("Storage");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Product_ID");

                entity.Property(e => e.ExportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("exportDate");

                entity.Property(e => e.ImportDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("importDate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
