using Microsoft.AspNetCore.Mvc;
using MovieAppMvc.Veriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppMvc.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="Index")
            {
                    ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            
            return View(KategoriVeri.Kategoris);
        }
    }
}
