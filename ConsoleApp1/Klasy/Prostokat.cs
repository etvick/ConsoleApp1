using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Prostokat : Ksztalt
    {
        public decimal A { get; set; }
        public decimal B { get; set; }

        public Prostokat(decimal a, decimal b)
        {
            A = a;
            B = b;

        }
        public override decimal ObliczObwod()
        {
            return 2 * (A + B);
        }

        public override decimal ObliczPole()
        {
            return A * B;
        }

        public override void Rysuj()
        {
            Console.WriteLine($"obiekt typu \"Prostokat\" o przyprostokatnych [A, B] : [{A},{B}]");
        }
    }
}
