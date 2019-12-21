using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.interfejs;

namespace ConsoleApp1.Klasy
{
    abstract class Ksztalt : IRysowalny
    {
        public abstract decimal ObliczObwod();

        public abstract decimal ObliczPole();

        public abstract void Rysuj();
    }
}