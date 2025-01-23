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
            Address ttiipAddress = new Address();

            ttiipAddress.index = 3300;
            ttiipAddress.country = "Приднестровье";
            ttiipAddress.city = "Тирасполь";
            ttiipAddress.street = "Карла Либкнехта";
            ttiipAddress.house = 244;
            ttiipAddress.apartment = 4;

            ttiipAddress.Output();

            Console.ReadKey();
        }
    }
}
