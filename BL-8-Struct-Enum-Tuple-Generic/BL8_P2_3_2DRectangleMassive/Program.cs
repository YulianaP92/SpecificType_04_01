using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL8_P2_3_2DRectangleMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas = new List<Square>(6);
            Random random = new Random();
            for (int i = 0; i < mas.Capacity; i++)
            {
                mas.Add(new Square(random.Next(10)));
                Console.Write(mas[i] + " ");
            }
            var distinctItems = mas.Distinct<Square>();
            foreach (var i in distinctItems)
            {
                Console.WriteLine("\nЧисло: {0} - встресается {1} раз(а)", i, DublicateElements(mas, i));
            }
            Console.ReadKey();
        }
        public static int DublicateElements(List<Square> mas, Square a)
        {
            int count = 0;

            foreach (var i in mas)
                if (i == a) count++;
            return count;
        }
    }
}
