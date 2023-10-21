using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BestGameEver
{

    class Program
    {

        static public int hp = 20; // global variable for hp
        static public int rngMeter; // global variable that changes the range of rng
        static public int rngOutput; // global variable to share the chance to main etc
        
        
        static public void Main(string[] args)
        {
            Console.Title = "The best new six part Danish crime drama"; // console title part 1
            bool morkT = true;

            CSwitch(morkT);
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
            morkT = false;
            CSwitch(morkT);
            Console.WriteLine("\n\n(y/n)");
            string inp = Console.ReadLine();
            if (inp.ToLower() == "y")
            {
                // bool keyp = false;
                // stack overflow did not help, i wanted to make a funny little bit where it basically was just like "hey, you know you can click a button" if an input hadn't been detected but i'm too dumb for that
                morkT = true;
                CSwitch(morkT);
                Console.WriteLine("Welcome... welcome to the most fun you'll have in the past and next 5 minutes");
                morkT = false;
                CSwitch(morkT);
                Console.WriteLine("Please wait a second or two for everything to process...");

                morkT = true;
                CSwitch(morkT);
                Thread.Sleep(5000);
                Console.WriteLine("(just kidding, you can press any button to continue.)");

                morkT = false;
                CSwitch(morkT);
                Console.ReadKey();
                // keyp = true;
                Console.WriteLine("Remember, it's just a game, don't get frustrated by the gambling-like odds...");
            }
            else if (inp.ToLower() == "n")
            {
                morkT = true;
                CSwitch(morkT);
                Console.WriteLine("well, that's respectable. have a good day.");
                Thread.Sleep(1000);
                Environment.Exit(0); // quits, funny
            }
            else
            {
                morkT = true;
                CSwitch(morkT);
                Console.WriteLine("odd input, okay... nice to know you.");
                Thread.Sleep(1000);
                Environment.Exit(0); // quits but this one is if you just don't listen
            }
            Console.ReadKey();

            morkT = true;
            CSwitch(morkT);
            Console.WriteLine("\nYou can call me Mork, every time there's this red text you'll know it's me :)...");

            Console.ReadKey();

            Console.WriteLine("\nSorry are you expe- OH yes this is a game, okay let me just boot it up. Well.. okay, enjoy !");

            Thread.Sleep(1000);
            morkT = false;
            CSwitch(morkT);
            Console.WriteLine("\nPLEASE WAIT.");
            Thread.Sleep(3000);
            Console.Title = "Rays of electrical light"; // console title changes for mood
            string wakeUp = @" _______________
|,----------.  |\
||           |=| |
||          || | |
||       . _o| | | __
|`-----------' |/ /~/
 ~~~~~~~~~~~~~~~ / /
                 ~~"; //first introduction and ascii art
            Console.WriteLine(wakeUp);
            
            morkT = true;
            CSwitch(morkT);

            Console.WriteLine("\nYou wake up in front of the TV, your head still hurts from last night...");
            Console.ReadKey();

            Console.WriteLine("You struggle to comprehend anything, you struggle to comprehend why you would do what you did last night... wait, do you even remember?...");
            Console.ReadKey();

            Console.WriteLine("Not even your name matters to you at this point, everything's a swirly mess...");
            Console.ReadKey();

            Console.WriteLine("All you know is that there seems to be a new channel on your TV...");
            Console.ReadKey();

            morkT = false;
            CSwitch(morkT);

            Console.WriteLine("What are you to do?:\n[A] Click on the new channel\n[B] Turn off the TV and continue sleeping");
            bool choiceSelection = false;
            while (choiceSelection == false){
                string theChoice1 = Console.ReadLine().ToUpper();
                switch (theChoice1)
                {
                    case "A":
                        choiceSelection = true;
                        break;
                    case "B":
                        morkT = true;
                        CSwitch(morkT);
                        Console.WriteLine("You have a nice dream... and that's the end of your story");
                        Environment.Exit(0);
                        break;
                    default:
                        morkT = true;
                        CSwitch(morkT);
                        Console.WriteLine("Listen mate don't be silly please");
                        morkT = false;
                        CSwitch(morkT);
                        Console.WriteLine("Pick again, but sensibly !");
                        break;
                }
            }

            morkT = true;
            CSwitch(morkT);

            Console.WriteLine("\nIn all honesty that was the only correct choice! Well done!");
            Thread.Sleep(900);

            Console.WriteLine("You start remembering your NEW name, it's Vialio... oh? Oh wait, this just in, not a new name, you've known it for all 24 years of your life...");
            Console.ReadKey();

            Console.WriteLine("You'll be known as V to everyone wait I mean ok listen that was spoilers, just ignore that. I'll call you V from now on though...");
            Console.ReadKey();

            Console.WriteLine("Before we continue with our plot devices and whatnot, we're going to roll a die, and depending on it you'll be either a male or female...");
            Console.ReadKey();

            morkT = false;
            CSwitch(morkT);

            Console.WriteLine("Press any key to do the die roll !");
            rngMeter = 1;
            RNG();
            bool mOrF; // simple 1 or 0 if you are male or female. M = 1, F = 0
            if (rngOutput <= 3)
            {
                Console.WriteLine("\nYou rolled a: {0}, which means you're a male!", rngOutput);
                mOrF = true;
            }
            else if (rngOutput > 3)
            {
                Console.WriteLine("\nYou rolled a: {0}, which means you're a female!", rngOutput);
                mOrF = false;
            }
            Console.ReadKey();
            morkT = true;
            CSwitch(morkT);
            
            Console.WriteLine("\nThat's out the way now, let's go back to the TV...");
            Console.ReadKey();
            
            Console.WriteLine("As you lock onto the TV's LCD screen, your hand subconsciously grabs the remote and switches to the brand new TV channel...");
            Console.ReadKey();
            
            Console.WriteLine("Colours. That's all you see, they mesmerise your weak brain. You sit in awe at the TV screen...");
            Console.ReadKey();
            
            Console.WriteLine("Your hand releases off the remote and into the TV...");
            Console.ReadKey();
            
            Console.WriteLine("BWOAAAH Your mind is boggled, your hand is IN the TV??? HOW?? I don't know how that works I'm just Mork...");
            Console.ReadKey();
            
            Console.WriteLine("You go deeper and deeper until your arm is submerged within it; you only feel a weird tingle as you continuously have your arm willingly eaten by the TV");
            Console.ReadKey();


            Console.WriteLine("\nIT'S DIE ROLL TIME!!");
            Thread.Sleep(1000);
            Console.WriteLine("I'm not going to tell you what it's for :)");
            Thread.Sleep(1900);
            Console.WriteLine("You brought this upon yourself by going into that DARN TV.");
            
            morkT = false;
            CSwitch(morkT);

            Console.WriteLine(@"");
            Console.ReadKey();
            rngMeter = 2;
            RNG();
            if (rngOutput <= 10)
            {
                Console.WriteLine("")
            }



            Console.ReadKey(); // wait to quit readkey.
        }

        static public void RNG()
        {
            Random rnggg = new Random();

            if (rngMeter == 1)
            {
                int num1 = rnggg.Next(1, 7); // basic die roll
                switch (num1)
                {
                    case 1:
                        Console.WriteLine(@"-----
|   |
| o |
|   |
-----");
                        break;
                    case 2:
                        Console.WriteLine(@"-----
|o  |
|   |
|  o|
-----");
                        break;
                    case 3:
                        Console.WriteLine(@"-----
|o  |
| o |
|  o|
-----");
                        break;
                    case 4:
                        Console.WriteLine(@"-----
|o o|
|   |
|o o|
-----");

                        break;
                    case 5:
                        Console.WriteLine(@"-----
|o o|
| o |
|o o|
-----");
                        break;
                    case 6:
                        Console.WriteLine(@"-----
|o o|
|o o|
|o o|
-----");
                        break;
                }

                rngOutput = num1;
            }
            else if (rngMeter == 2)
            {
                int num2 = rnggg.Next(1, 21); // like a dnd hit dc
                rngOutput = num2;
                Console.WriteLine(@"-----
|   |
|{0}|
|   |
-----",rngOutput);
            }
            else if (rngMeter == 3)
            {
                int num3 = rnggg.Next(1, 101); // the funny one
                rngOutput = num3;
            }
        }

        static public void CSwitch(bool MorkTalking) // switches colour for when Mork is talking
        {
            if (MorkTalking == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (MorkTalking == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
