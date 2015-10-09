using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование категории")]
        public string CategoryName { get; set; }
    }
}