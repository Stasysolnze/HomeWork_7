using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стороны первого треугольника: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стороны второго треугольника: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            CalcSquareGeron(ref x1,ref y1,ref z1);
            CalcSquareGeron(ref x2, ref y2, ref z2);
            Console.WriteLine();
            if (CalcSquareGeron(ref x1, ref y1, ref z1) > CalcSquareGeron(ref x2, ref y2, ref z2))
            {
                Console.WriteLine("S1>S2 {0}>{1} ", CalcSquareGeron(ref x1, ref y1, ref z1), CalcSquareGeron(ref x2, ref y2, ref z2));
            }
            else
            {
                Console.WriteLine("S2>S1 {0}>{1} ", CalcSquareGeron(ref x2, ref y2, ref z2), CalcSquareGeron(ref x1, ref y1, ref z1));
            }

            Console.WriteLine();
                Console.WriteLine("S1={0}, S2={1}", CalcSquareGeron(ref x1,ref y1, ref z1), CalcSquareGeron(ref x2, ref y2, ref z2));
            Console.WriteLine();
                Console.ReadKey();
            }
            static double CalcSquareGeron(ref int x, ref int y, ref int z)
            {
                double p = (x + y + z) / 2;
                double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                return S;
            }


        }
    }



