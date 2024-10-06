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

            FrageStellen();

            AntwortAufnehmen();

            Thread.Sleep(10000);
        }

        static void FrageStellen()
        {
            Console.WriteLine("Hinter einer Tür verbirgt sich ein Geist.");
            Console.WriteLine("Welche Tür wählst du? 1, 2 oder 3?");
        }

        static void AntwortAufnehmen()
        {
            int Tür;

            while (true)
            {
                var Antwort = Console.ReadLine();

                if (int.TryParse(Antwort, out Tür))
                {
                    if (Tür == 1 | Tür == 2 | Tür == 3)
                    {
                        Console.WriteLine("test");
                        return;
                    }
                }
            }
        
        }
    }
}
