using System.Web;
using System.Web.Mvc;

namespace CMS.MauNhaDep
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}