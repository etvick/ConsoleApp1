using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(decimal a) : base(a, a) { }

        public override void Rysuj()
        {
            Console.WriteLine($"obiekt typu \"Kwadrat\" o boku :{A}");
        }
    }
}
