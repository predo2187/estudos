﻿using System.Web;
using System.Web.Mvc;

namespace Biblioteca_Jogos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
