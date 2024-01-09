using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Bo
{
    public class doanhthubo
    {
        private BookContext cn;
        public doanhthubo()
        {
            cn = new BookContext();
        }
        public List<doanhthuDTO> GetDoanhThu()
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        group new { cts, sanpham } by new { sanpham.id, sanpham.tensanpham } into grouped
                        select new
                        {
                            id_sanpham = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia)
                        };

            foreach (var item in query)
            {
                result.Add(new doanhthuDTO
                {
                    id = item.id_sanpham,
                    tensanpham = item.tensanpham,
                    soluongbanduoc = item.soluongbanduoc,
                    tongtienbanduoc = item.tongtienbanduoc
                });
            }

            return result;
        }
        public List<doanhthuDTO> GetDoanhThu(DateTime startDate, DateTime endDate)
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        group new { cts, sanpham } by new { sanpham.id, sanpham.tensanpham } into grouped
                        select new
                        {
                            id_sanpham = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia)
                        };

            foreach (var item in query)
            {
                result.Add(new doanhthuDTO
                {
                    id = item.id_sanpham,
                    tensanpham = item.tensanpham,
                    soluongbanduoc = item.soluongbanduoc,
                    tongtienbanduoc = item.tongtienbanduoc
                });
            }

            return result;
        }
        public List<doanhthuDTO> GetDoanhThuOrderBy(DateTime startDate, DateTime endDate, int value)
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        group new { cts, sanpham } by new { sanpham.id, sanpham.tensanpham } into grouped
                        select new
                        {
                            id_sanpham = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia)
                        };

            // giam dan
            if (value == 1)
            {
                query = query.OrderBy(item => item.tensanpham);
            }
            // tang dan
            else if (value == 0)
            {
                query = query.OrderByDescending(item => item.tensanpham);
            }

            foreach (var item in query)
            {
                result.Add(new doanhthuDTO
                {
                    id = item.id_sanpham,
                    tensanpham = item.tensanpham,
                    soluongbanduoc = item.soluongbanduoc,
                    tongtienbanduoc = item.tongtienbanduoc
                });
            }

            return result;
        }
        public List<doanhthuDTO> SapXepTheoTongTien(DateTime startDate, DateTime endDate, int value)
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        group new { cts, sanpham } by new { sanpham.id, sanpham.tensanpham } into grouped
                        select new doanhthuDTO
                        {
                            id = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia)
                        };

            if (value == 1)
            {
                query = query.OrderByDescending(item => item.tongtienbanduoc);
            }
            else
            {
                query = query.OrderBy(item => item.tongtienbanduoc);
            }

            result = query.ToList();

            return result;
        }
        /*public doanhthuDTO GetSanPhamBanChayNhatThoiGian(DateTime startDate, DateTime endDate)
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        group new { cts, sanpham } by new 
                        { sanpham.id, sanpham.tensanpham, sanpham.dongia, sanpham.anh } into grouped
                        select new doanhthuDTO
                        {
                            id = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia),
                            anh = grouped.Key.anh,
                            dongia = grouped.Key.dongia
                        };


            query = query.OrderBy(item => item.tensanpham);

            foreach (var item in query)
            {
                result.Add(new doanhthuDTO
                {
                    id = item.id,
                    tensanpham = item.tensanpham,
                    soluongbanduoc = item.soluongbanduoc,
                    tongtienbanduoc = item.tongtienbanduoc,
                    anh = item.anh,
                    dongia = item.dongia
                });
            }

            return result.FirstOrDefault();
        }*/
        public long GetTongDoanhThu(DateTime startDate, DateTime endDate)
        {
            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        select new
                        {
                            TongTienBanDuoc = cts.soluong * cts.sanpham.dongia
                        };

            return query.Sum(x => x.TongTienBanDuoc);
        }
        public doanhthuDTO GetSanPhamBanChayNhat()
        {
            var query = from cts in cn.chitietsanphams
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        group new { cts, sanpham } by new { sanpham.id, sanpham.tensanpham, sanpham.anh, sanpham.dongia } into grouped
                        orderby grouped.Sum(x => x.cts.soluong) descending
                        select new doanhthuDTO
                        {
                            id = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia),
                            anh = grouped.Key.anh,
                            dongia = grouped.Key.dongia
                        };

            return query.FirstOrDefault(); // Lấy sản phẩm bán chạy nhất (hoặc null nếu không có sản phẩm nào)
        }
        public doanhthuDTO GetSanPhamBanChayNhatThoiGian(DateTime startDate, DateTime endDate)
        {
            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        where hoadon.ngaytao >= startDate && hoadon.ngaytao <= endDate
                        group new { cts, sanpham } by new
                        {
                            sanpham.id,
                            sanpham.tensanpham,
                            sanpham.dongia,
                            sanpham.anh
                        } into grouped
                        select new doanhthuDTO
                        {
                            id = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia),
                            anh = grouped.Key.anh,
                            dongia = grouped.Key.dongia
                        };

            var topProduct = query.OrderByDescending(item => item.tongtienbanduoc).FirstOrDefault();

            // MessageBox.Show(topProduct.tensanpham + " " + topProduct.tongtienbanduoc);
            return topProduct;
        }
        public doanhthuDTO GetSanPhamBanChayNhatBanDau()
        {
            List<doanhthuDTO> result = new List<doanhthuDTO>();

            var query = from cts in cn.chitietsanphams
                        join hoadon in cn.hoadons on cts.id_hoadon equals hoadon.id
                        join sanpham in cn.sanphams on cts.id_sanpham equals sanpham.id
                        group new { cts, sanpham } by new
                        { sanpham.id, sanpham.tensanpham, sanpham.dongia, sanpham.anh } into grouped
                        select new doanhthuDTO
                        {
                            id = grouped.Key.id,
                            tensanpham = grouped.Key.tensanpham,
                            soluongbanduoc = grouped.Sum(x => x.cts.soluong),
                            tongtienbanduoc = grouped.Sum(x => x.cts.soluong * x.sanpham.dongia),
                            anh = grouped.Key.anh,
                            dongia = grouped.Key.dongia
                        };


            query = query.OrderBy(item => item.tensanpham);

            foreach (var item in query)
            {
                result.Add(new doanhthuDTO
                {
                    id = item.id,
                    tensanpham = item.tensanpham,
                    soluongbanduoc = item.soluongbanduoc,
                    tongtienbanduoc = item.tongtienbanduoc,
                    anh = item.anh,
                    dongia = item.dongia
                });
            }

            return result.FirstOrDefault();
        }
    }
}
