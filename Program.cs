using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.index = 3300;
            address.country = "Приднестровье";
            address.city = "Тирасполь";
            address.street = "Карла Либкнехта";
            address.house = 244;
            address.apartment = 4;

            address.Output();

            Console.ReadKey();
        }
    }
}
