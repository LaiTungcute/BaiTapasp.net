using System.Web;
using System.Web.Mvc;

namespace LaiHoangTung_2020607981
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
