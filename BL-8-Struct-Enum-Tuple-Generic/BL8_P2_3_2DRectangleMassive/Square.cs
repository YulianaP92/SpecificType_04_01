using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL8_P2_3_2DRectangleMassive
{
    struct Square
    {
        private int a;

        public Square(int a)
        {
            this.a = a;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !s1.Equals(s2);
        }
        public override string ToString()
        {
            return $"{this.a}";
        }
    }
}
