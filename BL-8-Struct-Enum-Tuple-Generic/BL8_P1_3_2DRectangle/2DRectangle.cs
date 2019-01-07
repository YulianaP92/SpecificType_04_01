using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL8_P1_3_2DRectangle
{
    struct _2DRectangle
    {
        public int h;
        public int b;

        public struct Coordinate
        {
            private int h1;
            private int b1;

            public Coordinate(int h1, int b1)
            {
                this.h1 = h1;
                this.b1 = b1;
            }

            public override string ToString()
            {
                return $"h- {this.b1}, b- {this.h1}";
            }
        }
    }
}
