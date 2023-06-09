﻿// <auto-generated />
using System;
using EFC_03.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFC_03.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFC_03.Entities.ChiTietPhieuNhap", b =>
                {
                    b.Property<int>("ChiTietPhieuNhapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuNhapID"));

                    b.Property<int>("PhieuNhapId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuNhapID");

                    b.HasIndex("PhieuNhapId");

                    b.HasIndex("VatTuId");

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("EFC_03.Entities.ChiTietPhieuXuat", b =>
                {
                    b.Property<int>("ChiTietPhieuXuatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuXuatID"));

                    b.Property<int>("PhieuXuatId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongXuat")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuXuatID");

                    b.HasIndex("PhieuXuatId");

                    b.HasIndex("VatTuId");

                    b.ToTable("ChiTietPhieuXuat");
                });

            modelBuilder.Entity("EFC_03.Entities.PhieuNhap", b =>
                {
                    b.Property<int>("PhieuNhapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuNhapId"));

                    b.Property<string>("MaPhieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhieuNhapId");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("EFC_03.Entities.PhieuXuat", b =>
                {
                    b.Property<int>("PhieuXuatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuXuatId"));

                    b.Property<string>("MaPhieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhieuXuatId");

                    b.ToTable("PhieuXuat");
                });

            modelBuilder.Entity("EFC_03.Entities.VatTu", b =>
                {
                    b.Property<int>("VatTuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VatTuId"));

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenVatTu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VatTuId");

                    b.ToTable("VatTu");
                });

            modelBuilder.Entity("EFC_03.Entities.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("EFC_03.Entities.PhieuNhap", "phieuNhap")
                        .WithMany("chiTietPhieuNhapLists")
                        .HasForeignKey("PhieuNhapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC_03.Entities.VatTu", "VatTu")
                        .WithMany("chiTietPhieuNhapLists")
                        .HasForeignKey("VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VatTu");

                    b.Navigation("phieuNhap");
                });

            modelBuilder.Entity("EFC_03.Entities.ChiTietPhieuXuat", b =>
                {
                    b.HasOne("EFC_03.Entities.PhieuXuat", "phieuXuat")
                        .WithMany("chiTietPhieuXuatLists")
                        .HasForeignKey("PhieuXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC_03.Entities.VatTu", "VatTu")
                        .WithMany("chiTietPhieuXuatLists")
                        .HasForeignKey("VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VatTu");

                    b.Navigation("phieuXuat");
                });

            modelBuilder.Entity("EFC_03.Entities.PhieuNhap", b =>
                {
                    b.Navigation("chiTietPhieuNhapLists");
                });

            modelBuilder.Entity("EFC_03.Entities.PhieuXuat", b =>
                {
                    b.Navigation("chiTietPhieuXuatLists");
                });

            modelBuilder.Entity("EFC_03.Entities.VatTu", b =>
                {
                    b.Navigation("chiTietPhieuNhapLists");

                    b.Navigation("chiTietPhieuXuatLists");
                });
#pragma warning restore 612, 618
        }
    }
}
