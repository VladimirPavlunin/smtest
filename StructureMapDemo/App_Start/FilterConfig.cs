using System.Web.Mvc;
using StructureMapDemo.Filters;

namespace StructureMapDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterWebApiFilters(System.Web.Http.Filters.HttpFilterCollection filters)
        {
            filters.Add(new ApiErrorFilterAttribute());
            filters.Add(new BeforeActionFilterAttribute());
        }
    }
}
