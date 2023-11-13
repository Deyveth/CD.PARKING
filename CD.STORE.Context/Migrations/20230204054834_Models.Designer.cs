﻿// <auto-generated />
using System;
using CD.STORE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CD.STORE.Context.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230204054834_Models")]
    partial class Models
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CD.STORE.Entities.Inv.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", "inv");
                });

            modelBuilder.Entity("CD.STORE.Entities.Inv.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", "inv");
                });

            modelBuilder.Entity("CD.STORE.Entities.Sm.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("SaleId");

                    b.ToTable("Sale", "sm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Sm.SaleDetail", b =>
                {
                    b.Property<int>("SaleDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleDetailId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("SaleDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleDetail", "sm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Sm.SalesDocumentNumber", b =>
                {
                    b.Property<int>("SalesDocumentNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesDocumentNumberId"), 1L, 1);

                    b.Property<int>("LastNumber")
                        .HasColumnType("int");

                    b.HasKey("SalesDocumentNumberId");

                    b.ToTable("SalesDocumentNumber", "sm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("MenuId");

                    b.ToTable("Menu", "usm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.MenuRole", b =>
                {
                    b.Property<int>("MenuRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuRoleId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("MenuRoleId");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("MenuRole", "usm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.HasKey("RoleId");

                    b.ToTable("Role", "usm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime?>("DelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdaDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserDelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserInsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserUpdaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User", "usm");
                });

            modelBuilder.Entity("CD.STORE.Entities.Inv.Product", b =>
                {
                    b.HasOne("CD.STORE.Entities.Inv.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CD.STORE.Entities.Sm.SaleDetail", b =>
                {
                    b.HasOne("CD.STORE.Entities.Inv.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CD.STORE.Entities.Sm.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.MenuRole", b =>
                {
                    b.HasOne("CD.STORE.Entities.Usm.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CD.STORE.Entities.Usm.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CD.STORE.Entities.Usm.User", b =>
                {
                    b.HasOne("CD.STORE.Entities.Usm.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
