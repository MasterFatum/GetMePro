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
            new SelectListItem() {Text = @"Центральный район (ЦМР)"},
            new SelectListItem() {Text = @"Фестивальный район (ФМР)"},
            new SelectListItem() {Text = @"Комсомольский район (КМР)"},
            new SelectListItem() {Text = @"Пашковский район (ПМР)",},
            new SelectListItem() {Text = @"Юбилейный район (ЮМР)"},
            new SelectListItem() {Text = @"Радиоизмерительных приборов (РИП)"},
            new SelectListItem() {Text = @"Черемушки (ЧМР)"},
            new SelectListItem() {Text = @"Гидростроителей (ГМР)"},
            new SelectListItem() {Text = @"Краевой клинической больницы (ККБ)"},
            new SelectListItem() {Text = @"Завода измерительных приборов (ЗИП)"},
            new SelectListItem() {Text = @"Камвольно-суконный комбинат (КСК)"},
            new SelectListItem() {Text = @"Хлопчато-бумажный комбинат (ХБК)"},
            new SelectListItem() {Text = @"Им. Маршала Жукова (ЭНКА)"},
            new SelectListItem() {Text = @"Ремонтно-механический завод (РМЗ)"},
            new SelectListItem() {Text = @"Теплоэлектростанции (ТЭЦ)"},
            new SelectListItem() {Text = @"Микрохирургии глаза (МХГ)"},
            new SelectListItem() {Text = @"Славянский (СМР)"},
            new SelectListItem() {Text = @"Рубероидный завод"},
            new SelectListItem() {Text = @"Немецкая деревня"},
            new SelectListItem() {Text = @"Табачная фабрика"},
            new SelectListItem() {Text = @"Поселок Южный"},
            new SelectListItem() {Text = @"Поселок Северный",},
            new SelectListItem() {Text = @"ПГТ Витаминкомбинат"},
            new SelectListItem() {Text = @"СВХ Прогресс"}
        }; //Районы Краснодара



        public IEnumerable<SelectListItem> ItemsCategoryServise = new List<SelectListItem> 
        {
            new SelectListItem() {Text = @"Все сферы"},
            new SelectListItem() {Text = @"Автомобильная сфера"},
            new SelectListItem() {Text = @"Медицина"},
            new SelectListItem() {Text = @"Информационные технологии"},
            new SelectListItem() {Text = @"Ремонт и строительство"},
            new SelectListItem() {Text = @"Сфера красоты"},
            new SelectListItem() {Text = @"Юриспруденция"},
            new SelectListItem() {Text = @"Прочие сферы"}
        }; //Сферы деятельности 



        public IEnumerable<SelectListItem> ItemsCategoryBeauty = new List<SelectListItem> 
        {
            new SelectListItem() {Text = @"Косметолог"},
            new SelectListItem() {Text = @"Шугаринг"},
            new SelectListItem() {Text = @"Визажист"},
            new SelectListItem() {Text = @"Парикмахер"},
            new SelectListItem() {Text = @"Уход за волосами"},
            new SelectListItem() {Text = @"Уход за ногтями"},
            new SelectListItem() {Text = @"Татуаж"},
            new SelectListItem() {Text = @"Ужод за бровями"},
            new SelectListItem() {Text = @"Уход за ресницами"},
        }; //Красота

        public IEnumerable<SelectListItem> ItemsCategoryJurisprudence = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Нотариат"},
            new SelectListItem() {Text = @"Гражданское право"},
            new SelectListItem() {Text = @"Арбитражное право"},
            new SelectListItem() {Text = @"Семейное право"},
            new SelectListItem() {Text = @"Уголовное право"},
            new SelectListItem() {Text = @"Административное право"},
            new SelectListItem() {Text = @"Международное право"},
            new SelectListItem() {Text = @"Земельное право"},
            new SelectListItem() {Text = @"Налоговое право"},
            new SelectListItem() {Text = @"Сопровождение сделок с недвижимостью"},
            new SelectListItem() {Text = @"Экспертиза, оценка"},
            new SelectListItem() {Text = @"Миграция"},
            new SelectListItem() {Text = @"Приватизация"},
            new SelectListItem() {Text = @"Лицензирование"},
            new SelectListItem() {Text = @"Военный юрист"},
            new SelectListItem() {Text = @"Адвокатура"},
            new SelectListItem() {Text = @"Частный детектив"},
        }; //Юриспруденция

        public IEnumerable<SelectListItem> ItemsCategoryIt = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Программирование"},
            new SelectListItem() {Text = @"Системное администрирование"},
            new SelectListItem() {Text = @"Ремонт компьютеров и периферии"},
            new SelectListItem() {Text = @"Разработка сайтов и web-приложений"},
            new SelectListItem() {Text = @"Разработка мобильных приложений"},
            new SelectListItem() {Text = @"Разработка игр"},
            new SelectListItem() {Text = @"Информационная безопасность"},
            new SelectListItem() {Text = @"Сети и сетевое оборудование"},
            new SelectListItem() {Text = @"Сервис печати"},
            new SelectListItem() {Text = @"IT аудит"},
            new SelectListItem() {Text = @"Видеонаблюдение"},
            new SelectListItem() {Text = @"Телефония"},
            new SelectListItem() {Text = @"Продажа и настройка оборудования"},
            new SelectListItem() {Text = @"Обучение ПК"},
            new SelectListItem() {Text = @"Программное обеспечение"},
            new SelectListItem() {Text = @"Интернет"},
        }; //Информационные технологии

        public IEnumerable<SelectListItem> ItemsCategoryHealth = new List<SelectListItem> 
        {
            new SelectListItem() {Text = @"Педиатрия"},
            new SelectListItem() {Text = @"Массажист"},
            new SelectListItem() {Text = @"Стоматология"},
            new SelectListItem() {Text = @"Геникология"},
            new SelectListItem() {Text = @"Урология"},
            new SelectListItem() {Text = @"Хирургия"},
            new SelectListItem() {Text = @"Тренер по плаванию"},
        };//Медицина

        public IEnumerable<SelectListItem> ItemsCategoryAuto = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Работы по двигателю"},
            new SelectListItem() {Text = @"Работы по КПП"},
            new SelectListItem() {Text = @"Работы по АКПП"},
            new SelectListItem() {Text = @"Работы по ходовой части"},
            new SelectListItem() {Text = @"Работы по элекронным системам"},
            new SelectListItem() {Text = @"Лакокрасочные работы"},
        }; //Автомобили

        public IEnumerable<SelectListItem> ItemsCategoryBuildingAndRepairs = new List<SelectListItem>
        {
            new SelectListItem() {Text = @"Водопровод, сантехника, отопление"},
            new SelectListItem() {Text = @"Кафельная плитка"},
            new SelectListItem() {Text = @"Электричество"},
            new SelectListItem() {Text = @"Газопровод"},
            new SelectListItem() {Text = @"Двери и окна"},
            new SelectListItem() {Text = @"Бытовая техника"},
            new SelectListItem() {Text = @"Мебель"},
            new SelectListItem() {Text = @"Кафельная плитка"},
            new SelectListItem() {Text = @"Шпатлёвка, штукатурка"},
            new SelectListItem() {Text = @"Ламинат, линолиум, паркет"},
            new SelectListItem() {Text = @"Натяжные потолки"},
            new SelectListItem() {Text = @"Гипсокартон"},

        }; //Строительство и ремонт





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
        }; //Общее
    }
}