using ConsoleApp1.interfejs;
using ConsoleApp1.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)

        {
            Prostokat p = new Prostokat(3, 6);
            Kwadrat k = new Kwadrat(4);
            TrojkatProstokatny t = new TrojkatProstokatny(2, 2);

            List<Ksztalt> lista = new List<Ksztalt>();
            lista.Add(p);
            lista.Add(k);
            lista.Add(t);
            Console.WriteLine("--------------------------");
            foreach (Ksztalt item in lista)
            {
                item.Rysuj();
                Console.WriteLine("obwód: " + item.ObliczObwod());
                Console.WriteLine("pole: " + item.ObliczPole());
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("--------------------------");
            Punkt pk = new Punkt(2, 5);
            List<IRysowalny> lista2 = new List<IRysowalny>();
            lista2.Add(pk);
            lista2.Add(p);
            lista2.Add(k);
            lista2.Add(t);
            foreach (IRysowalny item in lista2)
            {
                item.Rysuj();
            }



        }
    }
}