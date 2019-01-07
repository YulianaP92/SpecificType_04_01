using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL8_P1_3_2DRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DRectangle rectangle;
            rectangle.h = 26;
            rectangle.b = 50;

            _2DRectangle.Coordinate coordinate = new _2DRectangle.Coordinate(30, 45);
            Console.WriteLine($"h - {rectangle.h}, b- {rectangle.b}");
            Console.WriteLine(coordinate);
            Console.ReadKey();
        }
    }
}
