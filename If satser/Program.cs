using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satser
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Övning 1

            Console.WriteLine("Skriv in mönsterdjup");
            string inmatat = Console.ReadLine();
            double x = double.Parse(inmatat);

            if (x < 1.6)
            {
                Console.WriteLine("olagligt däck!");
            }
            else
            {
                Console.WriteLine("Lagligt däck!");
            }
            Console.ReadLine();

            //Övning 2

            Console.WriteLine("Mata in ålder:");
            string inmatat2 = Console.ReadLine();
            int x1 = int.Parse(inmatat2);

            if (x1 < 12)
            {
                Console.WriteLine("Vit");
            }
            else if (x1 < 18)
            {
                Console.WriteLine("grön");
            }
            else if (x1 < 25)
            {
                Console.WriteLine("röd");
            }
            else if (x1 < 99)
            {
                Console.WriteLine("blå");
            }
            else
            {
                Console.WriteLine("Ogiltig ålder");
            }

            //Övning 3

            Console.WriteLine("Mata in tal 1:");
            string inmatat3 = Console.ReadLine();
            Console.WriteLine("Mata in tal 2:");
            string inmatat4 = Console.ReadLine();
            int z = int.Parse(inmatat3);
            int a = int.Parse(inmatat4);

            if (z > a)
            {
                Console.WriteLine("Tal 1 var störst");
            }
            else if (z == a)
            {
                Console.WriteLine("Talen var lika!");
            }
            else
            {
                Console.WriteLine("Tal 2 var störst!");
            }

            Console.ReadKey();

            //Övning 4

            Console.WriteLine("Mata in ett heltal");
            string inmatat5 = Console.ReadLine();
            int tal = int.Parse(inmatat5);

            if (tal%7 != 0)
            {
                Console.WriteLine("Talet är jämt delbart med 7");
            }

            else
            {
                Console.WriteLine("Talet är ej jämt delbart med 7. Resten blir: " + (tal % 7));
            }
               
        }

    }
} 



