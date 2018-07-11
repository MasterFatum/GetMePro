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

        public IEnumerable<SelectListItem> ItemsArea = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Все районы"},
            new SelectListItem() {Text = @"ЖК Молодёжный"},
            new SelectListItem() {Text = @"Центральный район (ЦМР)"},
            new SelectListItem() {Text = @"Фестивальный район (ФМР)"},
            new SelectListItem() {Text = @"Комсомольский район (КМР)"},
            new SelectListItem() {Text = @"Пашковский район (ПМР)",},
            new SelectListItem() {Text = @"Юбилейный район (ЮМР)"},
            new SelectListItem() {Text = @"Лента (РИП)"},
            new SelectListItem() {Text = @"Черемушки (ЧМР)"},
            new SelectListItem() {Text = @"Гидростроителей (ГМР)"},
            new SelectListItem() {Text = @"Краевой клинической больницы (ККБ)"},
            new SelectListItem() {Text = @"Завода измерительных приборов (ЗИП)"},
            new SelectListItem() {Text = @"Им. Маршала Жукова (ЭНКА)"},
            new SelectListItem() {Text = @"Поселок Южный"},
            new SelectListItem() {Text = @"Поселок Северный",},
            new SelectListItem() {Text = @"ПГТ Витаминкомбинат"},
            new SelectListItem() {Text = @"СВХ Прогресс"}
        };

        public IEnumerable<SelectListItem> ItemsCategoryServise = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Все услуги"},
            new SelectListItem() {Text = @"Ремонт и строительство"},
            new SelectListItem() {Text = @"Услуги красоты"},
            new SelectListItem() {Text = @"Автомобильные услуги"},
            new SelectListItem() {Text = @"Прочие услуги"}
        };

        public IEnumerable<SelectListItem> ItemsCategoryWork = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Все сферы"},
            new SelectListItem() {Text = @"Газопроводные работы"},
            new SelectListItem() {Text = @"Кафельные работы"},
            new SelectListItem() {Text = @"Ремонтные работы"},
            new SelectListItem() {Text = @"Сантехнические работы"}
        };
    }
}