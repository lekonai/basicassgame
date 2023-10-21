using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int hp;
        
        static private void Main(string[] args)
        {
            Console.Write("hi there.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");

            Console.Write("\nare you ready?.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(2000);

            Console.WriteLine("\n\n(y/n)");
            string inp = Console.ReadLine();
            if (inp.ToLower() == "y")
            {
                bool keyp = false;
                
                Console.WriteLine("Welcome... welcome to the most fun you'll have in the past and next 5 minutes");
                

                Thread.Sleep(5000);
                Console.WriteLine("(by the way, you can press any button to continue.)");
                

                Console.ReadKey();
                keyp = true;
                Console.WriteLine("(remember, it's just a game, if it's frustrating, I'm not sorry)");
            }
            else if (inp.ToLower() == "n")
            {
                Console.WriteLine("well, that's respectable. have a good day.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("odd input, okay... nice to know you.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.WriteLine("You can call me Mork, but it's better if you don't refer to me at all.");

            Console.ReadKey();
        }

        static private void RNG()
        {
            Random rnggg = new Random();

        }

    }
}
