using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.interfejs;

namespace ConsoleApp1.Klasy
{
    class Punkt : IRysowalny
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Rysuj()
        {
            Console.WriteLine($"obiekt typu \"Punkt\" o współrzędnych[X, Y] : [{X},{Y}]");
        }

    }
}
