using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Nathan_Peach
{
    internal class Program
    {
        //Variables must be static in order for them to be accessed by static methods
        //Variable declaration
        static int health = 100;
        static int gold = 0;
        static int turn = 0;
        static int potion = 1;
        //Variable declaration







        //Program always reads and executes "Main" first
        static void Main(string[] args)
        {
            //Calls the "Hud" method to print the Hud
            Hud();
            TakeDamage(25);
            Hud();

        }
        static void TakeDamage(int damage) 
        {
            health = health - damage;
        }
        static void Hud()
        {
            Console.WriteLine();
            Console.WriteLine("[]===================================================[]");
            Console.WriteLine("                      - TURN "+turn+" -                ");
            Console.WriteLine("[]===================================================[]");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("[]===================================================[]");
            Console.WriteLine("         | "+health+" HEALTH | "+gold+" GOLD | "+potion+" POTION |");
            Console.WriteLine("[]===================================================[]");
            turn = turn + 1;
            while (Console.ReadKey(true).key != ConsoleKey.Spacebar);
        }
    }
}