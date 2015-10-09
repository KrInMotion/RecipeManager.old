using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var model = new List<CategoryViewModel>
            {
                new CategoryViewModel {Id=1, CategoryName="Категория №1", RecipeCount=0 },
                new CategoryViewModel {Id=2, CategoryName="Категория №2", RecipeCount=10, DeleteClass="disabled" },
                new CategoryViewModel {Id=3, CategoryName="Категория №3", RecipeCount=4, DeleteClass="disabled" },
                new CategoryViewModel {Id=4, CategoryName="Категория №4", RecipeCount=6, DeleteClass="disabled" }
            };
            return View(model);
        }
    }
}