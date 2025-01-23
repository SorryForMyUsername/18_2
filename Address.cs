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
        public int index;

        public string country;

        public string city;

        public string street;

        public int house;

        public int apartment;

        public void Output()
        {
            Console.WriteLine($"Индекс: {index}\tСтрана: {country}\tГород: " +
                $"{city}\tУлица: {street}\tДом: {house}\tКвартира: {apartment}");
        }
    }
}
