﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_WEBAPI_Angular_Integration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
