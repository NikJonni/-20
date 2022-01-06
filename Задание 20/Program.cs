using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = CircleLength;
            myDelegate(4);

            MyDelegate myDelegate1 = CircleSquare;
            myDelegate1(4);

            MyDelegate myDelegate2 = BallVolume;
            myDelegate2(4);
            Console.ReadKey();
        }

        static double CircleLength(double r)
        {
            double l = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности равна: {0:f2}", l);
            return l;
        }
        static double CircleSquare(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь окружности равна: {0:f2}", s);
            return s;
        }
        static double BallVolume(double r)
        {
            double v = 4 * Math.PI * Math.Pow(r, 3) / 3;
            Console.WriteLine("Объем шара равен: {0:f2}", v);
            return v;
        }
    }
}
