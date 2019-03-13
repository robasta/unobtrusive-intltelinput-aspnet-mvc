using System.Web;
using System.Web.Mvc;

namespace IntlTelInput_UnobtrusiveValidation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
