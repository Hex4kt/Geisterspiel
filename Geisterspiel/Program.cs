using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geisterspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geisterspiel");

            while (true)
            {
                FrageStellen();
                AntwortAufnehmen();
                Console.WriteLine("Nochmal spielen? y / n");
                if (Console.ReadLine() != "y")
                {
                    return;
                }
            }
        }

        static void FrageStellen()
        {
            Console.WriteLine("Hinter einer Tür verbirgt sich ein Geist.");
            Console.WriteLine("Welche Tür wählst du? 1, 2 oder 3?");
        }

        static void AntwortAufnehmen()
        {
            int Tür;
            int Punkte = 0;
            while (true)
            {
                var Antwort = Console.ReadLine();

                if (int.TryParse(Antwort, out Tür) && Tür == 1 | Tür == 2 | Tür == 3)
                {
                    Punkte++;
                    Random GeisterTür = new Random();
                    if (GeisterTür.Next(1, 4) == Tür)
                    {
                        Console.WriteLine("Good Game! Hier ist ein Geist!");
                        Console.WriteLine($"Deine Punkte: {Punkte}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Kein Geist gefunden!");
                        FrageStellen();
                    }
                }
                else
                {
                    Console.WriteLine("Wähle eine Tür ... 1, 2 oder 3!");
                }
            }
        }
    }
}
