using System.Web;
using System.Web.Mvc;

namespace K22CNTT3_NguyenVanHuynh_Project2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
