using System.Web;
using System.Web.Mvc;

namespace CvSiteHt21_Grupp34
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
