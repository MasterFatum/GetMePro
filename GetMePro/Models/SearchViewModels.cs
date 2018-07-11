using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetMePro.Models
{
    public class SearchViewModels
    {
        [Required(ErrorMessage = "Выберите район")]
        [Display(Name = "Район")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Выберите услуги")]
        [Display(Name = "Услуги")]
        public string CategoryServises { get; set; }

        [Required(ErrorMessage = "Выберите сферу деятельности")]
        [Display(Name = "Сфера деятельности")]
        public string CategoryWork { get; set; }

    }
}