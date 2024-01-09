using QuanLyNhaSach.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class hoadonDTO
    {
        public long id { get; set; }
        public long tongtien { get; set; }
        public long id_taikhoan { get; set; }
        public string hoten { get; set; }
        public DateTime ngaytao {  get; set; }
        public string display_id
        {
            get
            {
                return $"{id}";
            }
        }
        public taikhoan taikhoan { get; set; }
    }
}
