﻿using System.Web;
using System.Web.Mvc;

namespace WebPastas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Agrego mi filtro
            filters.Add(new Filters.VerificaSession());
        }
    }
}
