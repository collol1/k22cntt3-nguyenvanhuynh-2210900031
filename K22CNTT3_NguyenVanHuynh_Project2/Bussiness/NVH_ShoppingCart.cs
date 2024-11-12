using K22CNTT3_NguyenVanHuynh_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNTT3_NguyenVanHuynh_Project2.Bussiness
{
    public class NVH_ShoppingCart
    {
        public List<NVHCartItem> Items { get; set; }
        public NVH_ShoppingCart() 
        {
        Items = new List<NVHCartItem>();
        }
        public void AddToCart(NVHCartItem item)
        {
            var existingItem = Items.FirstOrDefault(x => x.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.SoLuongMua += item.SoLuongMua;
            }
            else
            {
                Items.Add(item);
            }
        }
        public void RemoveCartItem(int id)
        {
            var itemToRemove = Items.FirstOrDefault(x => x.Id == id);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }
        public float GetTongThanhTien()
        {
            return Items.Sum(x => x.SoLuongMua * x.DonGiaMua);
        }
    }
}