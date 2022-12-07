using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTL_NHOM19.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<BTL_NHOM19.Models.Sanpham> Sanpham { get; set; } = default!;

        public DbSet<BTL_NHOM19.Models.Nhanvien> Nhanvien { get; set; } = default!;
        
        public DbSet<BTL_NHOM19.Models.Khachhang> Khachhang { get; set; } = default!;

        public DbSet<BTL_NHOM19.Models.Hoadon> Hoadon { get; set; } = default!;
    }
