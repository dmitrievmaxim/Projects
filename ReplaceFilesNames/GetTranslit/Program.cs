using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTranslit
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "Привет Мир";
            Console.WriteLine(Translit.GetTranslat(test));
            Console.ReadLine();
        }
    }
}
