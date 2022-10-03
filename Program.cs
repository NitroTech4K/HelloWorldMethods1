using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldMethods1
{
    internal class Program
    {
        static int score;
        static int enemiekillvalue;
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods stuff");
            health = 100;
            score = 0;
            enemiekillvalue = 50;

           ShowHUD();

            Console.ReadKey(true);
           
            
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("You just took damage from an enemie!");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
            TakeDamage();
            ShowHUD();

            Console.ReadKey(true);

        }

        static void ShowHUD()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Here's your current stats");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Health: " + health + "     Score: " + score);
            Console.ReadKey(true);
        }
        
        static void TakeDamage()
        {
            health = health - 20;
        }


        static void Attack()
        {
            score = score + enemiekillvalue;
        }
    }
}
