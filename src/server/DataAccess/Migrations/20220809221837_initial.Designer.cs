﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220809221837_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                            CompanyId = new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"),
                            CreatedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6071),
                            ModifiedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6072),
                            Name = "Test Branch"
                        });
                });

            modelBuilder.Entity("Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("APIKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"),
                            APIKey = "test",
                            CreatedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5956),
                            ModifiedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5964),
                            Name = "Test Company",
                            UnitPrice = 2.5m
                        });
                });

            modelBuilder.Entity("Entities.QueryCounter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("QueryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("QueryCounters");
                });

            modelBuilder.Entity("Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PNR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f225c6c-ee73-4bbb-a1ab-29a452cc8c89"),
                            BranchId = new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                            CompanyId = new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"),
                            CreatedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6118),
                            CustomerIdentity = "test-employee",
                            DropOffDate = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120),
                            ModifiedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6119),
                            PNR = "test-employee",
                            PaymentStatus = true,
                            PickUpDate = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120),
                            Reference = "test-employee"
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<short>("Role")
                        .HasColumnType("smallint");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ef223f8-548e-4507-af62-e24a85380a78"),
                            BranchId = new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                            CreatedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6085),
                            Email = "employee@test.com",
                            Firstname = "Test Employee",
                            Lastname = "Test Employee",
                            ModifiedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6086),
                            PasswordHash = new byte[0],
                            PasswordSalt = new byte[0],
                            Role = (short)0,
                            Status = (short)1,
                            Username = "employee"
                        },
                        new
                        {
                            Id = new Guid("35c708fd-6853-43a1-b670-152e323a576d"),
                            BranchId = new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                            CreatedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088),
                            Email = "manager@test.com",
                            Firstname = "Test Manager",
                            Lastname = "Test Manager",
                            ModifiedOn = new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088),
                            PasswordHash = new byte[0],
                            PasswordSalt = new byte[0],
                            Role = (short)1,
                            Status = (short)1,
                            Username = "manager"
                        });
                });

            modelBuilder.Entity("Entities.Branch", b =>
                {
                    b.HasOne("Entities.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.QueryCounter", b =>
                {
                    b.HasOne("Entities.Branch", "Branch")
                        .WithMany("QueryCounters")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Company", "Company")
                        .WithMany("QueryCounters")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.Reservation", b =>
                {
                    b.HasOne("Entities.Branch", "Branch")
                        .WithMany("Reservations")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Company", "Company")
                        .WithMany("Reservations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.HasOne("Entities.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Entities.Branch", b =>
                {
                    b.Navigation("QueryCounters");

                    b.Navigation("Reservations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Company", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("QueryCounters");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}