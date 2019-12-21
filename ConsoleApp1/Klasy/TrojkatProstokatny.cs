using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class TrojkatProstokatny : Ksztalt
    {
        public decimal A { get; set; }
        public decimal B { get; set; }

        private decimal c;

        public TrojkatProstokatny(decimal a, decimal b)
        {
            A = a;
            B = b;
            c = (decimal)Math.Sqrt((double)(A * A + B * B));
        }
        public override decimal ObliczObwod()
        {
            return A + B + c;
        }

        public override decimal ObliczPole()
        {
            return (A * B) / 2;

        }

        public override void Rysuj()
        {
            Console.WriteLine($"obiekt typu \"TrojkatProstokatny\" o przyprostokatnych [A,B]:[{A},{B}]");
        }
    }
}
