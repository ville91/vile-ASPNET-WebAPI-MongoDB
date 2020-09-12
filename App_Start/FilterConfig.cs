using System.Web;
using System.Web.Mvc;

namespace Vile_ASPNET_WebAPI_MongoDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
