using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03._2022Class.Models
{
    class Rectangular:Figure
    {
        private double _width;
        private double _length;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;

                }
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                {
                    _length = value;

                }
            }
        }
        public Rectangular(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public Rectangular()
        {
        }

        public override void CalcArea()
        {
            Console.WriteLine("RecArea=Width*Length"); 
        }
    }
}
