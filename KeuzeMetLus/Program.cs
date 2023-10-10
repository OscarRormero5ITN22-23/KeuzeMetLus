using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuzeMetLus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vaste commentaren:
            

            // Velden 
            byte _keuze = 0;

            // Programma
            // Stap 1: Intro
            Console.WriteLine("Welkom in dit Programma \n" +
                "Je krijgt hier 3 keuze om uit te kiezen.");
            Console.WriteLine("\n\nDruk op een toets om verder te gaan.");
            Console.ReadKey();

            // Scherm leegmaken 
            Console.Clear();

            // Stap 2: toon menu + vraag keuze
            Console.WriteLine("Maak uw keuze uit onderstaand menu:");
            Console.WriteLine("\n   1) Keuze 1\n   2) Keuze 2\n   3) Keuze 3");
            Console.Write("\nUw keuze: ");
            _keuze = byte.Parse(Console.ReadLine());

            // Scherm leegmaken 
            Console.Clear();

            // Stap 3: 
            if (_keuze == 1)
            {
                // Als keuze 1
                Console.WriteLine("Je koos keuze 1.");
            }
            else if (_keuze == 2)
            {
                // Als keuze 2
                Console.WriteLine("Je koos keuze 2.");
            }
            else if (_keuze == 3)
            {
                // Als keuze 3
                Console.WriteLine("Je koos keuze 3.");
            }
            else
            {
                // Foutmelding
                Console.WriteLine("U heeft geen geldige keuze ingevoerd.");

            }



            // Blokkeer scherm
            Console.WriteLine("\n\nDruk op een toets om af te sluiten.");
            Console.ReadKey();

        }
    }
}
