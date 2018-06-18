﻿using System.Collections.Generic;
using Rocket.DAL.Common.DbModels.ReleaseList;

namespace Rocket.DAL.Migrations.InitialDataCreators.User
{
    /// <summary>
    /// Формирует коллекцию стран,
    /// для заполнения ими соответствующего репозитация.
    /// </summary>
    public class DbCountriesCreator
    {
        /// <summary>
        /// Задает коллекцию стран.
        /// </summary>
        public List<DbCountry> Items { get; } = new List<DbCountry>()
        {
            new DbCountry() { Id = 1, Name = "Абхазия" },
            new DbCountry() { Id = 2, Name = "Австралия" },
            new DbCountry() { Id = 3, Name = "Австрия" },
            new DbCountry() { Id = 4, Name = "Азербайджан" },
            new DbCountry() { Id = 5, Name = "Албания" },
            new DbCountry() { Id = 6, Name = "Алжир" },
            new DbCountry() { Id = 7, Name = "Американское Самоа" },
            new DbCountry() { Id = 8, Name = "Ангилья" },
            new DbCountry() { Id = 9, Name = "Ангола" },
            new DbCountry() { Id = 10, Name = "Андорра" },
            new DbCountry() { Id = 11, Name = "Антарктида" },
            new DbCountry() { Id = 12, Name = "Антигуа и Барбуда" },
            new DbCountry() { Id = 13, Name = "Аргентина" },
            new DbCountry() { Id = 14, Name = "Армения" },
            new DbCountry() { Id = 15, Name = "Аруба" },
            new DbCountry() { Id = 16, Name = "Афганистан" },
            new DbCountry() { Id = 17, Name = "Багамы" },
            new DbCountry() { Id = 18, Name = "Бангладеш" },
            new DbCountry() { Id = 19, Name = "Барбадос" },
            new DbCountry() { Id = 20, Name = "Бахрейн" },
            new DbCountry() { Id = 21, Name = "Беларусь" },
            new DbCountry() { Id = 22, Name = "Белиз" },
            new DbCountry() { Id = 23, Name = "Бельгия" },
            new DbCountry() { Id = 24, Name = "Бенин" },
            new DbCountry() { Id = 25, Name = "Бермуды" },
            new DbCountry() { Id = 26, Name = "Болгария" },
            new DbCountry() { Id = 27, Name = "Боливия" },
            new DbCountry() { Id = 28, Name = "Бона., Саба и Синт." },
            new DbCountry() { Id = 29, Name = "Босния и Герцеговина" },
            new DbCountry() { Id = 30, Name = "Ботсвана" },
            new DbCountry() { Id = 31, Name = "Бразилия" },
            new DbCountry() { Id = 32, Name = "Брит.терр. в Инд.ок." },
            new DbCountry() { Id = 33, Name = "Бруней-Даруссалам" },
            new DbCountry() { Id = 34, Name = "Буркина-Фасо" },
            new DbCountry() { Id = 35, Name = "Бурунди" },
            new DbCountry() { Id = 36, Name = "Бутан" },
            new DbCountry() { Id = 37, Name = "Вануату" },
            new DbCountry() { Id = 38, Name = "Венгрия" },
            new DbCountry() { Id = 39, Name = "Венесуэла" },
            new DbCountry() { Id = 40, Name = "Вирг. остр., Брит." },
            new DbCountry() { Id = 41, Name = "Вирг. остр., США" },
            new DbCountry() { Id = 42, Name = "Вьетнам" },
            new DbCountry() { Id = 43, Name = "Габон" },
            new DbCountry() { Id = 44, Name = "Гайана" },
            new DbCountry() { Id = 45, Name = "Гаити" },
            new DbCountry() { Id = 46, Name = "Гамбия" },
            new DbCountry() { Id = 47, Name = "Гана" },
            new DbCountry() { Id = 48, Name = "Гваделупа" },
            new DbCountry() { Id = 49, Name = "Гватемала" },
            new DbCountry() { Id = 50, Name = "Гвинея" },
            new DbCountry() { Id = 51, Name = "Гвинея-Бисау" },
            new DbCountry() { Id = 52, Name = "Германия" },
            new DbCountry() { Id = 53, Name = "Гернси" },
            new DbCountry() { Id = 54, Name = "Гибралтар" },
            new DbCountry() { Id = 55, Name = "Гондурас" },
            new DbCountry() { Id = 56, Name = "Гонконг" },
            new DbCountry() { Id = 57, Name = "Гренада" },
            new DbCountry() { Id = 58, Name = "Гренландия" },
            new DbCountry() { Id = 59, Name = "Греция" },
            new DbCountry() { Id = 60, Name = "Грузия" },
            new DbCountry() { Id = 61, Name = "Гуам" },
            new DbCountry() { Id = 62, Name = "Дания" },
            new DbCountry() { Id = 63, Name = "Джерси" },
            new DbCountry() { Id = 64, Name = "Джибути" },
            new DbCountry() { Id = 65, Name = "Доминик.-кая Респ." },
            new DbCountry() { Id = 66, Name = "Доминика" },
            new DbCountry() { Id = 67, Name = "Египет" },
            new DbCountry() { Id = 68, Name = "Замбия" },
            new DbCountry() { Id = 69, Name = "Западная Сахара" },
            new DbCountry() { Id = 70, Name = "Зимбабве" },
            new DbCountry() { Id = 71, Name = "Йемен" },
            new DbCountry() { Id = 72, Name = "Израиль" },
            new DbCountry() { Id = 73, Name = "Индия" },
            new DbCountry() { Id = 74, Name = "Индонезия" },
            new DbCountry() { Id = 75, Name = "Иордания" },
            new DbCountry() { Id = 76, Name = "Ирак" },
            new DbCountry() { Id = 77, Name = "Иран, Исл. Респ." },
            new DbCountry() { Id = 78, Name = "Ирландия" },
            new DbCountry() { Id = 79, Name = "Исландия" },
            new DbCountry() { Id = 80, Name = "Испания" },
            new DbCountry() { Id = 81, Name = "Италия" },
            new DbCountry() { Id = 82, Name = "Кабо-Верде" },
            new DbCountry() { Id = 83, Name = "Казахстан" },
            new DbCountry() { Id = 84, Name = "Камбоджа" },
            new DbCountry() { Id = 85, Name = "Камерун" },
            new DbCountry() { Id = 86, Name = "Канада" },
            new DbCountry() { Id = 87, Name = "Катар" },
            new DbCountry() { Id = 88, Name = "Кения" },
            new DbCountry() { Id = 89, Name = "Кипр" },
            new DbCountry() { Id = 90, Name = "Киргизия" },
            new DbCountry() { Id = 91, Name = "Кирибати" },
            new DbCountry() { Id = 92, Name = "Китай" },
            new DbCountry() { Id = 93, Name = "Кокос. (Килинг) ост." },
            new DbCountry() { Id = 94, Name = "Колумбия" },
            new DbCountry() { Id = 95, Name = "Коморы" },
            new DbCountry() { Id = 96, Name = "Конго" },
            new DbCountry() { Id = 97, Name = "Конго, Дем. Респ." },
            new DbCountry() { Id = 98, Name = "Корея, КНР" },
            new DbCountry() { Id = 99, Name = "Корея, Республика" },
            new DbCountry() { Id = 100, Name = "Коста-Рика" },
            new DbCountry() { Id = 101, Name = "Кот д'Ивуар" },
            new DbCountry() { Id = 102, Name = "Куба" },
            new DbCountry() { Id = 103, Name = "Кувейт" },
            new DbCountry() { Id = 104, Name = "Кюрасао" },
            new DbCountry() { Id = 105, Name = "Лаос" },
            new DbCountry() { Id = 106, Name = "Латвия" },
            new DbCountry() { Id = 107, Name = "Лесото" },
            new DbCountry() { Id = 108, Name = "Либерия" },
            new DbCountry() { Id = 109, Name = "Лив. Араб. Джам." },
            new DbCountry() { Id = 110, Name = "Ливан" },
            new DbCountry() { Id = 111, Name = "Литва" },
            new DbCountry() { Id = 112, Name = "Лихтенштейн" },
            new DbCountry() { Id = 113, Name = "Люксембург" },
            new DbCountry() { Id = 114, Name = "Маврикий" },
            new DbCountry() { Id = 115, Name = "Мавритания" },
            new DbCountry() { Id = 116, Name = "Мадагаскар" },
            new DbCountry() { Id = 117, Name = "Майотта" },
            new DbCountry() { Id = 118, Name = "Макао" },
            new DbCountry() { Id = 119, Name = "Малави" },
            new DbCountry() { Id = 120, Name = "Малайзия" },
            new DbCountry() { Id = 121, Name = "Мали" },
            new DbCountry() { Id = 122, Name = "Малые Тих.от.остр.СШ" },
            new DbCountry() { Id = 123, Name = "Мальдивы" },
            new DbCountry() { Id = 124, Name = "Мальта" },
            new DbCountry() { Id = 125, Name = "Марокко" },
            new DbCountry() { Id = 126, Name = "Мартиника" },
            new DbCountry() { Id = 127, Name = "Маршалловы острова" },
            new DbCountry() { Id = 128, Name = "Мексика" },
            new DbCountry() { Id = 129, Name = "Микронезия, Фед.Шт." },
            new DbCountry() { Id = 130, Name = "Мозамбик" },
            new DbCountry() { Id = 131, Name = "Молдова, Республика" },
            new DbCountry() { Id = 132, Name = "Монако" },
            new DbCountry() { Id = 133, Name = "Монголия" },
            new DbCountry() { Id = 134, Name = "Монтсеррат" },
            new DbCountry() { Id = 135, Name = "Мьянма" },
            new DbCountry() { Id = 136, Name = "Намибия" },
            new DbCountry() { Id = 137, Name = "Науру" },
            new DbCountry() { Id = 138, Name = "Непал" },
            new DbCountry() { Id = 139, Name = "Нигер" },
            new DbCountry() { Id = 140, Name = "Нигерия" },
            new DbCountry() { Id = 141, Name = "Нидерланды" },
            new DbCountry() { Id = 142, Name = "Никарагуа" },
            new DbCountry() { Id = 143, Name = "Ниуэ" },
            new DbCountry() { Id = 144, Name = "Новая Зеландия" },
            new DbCountry() { Id = 145, Name = "Новая Каледония" },
            new DbCountry() { Id = 146, Name = "Норвегия" },
            new DbCountry() { Id = 147, Name = "ОАЭ" },
            new DbCountry() { Id = 148, Name = "Оман" },
            new DbCountry() { Id = 149, Name = "Ост. Теркс и Кайкос" },
            new DbCountry() { Id = 150, Name = "Ост.Херд и ост.Макд." },
            new DbCountry() { Id = 151, Name = "Остров Буве" },
            new DbCountry() { Id = 152, Name = "Остров Мэн" },
            new DbCountry() { Id = 153, Name = "Остров Норфолк" },
            new DbCountry() { Id = 154, Name = "Остров Рождества" },
            new DbCountry() { Id = 155, Name = "Острова Кайман" },
            new DbCountry() { Id = 156, Name = "Острова Кука" },
            new DbCountry() { Id = 157, Name = "Пакистан" },
            new DbCountry() { Id = 158, Name = "Палау" },
            new DbCountry() { Id = 159, Name = "Палестин.терр., окк." },
            new DbCountry() { Id = 160, Name = "Панама" },
            new DbCountry() { Id = 161, Name = "Пап.Пр.(Г.-гор Ват.)" },
            new DbCountry() { Id = 162, Name = "Папуа-Новая Гвинея" },
            new DbCountry() { Id = 163, Name = "Парагвай" },
            new DbCountry() { Id = 164, Name = "Перу" },
            new DbCountry() { Id = 165, Name = "Питкерн" },
            new DbCountry() { Id = 166, Name = "Польша" },
            new DbCountry() { Id = 167, Name = "Португалия" },
            new DbCountry() { Id = 168, Name = "Пуэрто-Рико" },
            new DbCountry() { Id = 169, Name = "Республика Македония" },
            new DbCountry() { Id = 170, Name = "Реюньон" },
            new DbCountry() { Id = 171, Name = "Россия" },
            new DbCountry() { Id = 172, Name = "Руанда" },
            new DbCountry() { Id = 173, Name = "Румыния" },
            new DbCountry() { Id = 174, Name = "Самоа" },
            new DbCountry() { Id = 175, Name = "Сан-Марино" },
            new DbCountry() { Id = 176, Name = "Сан-Томе и Принсипи" },
            new DbCountry() { Id = 177, Name = "Саудовская Аравия" },
            new DbCountry() { Id = 178, Name = "Свазиленд" },
            new DbCountry() { Id = 179, Name = "Сев. Марианские ост." },
            new DbCountry() { Id = 180, Name = "Сейшелы" },
            new DbCountry() { Id = 181, Name = "Сен-Бартельми" },
            new DbCountry() { Id = 182, Name = "Сенегал" },
            new DbCountry() { Id = 183, Name = "Сен-Мартен" },
            new DbCountry() { Id = 184, Name = "Сент-Вин. и Гренад." },
            new DbCountry() { Id = 185, Name = "Сент-Китс и Невис" },
            new DbCountry() { Id = 186, Name = "Сент-Люсия" },
            new DbCountry() { Id = 187, Name = "Сент-Пьер и Микелон" },
            new DbCountry() { Id = 188, Name = "Сербия" },
            new DbCountry() { Id = 189, Name = "Сингапур" },
            new DbCountry() { Id = 190, Name = "Синт-Мартен" },
            new DbCountry() { Id = 191, Name = "Сир. Араб. Респ." },
            new DbCountry() { Id = 192, Name = "Словакия" },
            new DbCountry() { Id = 193, Name = "Словения" },
            new DbCountry() { Id = 194, Name = "Соединенное Корол." },
            new DbCountry() { Id = 195, Name = "Соединенные Штаты" },
            new DbCountry() { Id = 196, Name = "Соломоновы острова" },
            new DbCountry() { Id = 197, Name = "Сомали" },
            new DbCountry() { Id = 198, Name = "Судан" },
            new DbCountry() { Id = 199, Name = "Суринам" },
            new DbCountry() { Id = 200, Name = "Сьерра-Леоне" },
            new DbCountry() { Id = 201, Name = "Таджикистан" },
            new DbCountry() { Id = 202, Name = "Тайвань (Китай)" },
            new DbCountry() { Id = 203, Name = "Таиланд" },
            new DbCountry() { Id = 204, Name = "Танзания, Об. Респ." },
            new DbCountry() { Id = 205, Name = "Тимор-Лесте" },
            new DbCountry() { Id = 206, Name = "Того" },
            new DbCountry() { Id = 207, Name = "Токелау" },
            new DbCountry() { Id = 208, Name = "Тонга" },
            new DbCountry() { Id = 209, Name = "Тринидад и Тобаго" },
            new DbCountry() { Id = 210, Name = "Тристан-да-Кунья" },
            new DbCountry() { Id = 211, Name = "Тувалу" },
            new DbCountry() { Id = 212, Name = "Тунис" },
            new DbCountry() { Id = 213, Name = "Туркмения" },
            new DbCountry() { Id = 214, Name = "Турция" },
            new DbCountry() { Id = 215, Name = "Уганда" },
            new DbCountry() { Id = 216, Name = "Узбекистан" },
            new DbCountry() { Id = 217, Name = "Украина" },
            new DbCountry() { Id = 218, Name = "Уоллис и Футуна" },
            new DbCountry() { Id = 219, Name = "Уругвай" },
            new DbCountry() { Id = 220, Name = "Фарерские острова" },
            new DbCountry() { Id = 221, Name = "Фиджи" },
            new DbCountry() { Id = 222, Name = "Филиппины" },
            new DbCountry() { Id = 223, Name = "Финляндия" },
            new DbCountry() { Id = 224, Name = "Фолкл. ост. (Мальв.)" },
            new DbCountry() { Id = 225, Name = "Франц. Полинезия" },
            new DbCountry() { Id = 226, Name = "Франц. Южные терр." },
            new DbCountry() { Id = 227, Name = "Франция" },
            new DbCountry() { Id = 228, Name = "Французская Гвиана" },
            new DbCountry() { Id = 229, Name = "Хорватия" },
            new DbCountry() { Id = 230, Name = "Центр.-Афр. Респ." },
            new DbCountry() { Id = 231, Name = "Чад" },
            new DbCountry() { Id = 232, Name = "Черногория" },
            new DbCountry() { Id = 233, Name = "Чешская Республика" },
            new DbCountry() { Id = 234, Name = "Чили" },
            new DbCountry() { Id = 235, Name = "Швейцария" },
            new DbCountry() { Id = 236, Name = "Швеция" },
            new DbCountry() { Id = 237, Name = "Шпиц. и Ян Майен" },
            new DbCountry() { Id = 238, Name = "Шри-Ланка" },
            new DbCountry() { Id = 239, Name = "Экв. Гвинея" },
            new DbCountry() { Id = 240, Name = "Эквадор" },
            new DbCountry() { Id = 241, Name = "Эландские острова" },
            new DbCountry() { Id = 242, Name = "Эль-Сальвадор" },
            new DbCountry() { Id = 243, Name = "Эритрея" },
            new DbCountry() { Id = 244, Name = "Эстония" },
            new DbCountry() { Id = 245, Name = "Эфиопия" },
            new DbCountry() { Id = 246, Name = "Ю.Джор. и Ю.Сан.ост." },
            new DbCountry() { Id = 247, Name = "Южная Африка" },
            new DbCountry() { Id = 248, Name = "Южная Осетия" },
            new DbCountry() { Id = 249, Name = "Южный Судан" },
            new DbCountry() { Id = 250, Name = "Ямайка" },
            new DbCountry() { Id = 251, Name = "Япония" }
        };
    }
}