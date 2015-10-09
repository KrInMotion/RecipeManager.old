using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование категории")]
        public string CategoryName { get; set; }
        [DisplayName("Кол-во рецептов")]
        public int RecipeCount { get; set; }
        public string DeleteClass { get; set; }
    }
}