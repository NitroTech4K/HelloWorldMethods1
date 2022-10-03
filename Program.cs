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

        static void Main(string[] args)
        {
            Console.WriteLine("Methods stuff");

            Console.WriteLine("-------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------");
            
            score = 0;

            
            enemiekillvalue = 50;




            Console.WriteLine("Score: " + score);
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("");

            ShowHUD();

            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.WriteLine("Boi");
            Console.ReadKey(true);
        }
        
    }
}
