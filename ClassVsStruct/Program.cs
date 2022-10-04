using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Player p1 = new Player() { Health = 100, Armor = 100 };
            Player p2 = p1;


            Console.WriteLine("HP do P1: " + p1.Health + "Armor do P1: " + p1.Armor);
            Console.WriteLine("HP do P2: " + p2.Health + "Armor do P2: " + p2.Armor);

            p1.Armor = 11;
            p2.Armor = 66;

            Console.WriteLine("HP do P1: " + p1.Health + "Armor do P1: " + p1.Armor);
            Console.WriteLine("HP do P2: " + p2.Health + "Armor do P2: " + p2.Armor)
        }
    }
}
