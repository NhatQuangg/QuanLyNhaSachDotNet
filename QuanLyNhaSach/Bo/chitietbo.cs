using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Bo
{
    public class chitietbo
    {
        private BookContext cn;
        public chitietbo()
        {
            cn = new BookContext();
        }
        public List<chitiethoadonDTO> GetDetailsBill(long idHoaDon)
        {
            var query = from ctsp in cn.chitietsanphams
                        join sp in cn.sanphams on ctsp.id_sanpham equals sp.id
                        where ctsp.id_hoadon == idHoaDon
                        select new chitiethoadonDTO
                        {
                            id_sanpham = sp.id,
                            tensanpham = sp.tensanpham,
                            soluong = ctsp.soluong,
                            dongia = sp.dongia,
                            thanhtien = ctsp.soluong * sp.dongia
                        };

            List<chitiethoadonDTO> chiTietSanPham = query.ToList();
            return chiTietSanPham;
        }
        public long SumDetailsBill(long idHoaDon)
        {
            var query = from ctsp in cn.chitietsanphams
                        join sp in cn.sanphams on ctsp.id_sanpham equals sp.id
                        where ctsp.id_hoadon == idHoaDon
                        select new
                        {
                            SoLuong = ctsp.soluong,
                            DonGia = sp.dongia
                        };

            long tongTien = query.Sum(item => item.SoLuong * item.DonGia);

            return tongTien;
           
        }
        public long SumDetailProducts (long idHoaDon)
        {
            int amountProducts = cn.chitietsanphams
                .Count(ctsp => ctsp.id_hoadon == idHoaDon);

            return amountProducts;
        }
    }
}
