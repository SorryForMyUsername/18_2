using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2
{
    /// <summary>
    /// Класс "Адрес"
    /// </summary>
    internal class Address
    {
        /// <summary>
        /// Почтовый индекс
        /// </summary>
        public int index;

        /// <summary>
        /// Страна
        /// </summary>
        public string country;

        /// <summary>
        /// Город
        /// </summary>
        public string city;

        /// <summary>
        /// Улица
        /// </summary>
        public string street;

        /// <summary>
        /// Дом
        /// </summary>
        public int house;

        /// <summary>
        /// Квартира
        /// </summary>
        public int apartment;

        /// <summary>
        /// Метод, выводящий информацию о адресе на консоль
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Индекс: {index}\tСтрана: {country}\tГород: " +
                $"{city}\tУлица: {street}\tДом: {house}\tКвартира: {apartment}");
        }
    }
}
