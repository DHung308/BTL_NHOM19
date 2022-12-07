﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTL_NHOM19.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    partial class ApplicationDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BTL_NHOM19.Models.Hoadon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ngayban")
                        .HasColumnType("TEXT");

                    b.Property<int>("SoluongHD")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("TenKH");

                    b.HasIndex("TenSP");

                    b.ToTable("Hoadon");
                });

            modelBuilder.Entity("BTL_NHOM19.Models.Khachhang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNV")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaysinhKH")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKH")
                        .HasColumnType("TEXT");

                    b.HasKey("MaKH");

                    b.ToTable("Khachhang");
                });

            modelBuilder.Entity("BTL_NHOM19.Models.Nhanvien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiachiNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNV")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaysinhNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("BTL_NHOM19.Models.Sanpham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GiaSP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSP");

                    b.ToTable("Sanpham");
                });

            modelBuilder.Entity("BTL_NHOM19.Models.Hoadon", b =>
                {
                    b.HasOne("BTL_NHOM19.Models.Khachhang", "Khachhang")
                        .WithMany()
                        .HasForeignKey("TenKH");

                    b.HasOne("BTL_NHOM19.Models.Sanpham", "Sanpham")
                        .WithMany()
                        .HasForeignKey("TenSP");

                    b.Navigation("Khachhang");

                    b.Navigation("Sanpham");
                });

#pragma warning restore 612, 618
        }
    }
}
