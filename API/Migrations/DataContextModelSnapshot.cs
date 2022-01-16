﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BankApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankApp.Models.Bank.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double");

                    b.Property<DateTime>("AccountCreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("AccountDeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("AccountState")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("AccountUpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BankApp.Models.Bank.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CustomerCreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CustomerDeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerLaststName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("CustomerState")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CustomerUpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BankApp.Models.Bank.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionCreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TransactionDeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("TransactionState")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("TransactionUpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("TransactionID");

                    b.HasIndex("AccountID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BankApp.Models.Bank.Account", b =>
                {
                    b.HasOne("BankApp.Models.Bank.Customer", "CustomerAccount")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BankApp.Models.Bank.Transaction", b =>
                {
                    b.HasOne("BankApp.Models.Bank.Account", "AccountTransaction")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
