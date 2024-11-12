using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNTT3_NguyenVanHuynh_Project2.Models
{
    public class NVHCartItem
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuongMua { get; set; }
        public float DonGiaMua {  get; set; }
        public float ThanhTien {  get; set; }
    }
}