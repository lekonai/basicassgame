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



        static int hp; // global variable for hp
        static int rngMeter; // global variable that changes the range of rng
        static int rngOutput; // global variable to share the chance to main etc
        static private void Main(string[] args)
        {      
            Console.Write("hi there");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");

            Console.Write("\nare you ready?");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(2000);

            Console.WriteLine("\n\n(y/n)");
            string inp = Console.ReadLine();
            if (inp.ToLower() == "y")
            {
                // bool keyp = false;
                // stack overflow did not help, i wanted to make a funny little bit where it basically was just like "hey, you know you can click a button" if an input hadn't been detected but i'm too dumb for that
                
                Console.WriteLine("Welcome... welcome to the most fun you'll have in the past and next 5 minutes");
                Console.WriteLine("Please wait a second or two for everything to process...");

                Thread.Sleep(5000);
                Console.WriteLine("(just kidding, you can press any button to continue.)");

                Console.ReadKey();
                // keyp = true;
                Console.WriteLine("Remember, it's just a game, if it's frustrating, I'm not sorry...");
            }
            else if (inp.ToLower() == "n")
            {
                Console.WriteLine("well, that's respectable. have a good day.");
                Thread.Sleep(1000);
                Environment.Exit(0); // quits, funny
            }
            else
            {
                Console.WriteLine("odd input, okay... nice to know you.");
                Thread.Sleep(1000);
                Environment.Exit(0); // quits but this one is if you just don't listen
            }
            Console.ReadKey();

            Console.WriteLine("\nYou can call me Mork, but it's better if you don't refer to me at all...");

            Console.ReadKey();

            Console.WriteLine("Sorry are you expe- OH yes this is a game, okay let me just boot it up. Well.. okay, enjoy !");

            Thread.Sleep(2000);
            Console.WriteLine("PLEASE WAIT.");

            Console.ReadKey();
        }

        static private void RNG()
        {
            Random rnggg = new Random();

            if (rngMeter == 1)
            {
                int num1 = rnggg.Next(1, 7); // basic die roll
                rngOutput = num1;
            }
            else if (rngMeter == 2)
            {
                int num2 = rnggg.Next(1, 21); // like a dnd hit dc
                rngOutput = num2;
            }
            else if (rngMeter == 3)
            {
                int num3 = rnggg.Next(1, 101); // the funny one
                rngOutput = num3;
            }
        }

    }
}
