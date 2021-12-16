using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double Deligate1(double v);
        delegate double Deligate2(double u);
        delegate double Deligate3(double w);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double r = Convert.ToDouble(Console.ReadLine());

            Deligate1 lenght = v => (2 * r * Math.PI);
            double result1 = lenght(r);
            Console.WriteLine($"Длина окружности: {result1:F2}");

            Deligate2 area = u => (r * r * Math.PI);
            double result2 = area(r);
            Console.WriteLine($"Площадь окружности: {result2:F2}");

            Deligate3 volume = w => (4/3 * Math.Pow(r,3) * Math.PI);
            double result3 = volume(r);
            Console.WriteLine($"Объем шара: {result3:F2}");

            Console.ReadKey();
        }

    }
}
