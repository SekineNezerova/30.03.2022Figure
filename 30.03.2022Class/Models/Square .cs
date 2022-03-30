using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03._2022Class.Models
{
    class Square:Figure
    {
        private double _side;
        public double Side {
            get { return _side; }
            set
            {
                if (value>0)
                {
                    _side = value; 

                }
            }

        }

        public override void CalcArea()
        {
            Console.WriteLine("SquareArea=Side*Side");
        }
        public Square(double side)
        {
            Side = side;

        }

        public Square()
        {
        }
    }
}
