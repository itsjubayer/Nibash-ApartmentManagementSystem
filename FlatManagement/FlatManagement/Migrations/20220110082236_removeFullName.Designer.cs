﻿// <auto-generated />
using System;
using FlatManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlatManagement.Migrations
{
    [DbContext(typeof(FlatDBContext))]
    [Migration("20220110082236_removeFullName")]
    partial class removeFullName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlatManagement.Models.AgendaVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AgendaDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("AgendaDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("AgendaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LocationStr")
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("FlatManagement.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ETIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlatOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flat_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Per_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tenant")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pre_Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FlatManagement.Models.BillVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("BillDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("BillFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("BillStatus")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("BillType")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("FlatNo")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PreparedBy")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("FlatManagement.Models.CommitteeVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Roll")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Committees");
                });

            modelBuilder.Entity("FlatManagement.Models.CommonFundVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Amount")
                        .IsRequired()
                        .HasColumnType("decimal(25)");

                    b.Property<string>("CollectionBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("CollectionDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("FlatNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FlatOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FundType")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("CommonFunds");
                });

            modelBuilder.Entity("FlatManagement.Models.ContractVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillFrequency")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("BillType")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ContractName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("FlatManagement.Models.EmployeeVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmpNID")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EntryBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<DateTime?>("JoiningDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PicLoc")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FlatManagement.Models.EnumModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnumText")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("EnumValueType")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("EnumValues");
                });

            modelBuilder.Entity("FlatManagement.Models.FAQVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("EntryBy")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FaqDescription")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FaqTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("FlatManagement.Models.FlatConfigVM", b =>
                {
                    b.Property<string>("FlatNo")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Delimeter")
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("FlatPerFloor")
                        .HasColumnType("int");

                    b.Property<int?>("FlatPerWing")
                        .HasColumnType("int");

                    b.Property<int?>("FlatStartFrom")
                        .HasColumnType("int");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<int?>("GroundFloorStart")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Sequence")
                        .HasColumnType("int");

                    b.Property<int?>("TotalFlat")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("TotalWing")
                        .HasColumnType("int");

                    b.Property<int?>("Wing")
                        .HasColumnType("int");

                    b.Property<string>("WingName")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("WingPerFloor")
                        .HasColumnType("int");

                    b.Property<bool>("isWing")
                        .HasColumnType("bit");

                    b.HasKey("FlatNo");

                    b.ToTable("FlatConfigs");
                });

            modelBuilder.Entity("FlatManagement.Models.FlatVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlatNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FlatValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("FlatManagement.Models.MaintenanceVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("contract")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("entry_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("entry_date")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("maintenance_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("FlatManagement.Models.OwnerVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("DateTime");

                    b.Property<string>("ETIN")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Flat_No")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NID")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Per_Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Tenant")
                        .HasColumnType("bit");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("pre_Address")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("FlatManagement.Models.ResolutionVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgendaName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("PointNo")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ResolutionClosingNote")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ResponsibilityEmployee")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ResponsibilityFlatOwner")
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("DateTime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Resolutions");
                });

            modelBuilder.Entity("FlatManagement.Models.ServiceVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BillType")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("FileUpload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrepairedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("FlatManagement.Models.SupplierVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("ETIN")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NID")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Per_Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Pre_Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PrepairedBy")
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("FlatManagement.Models.TenantVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("DateTime");

                    b.Property<string>("ETIN")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NID")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Per_Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ownerId")
                        .HasColumnType("int");

                    b.Property<string>("pre_Address")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("FlatManagement.Models.TransactionVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("BillAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BillDueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BillFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Claim")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlatNo")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FlatOwner")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NextStatus")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PaidBy")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PreparedBy")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ReceiptFile")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ReceiptNumber")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TransactionCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionStep")
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FlatManagement.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FlatManagement.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlatManagement.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FlatManagement.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
