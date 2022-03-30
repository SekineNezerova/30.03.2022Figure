using _30._03._2022Class.Models;
using System;

namespace _30._03._2022Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square();
            Rectangular rec = new Rectangular();
            int input = 0;
            while (input>=0 && input<3)
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        sqr.CalcArea();
                        break;
                    case 2:
                        rec.CalcArea();
                        break;
                    case 0:
                        Console.WriteLine("quit");
                        break;
                }
            }
        }
    }
}
