using K22CNTT3_NguyenVanHuynh_Project2.Bussiness;
using K22CNTT3_NguyenVanHuynh_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace K22CNTT3_NguyenVanHuynh_Project2.Controllers
{
    public class NVHCartController : Controller
    {
        public const string NVHCartSessionKey = "NVHCartSessionKey";
        NVHEntities dbEntities = new NVHEntities();
        private NVH_ShoppingCart GetCart()
        {
            var cart = Session[NVHCartSessionKey] as NVH_ShoppingCart;
            if (cart == null) {
                cart = new NVH_ShoppingCart();
                Session[NVHCartSessionKey] = cart;
            }
            return cart;    
        }

        public ActionResult AddToCart(int id, string TenSanPham, string HinhAnh, int SoLuongMUa, float? DonGiaMua =0)
        {
            float DonGia = DonGiaMua ?? 0;
            var cart = GetCart();
            var item = new NVHCartItem
            {
                Id = id,
                TenSanPham = TenSanPham,
                HinhAnh = HinhAnh,
                SoLuongMua = SoLuongMUa,
                DonGiaMua = (float)DonGiaMua,
                ThanhTien = (float)(SoLuongMUa * DonGiaMua)

            };
            cart.Items.Add(item);
            return RedirectToAction("Index");
        }
        // GET: NVHCart
        public ActionResult Index()
        {
            var cart = GetCart();
            return View(cart.Items);
        }
    }
}