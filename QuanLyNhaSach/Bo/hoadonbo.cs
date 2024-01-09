using Microsoft.EntityFrameworkCore;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Bo
{
    public class hoadonbo
    {
        private BookContext cn;
        private sanphambo spbo;
        public hoadonbo()
        {
            cn = new BookContext();
        }
        public List<hoadonDTO> getIdHD()
        {
            var id_hoadon = cn.hoadons
                .OrderBy(e => e.id)
                .Select(x => new hoadonDTO
                {
                    id = x.id
                }).ToList();
            return id_hoadon;
        }
        public hoadonDTO LayThongTinNguoiDungTheoHoaDonId(long idHoaDon)
        {
            var inforUser = (from hoadon in cn.hoadons
                             join taikhoan in cn.taikhoans on hoadon.id_taikhoan equals taikhoan.id
                             where hoadon.id == idHoaDon
                             select new hoadonDTO
                             {
                                 id_taikhoan = taikhoan.id,
                                 hoten = taikhoan.hoten
                             }).FirstOrDefault();

            var ketQua = inforUser;

            return ketQua;
        }

        public bool ThemHoaDon(List<sanphamDTO> selectedProductsList, long idUser)
        {
            if (selectedProductsList != null)
            {
                hoadon newHoaDon = new hoadon
                {
                    id_taikhoan = idUser,
                    thanhtien = selectedProductsList.Sum(sp => long.Parse(sp.thanhtien)),
                    ngaytao = DateTime.Now
                };

                cn.hoadons.Add(newHoaDon);
                cn.SaveChanges();

                long idHoaDon = newHoaDon.id;

                foreach (var selectedProduct in selectedProductsList)
                {
                    chitietsanpham newChiTiet = new chitietsanpham
                    {
                        id_hoadon = idHoaDon,
                        id_sanpham = selectedProduct.id,
                        soluong = long.Parse(selectedProduct.soluongmua),
                    };
                    cn.chitietsanphams.Add(newChiTiet);

                    var sanpham = cn.sanphams
                    .FirstOrDefault(sp => sp.id == selectedProduct.id);

                    if (sanpham != null)
                    {
                        sanpham.soluong -= long.Parse(selectedProduct.soluongmua);

                        cn.Entry(sanpham).State = EntityState.Modified;
                    }
                }
                cn.SaveChanges();
                return true;
            }
            return false;
        }

        public DateTime GetNgayTaoHoaDonById(long idHoaDon)
        {
            var ngayTao = cn.hoadons
                .Where(hd => hd.id == idHoaDon)
                .Select(hd => hd.ngaytao)
                .FirstOrDefault();
            return ngayTao;            
        }
    }
    
}
