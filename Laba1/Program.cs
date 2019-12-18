using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static int x;
        static int y;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Y");
            y = Convert.ToInt32(Console.ReadLine());

            int z = x + y;
            Console.WriteLine($"Сумма введенных значений равна: {z} ");

            Console.ReadKey();
        }
    }


}
