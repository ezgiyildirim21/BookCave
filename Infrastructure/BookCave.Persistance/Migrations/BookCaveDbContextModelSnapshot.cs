﻿// <auto-generated />
using System;
using BookCave.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookCave.Persistance.Migrations
{
    [DbContext(typeof(BookCaveDbContext))]
    partial class BookCaveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookCave.Domain.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ISBN");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.CategoryDetail", b =>
                {
                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("CategoryId", "ISBN");

                    b.HasIndex("ISBN");

                    b.ToTable("CategoryDetails");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSecretName")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ISBN");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("AddressTitle")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(13)");

                    b.Property<byte>("Quantity")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ISBN");

                    b.HasIndex("ISBN");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Book", b =>
                {
                    b.HasOne("BookCave.Domain.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("BookCave.Domain.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.CategoryDetail", b =>
                {
                    b.HasOne("BookCave.Domain.Entities.Category", "Category")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookCave.Domain.Entities.Book", "Book")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Comment", b =>
                {
                    b.HasOne("BookCave.Domain.Entities.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("ISBN");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("BookCave.Domain.Entities.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookCave.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Book", b =>
                {
                    b.Navigation("CategoryDetails");

                    b.Navigation("Comments");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Category", b =>
                {
                    b.Navigation("CategoryDetails");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookCave.Domain.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
