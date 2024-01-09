using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Bo
{
    public class sanphambo
    {
        private BookContext cn;
        public sanphambo()
        {
            cn = new BookContext();
        }
        public int CountProducts()
        {
            int sumProducts = cn.sanphams.Count();
            return sumProducts;
        }
        public List<sanpham> getProducts()
        {
            List<sanpham> listProducts = cn.sanphams.ToList();
            return listProducts;
        }
        public sanpham InsertProducts(string tensanpham, long soluong, long dongia, string anh)
        {
            sanpham sp = new sanpham
            {        
                tensanpham = tensanpham,
                soluong = soluong,
                dongia = dongia,
                anh = anh
            };
            var insertProducts = cn.sanphams.Add(sp);
            cn.SaveChanges();
            return sp;
        }
        public string getNameProduct(long id)
        {
            var nameProduct = cn.sanphams
                .Where(t => t.id == id)
                .Select(s => s.tensanpham).FirstOrDefault();
            return nameProduct;
        }
        public sanpham UpdateProducts(long id, string tensanpham, long soluong, long dongia, string anh)
        {

            var updateProducts = cn.sanphams
                .Where(t => t.id == id).FirstOrDefault();
            if (updateProducts != null) {
                updateProducts.tensanpham = tensanpham;
                updateProducts.soluong = soluong;
                updateProducts.dongia = dongia;
                updateProducts.anh = anh;
                cn.SaveChanges();
                return updateProducts;
            }
            return null;
        }
        public sanpham DeleteProducts(long id)
        {
            var deleteProducts = cn.sanphams.Where(t => t.id == id).FirstOrDefault();
            if (deleteProducts != null)
            {
                cn.sanphams.Remove(deleteProducts);
                cn.SaveChanges();
                return deleteProducts;
            }
            return null;
        }
        public List<sanpham> GetProductsOrder(int number)
        {
            if (number == 1)
            {
                List<sanpham> sortedProducts = cn.sanphams.OrderBy(s => s.dongia).ToList();
                return sortedProducts;
            }
            if (number == 2)
            {
                List<sanpham> sortedProducts = cn.sanphams.OrderByDescending(s => s.dongia).ToList();
                return sortedProducts;
            }
            return null;
        }
        public List<sanphamDTO> getNameProducts()
        {
            var id_sanpham = cn.sanphams
                .OrderBy(e => e.tensanpham)
                .Select(x => new sanphamDTO
                {
                    id = x.id,
                    tensanpham = x.tensanpham
                }).ToList();
           //  MessageBox.Show(id_sanpham[0].ToString());
            return id_sanpham;
        }
        public long GetPrice(long id_sanpham)
        {
            var donGia = cn.sanphams
                .Where(sp => sp.id == id_sanpham)
                .Select(sp => sp.dongia)
                .FirstOrDefault();

            return donGia;
        }
        public long GetAmount(long id_sanpham)
        {
            var amount = cn.sanphams
                .Where(sp => sp.id == id_sanpham)
                .Select(sp => sp.soluong)
                .FirstOrDefault();

            return amount;
        }
        public void UpdateSoLuong(long sanphamId, int soLuongMua)
        {
            var sanpham = cn.sanphams.FirstOrDefault(sp => sp.id == sanphamId);
            if (sanpham != null)
            {
                sanpham.soluong -= soLuongMua;
                cn.SaveChanges();
            }
            
        }
        public sanpham GetSanPhamById(long idSanPham)
        {
            return cn.sanphams.FirstOrDefault(sp => sp.id == idSanPham);
        }

        public List<sanpham> TimKiemSanPham(string tensanpham)
        {
            var key = cn.sanphams
                        .Where(t => t.tensanpham.ToLower().Contains(tensanpham.ToLower()))
                        .Select(t => new sanpham
                        {
                            id = t.id,
                            tensanpham = t.tensanpham,
                            soluong = t.soluong,
                            dongia = t.dongia,
                            anh = t.anh,
                        }).ToList();

            return key;
        }

    }
}
