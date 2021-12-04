using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Обьем куба V=a^3: " + Math.Pow(a, 3));
                Console.WriteLine("Площадь поверхности S=6*(a^2): " + Math.Pow(a, 2) * 6);
            }
            Console.ReadKey();
        }
    }
}
