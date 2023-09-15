﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonthlyExam.Models;

#nullable disable

namespace MonthlyExam.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20230915164204_Initial Create")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MonthlyExam.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SellUnit")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Pototo",
                            Picture = "1.jpg",
                            SellUnit = 1,
                            UnitPrice = 900.00m
                        });
                });

            modelBuilder.Entity("MonthlyExam.Models.ProductInventory", b =>
                {
                    b.Property<int>("ProductInventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductInventoryId"));

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductInventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventories");

                    b.HasData(
                        new
                        {
                            ProductInventoryId = 1,
                            Date = new DateTime(2023, 9, 5, 22, 42, 4, 129, DateTimeKind.Local).AddTicks(5241),
                            ProductId = 1,
                            Quantity = 100
                        },
                        new
                        {
                            ProductInventoryId = 2,
                            Date = new DateTime(2023, 9, 5, 22, 42, 4, 129, DateTimeKind.Local).AddTicks(5265),
                            ProductId = 1,
                            Quantity = 20
                        });
                });

            modelBuilder.Entity("MonthlyExam.Models.ProductInventory", b =>
                {
                    b.HasOne("MonthlyExam.Models.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MonthlyExam.Models.Product", b =>
                {
                    b.Navigation("ProductInventories");
                });
#pragma warning restore 612, 618
        }
    }
}