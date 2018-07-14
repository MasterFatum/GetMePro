using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetMePro.Models
{
    public class ListsDropDownModels
    {
        public IEnumerable<SelectListItem> ItemsArea = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Все районы"},
            new SelectListItem() {Text = @"ЖК Молодёжный"},
            new SelectListItem() {Text = @"Немецкая деревня"},
            new SelectListItem() {Text = @"Табачная фабрика"},
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
            new SelectListItem() {Text = @"Все сферы"},
            new SelectListItem() {Text = @"Информационные технологии"},
            new SelectListItem() {Text = @"Ремонт и строительство"},
            new SelectListItem() {Text = @"Сфера красоты"},
            new SelectListItem() {Text = @"Автомобильная сфера"},
            new SelectListItem() {Text = @"Прочие сферы"}
        };

        public IEnumerable<SelectListItem> ItemsCategoryWork = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Все услуги"},
            new SelectListItem() {Text = @"Программирование"},
            new SelectListItem() {Text = @"Системное администрирование"},
            new SelectListItem() {Text = @"Газопроводные работы"},
            new SelectListItem() {Text = @"Кафельные работы"},
            new SelectListItem() {Text = @"Ремонтные работы"},
            new SelectListItem() {Text = @"Услуги визажиста"},
            new SelectListItem() {Text = @"Наращевание ногтей"},
            new SelectListItem() {Text = @"Сантехнические работы"},
            new SelectListItem() {Text = @"Ремонт двигателя"},
            new SelectListItem() {Text = @"Лакокрасочные работы"},
        };
    }
}