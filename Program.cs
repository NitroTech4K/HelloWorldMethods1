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
        static int enemieHitValue;
        static int health;
        static int enemieKillValue;
        static int killScoreMultipler;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods stuff");
            health = 100;
            score = 0;
            enemieHitValue = 25;
            enemieKillValue = 50;
            killScoreMultipler = 1;
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
            Console.WriteLine("                Score Multiplier: " + killScoreMultipler + "x (Next Kill)");
            Console.ReadKey(true);
        }

        static void TakeDamage()
        {
            health = health - 20;
        }


        static void Attack()
        {
            score = score + enemieHitValue;
        }

        static void KillEnemie()
        {
            score = score + (enemieKillValue * killScoreMultipler);

            killScoreMultipler = killScoreMultipler + 1;
        }
    }
}
