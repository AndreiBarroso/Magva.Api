﻿// <auto-generated />
using System;
using Magva.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magva.Infra.Data.Migrations
{
    [DbContext(typeof(MagvaDataContext))]
    [Migration("20190404212217_NewModelDatabase")]
    partial class NewModelDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Magva.Domain.Entities.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active")
                        .HasColumnName("Active");

                    b.Property<decimal>("Balance")
                        .HasColumnName("Balance")
                        .HasColumnType("money");

                    b.Property<string>("CardBrand")
                        .IsRequired()
                        .HasColumnName("CardBrand")
                        .HasColumnType("Varchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CardholderName")
                        .IsRequired()
                        .HasColumnName("CardholderName");

                    b.Property<Guid?>("CustomerId");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnName("ExpirationDate");

                    b.Property<bool>("HasPassword")
                        .HasColumnName("HasPassword");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnName("Number");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password");

                    b.Property<int>("SecurityCode")
                        .HasColumnName("SecurityCode")
                        .HasMaxLength(5);

                    b.Property<int>("Type")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("Magva.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnName("Document")
                        .HasColumnType("Varchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("Varchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("Varchar(40)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Magva.Domain.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnName("money")
                        .HasMaxLength(50);

                    b.Property<Guid?>("CardId");

                    b.Property<Guid?>("CustomerId");

                    b.Property<DateTime>("DateTransaction")
                        .HasColumnName("DateTransaction");

                    b.Property<int>("NumberInstallments")
                        .HasColumnName("Number");

                    b.Property<int>("Type")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Magva.Domain.Entities.Card", b =>
                {
                    b.HasOne("Magva.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Magva.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("Magva.Domain.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("Magva.Domain.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
