using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BuyerService.Models
{
    public partial class EmartDBContext : DbContext
    {
        public EmartDBContext()
        {
        }

        public EmartDBContext(DbContextOptions<EmartDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Transactionhistory> Transactionhistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NG1UMP4\\SQLEXPRESS;Initial Catalog=EmartDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Buyer__7ED91ACED606A0D8")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNo)
                    .HasName("UQ__Buyer__D6D73A866139B1B2")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__Buyer__C9F2845682D81C7A")
                    .IsUnique();

                entity.Property(e => e.BuyerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.CartId)
                    .HasColumnName("cartId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasColumnName("buyerId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasColumnName("categoryId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("itemId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .IsRequired()
                    .HasColumnName("sellerId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryId)
                    .IsRequired()
                    .HasColumnName("subcategoryId")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.BuyerId)
                    .HasConstraintName("FK__Cart__buyerId__6754599E");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__categoryId__68487DD7");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__itemId__6B24EA82");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__sellerId__6A30C649");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.SubcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__subcategor__693CA210");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ__Category__8517B2E097EA4350")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Percentage)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Items__727E838B089F9438");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StockNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Items__CategoryI__37A5467C");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Items__SellerId__36B12243");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK__Items__Subcatego__38996AB5");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Seller__7ED91ACEC0AA1C5B")
                    .IsUnique();

                entity.HasIndex(e => e.Gstin)
                    .HasName("UQ__Seller__0604E65F62B215EB")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNo)
                    .HasName("UQ__Seller__D6D73A860F030FC8")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__Seller__C9F28456638ADAB9")
                    .IsUnique();

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gstin)
                    .IsRequired()
                    .HasColumnName("GSTIN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasIndex(e => e.SubcategoryName)
                    .HasName("UQ__SubCateg__9BAD5E87EC9399CF")
                    .IsUnique();

                entity.Property(e => e.SubcategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BriefDetails)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .IsRequired()
                    .HasColumnName("GST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__SubCatego__Categ__1ED998B2");
            });

            modelBuilder.Entity<Transactionhistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Transact__55433A6BCF772892");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfItems)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.Transactionhistory)
                    .HasForeignKey(d => d.BuyerId)
                    .HasConstraintName("FK__Transacti__Buyer__628FA481");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Transactionhistory)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Transacti__ItemI__6477ECF3");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Transactionhistory)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Transacti__Selle__6383C8BA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
