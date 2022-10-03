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
        static int enemiehitvalue;
        static int health;
        static int enemiekillvalue;
        static int killscoremultipler;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods stuff");
            health = 100;
            score = 0;
            enemiehitvalue = 25;
            enemiekillvalue = 50;
            killscoremultipler = 1;
           ShowHUD();
           
            
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("You just took damage from an enemie!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
            TakeDamage();
            ShowHUD();

            


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("You attacked the enemie!");
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
      
            Console.WriteLine("");
            Attack();
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("You just took damage from an enemie!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
            TakeDamage();
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("You just killed the enemie!");
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
            KillEnemie();
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
            Console.WriteLine("                Score Multiplier: " + killscoremultipler + "x");
            Console.ReadKey(true);
        }


        static void Killmultiply()
        {
            score = score * killscoremultipler;
        }

        static void TakeDamage()
        {
            health = health - 20;
        }


        static void Attack()
        {
            score = score + enemiehitvalue;
        }

        static void KillEnemie()
        {
            killscoremultipler = killscoremultipler + 1;

            score = score + (enemiekillvalue * killscoremultipler);
        }
    }
}
