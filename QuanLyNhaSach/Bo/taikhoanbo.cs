using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Bo
{
    public class taikhoanbo
    {
        private BookContext cn;
        public taikhoanbo() 
        {
            cn = new BookContext();
        }

        public taikhoan Login(string tendangnhap, string matkhau)
        {
            taikhoan tk = cn.taikhoans
                .Where(t => tendangnhap == t.tendangnhap && matkhau == t.matkhau)
                .FirstOrDefault();
            return tk;

        }
        public taikhoan Register(string hoten, string tendangnhap, string matkhau)
        {
            taikhoan tk = new taikhoan
            {
                hoten = hoten,
                tendangnhap = tendangnhap,
                matkhau = matkhau
            };
            var register = cn.taikhoans.Add(tk);
            cn.SaveChanges();
            return tk;
        }
        public int CountUser()
        {
            int countUser = cn.taikhoans.Count();
            return countUser;
        }
        public decimal SumRevenue()
        {
            decimal sumRevenue = cn.hoadons.Sum(hd => hd.thanhtien);
            return sumRevenue;
        }
        public List<taikhoan> getUsers()
        {
            List<taikhoan> danhSachTaiKhoan = cn.taikhoans.ToList();
            return danhSachTaiKhoan;
        }
        public string getUserName(long id)
        {
            var username = cn.taikhoans
                .Where(t => t.id == id)
                .Select(s => s.tendangnhap).FirstOrDefault();
            return username;
        }
        public bool CheckDuplicateUsername(string tendangnhap)
        {
            return cn.taikhoans.Any(tk => tk.tendangnhap == tendangnhap);
        }
        public taikhoan InsertUser(string hoten, string tendangnhap, string matkhau)
        {
            taikhoan tk = new taikhoan
            {
                hoten = hoten,
                tendangnhap = tendangnhap,
                matkhau = matkhau
            };
            var insertUser = cn.taikhoans.Add(tk);
            cn.SaveChanges();
            return tk;
        }
        public taikhoan DeleteUser(long id)
        {
            var deleteUser = cn.taikhoans.Where(t => t.id == id).FirstOrDefault();
            if (deleteUser != null)
            {
                cn.taikhoans.Remove(deleteUser);
                cn.SaveChanges();
                return deleteUser;
            }
            return null;
        }
        public taikhoan UpdateUser(long id, string hoten, string tendangnhap, string matkhau)
        {

            var updateUser = cn.taikhoans
                .Where(t => t.id == id).FirstOrDefault();
            if (updateUser != null)
            {
                updateUser.hoten = hoten;
                updateUser.matkhau = matkhau;
                cn.SaveChanges();
                return updateUser;
            }
            return null;
        }
        public List<taikhoanDTO> getNameUser()
        {
            var users = cn.taikhoans
                .OrderBy(e => e.hoten)
                .Select(x => new taikhoanDTO
                {
                    id = x.id,
                    hoten = x.hoten
                }).ToList();
            // MessageBox.Show(users[1].ToString());
            return users;
        }
    }
}
