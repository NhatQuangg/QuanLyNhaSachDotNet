using Microsoft.EntityFrameworkCore;

namespace QuanLyNhaSach.Data
{
    public class BookContext : DbContext
    {
        public DbSet<taikhoan> taikhoans { get; set; }
        public DbSet<sanpham> sanphams { get; set; }
        public DbSet<hoadon> hoadons { get; set; }
        public DbSet<chitietsanpham> chitietsanphams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NHAT-QUANG\\SQL; Database=quanlynhasach; Trusted_Connection=True; TrustServerCertificate=True;User=sa;password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            taikhoan taikhoan = new taikhoan
            {
                id = 1,
                hoten = "admin",
                tendangnhap = "admin",
                matkhau = "123"
            };
            modelBuilder.Entity<taikhoan>().HasData(taikhoan);
        }
    }
}
