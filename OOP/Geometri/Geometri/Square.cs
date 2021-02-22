using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private double Side { get; set; }

        public Square(double Side)
        {
            this.Side = Side;
        }

        public double Perimeter()
        {
            return 4 * Side;
        }

        public double Area()
        {
            return Side * Side;
        }
    }
}
