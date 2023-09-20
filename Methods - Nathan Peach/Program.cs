using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Nathan_Peach
{
    internal class Program
    {
        //Variable declaration
        static int health = 100;
        static int gold = 0;
        static int turn = 0;
        static int potion = 1;
        //Variable declaration

        //Variables must be static in order for them to be accessed by static methods
        //Methods are written in light yellow
        //Program always reads and executes "Main" first
        static void Main(string[] args)
        {
            //Calls the "Hud" method to print the Hud
            Hud();

            //I'd roll rng here to determine which event runs but I cant out how to get rng.Next to give a usable integer value
            EventLog();
            TakeDamage(25);
            
            Hud();

            EventLog();
            AddScore(50);

            Hud();
        }
        static void AddScore(int score)
        {
            gold = gold + score;
            Console.WriteLine(score + " GOLD OBTAINED");
        }       
        static void TakeDamage(int damage) 
        {
            health = health - damage;
            Console.WriteLine(damage + " DAMAGE TAKEN");
        }
        static void EventLog()
        {
            Console.WriteLine("");
            Console.WriteLine("---------   |");
            Console.WriteLine("EVENT LOG   |");
            Console.WriteLine("---------   V");
            Console.WriteLine("");
        }
        static void Hud()
        {
            Console.WriteLine();
            Console.WriteLine("[]===================================================[]");
            Console.WriteLine("                      - TURN " + turn + " -                ");
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
            Console.WriteLine("         | " + health + " HEALTH | " + gold + " GOLD | " + potion + " POTION |");
            Console.WriteLine("[]===================================================[]");
            Console.WriteLine("      -PRESS SPACEBAR TO ADVANCE TO NEXT TURN-");
            turn = turn + 1;
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
            {
            
            }
        }
    }
}