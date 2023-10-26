using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BestGameEver
{

    public class Program
    {

        static public int hp = 20; // global variable for hp
        static public int rngMeter; // global variable that changes the range of rng
        static public int rngOutput; // global variable to share the chance to main etc
        static public bool mOrF;

        static public void Main(string[] args)
        {

            testingClass.theTesting(); // in case i need to test any code, just put it here


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
            ConsoleKeyInfo inp;
            inp = Console.ReadKey();
            if (inp.Key == ConsoleKey.Y)
            {
                // bool keyp = false;
                // stack overflow did not help, i wanted to make a funny little bit where it basically was just like "hey, you know you can click a button" if an input hadn't been detected but i'm too dumb for that
                morkT = true;
                CSwitch(morkT);
                Console.WriteLine("\nWelcome... welcome to the most fun you'll have in the past and next 5 minutes");
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
            else if (inp.Key == ConsoleKey.N)
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

            Console.WriteLine("What are you to do?:\n[A] Click on the new channel\n[B] Turn off the TV and continue sleeping"); // first choice, easy one good one bad lol
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
                        Console.WriteLine("ENDING: boring ending, play again.");
                        Console.WriteLine("\nGAME CLOSING IN 8 SECONDS");
                        Thread.Sleep(8000);
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
            // simple 1 or 0 if you are male or female. M = 1, F = 0
            // annotation remains here, i've turned it into a global variable because i know how to implement it now.
            // this is like purely for the sake of immersion. wait no i just figured out how to properly implement it.
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
            
            Console.WriteLine("You go deeper and deeper until your arm is submerged within it; you only feel a weird tingle as you continuously have your arm willingly eaten by the TV...");
            Console.ReadKey();


            Console.WriteLine("\nIT'S DIE ROLL TIME!!");
            Thread.Sleep(1000);

            Console.WriteLine("I'm not going to tell you what it's for :)");

            Thread.Sleep(1900);
            Console.WriteLine("You brought this upon yourself by going into that DARN TV.");
            
            morkT = false;
            CSwitch(morkT);

            Console.WriteLine("");
            Console.WriteLine(@"
 PRESS ANY KEY... to meet your fate.

        OR for better life...

 ► ► ► ► ► ► ► ► ► ► ► ► ► ► ► ► ► ►
");
            Console.ReadKey(); // complete rng that can change your everything LOL
            rngMeter = 2;
            RNG();
            if (rngOutput <= 10)
            {
                Console.WriteLine("You fall into the TV...");
                Console.Title = "A new realm...";
            }
            else if (rngOutput > 10)
            {
                AltUniverse.AltUni(); // this is one of the paths of the game.
            }
            Console.ReadKey();
            Console.Title = "The TV World";
            Console.WriteLine("Around you is a variety of pathways... like channels. Who knows what's in them...");
            Console.ReadKey();
            Console.WriteLine("The environment is awfully yellow...");
            Console.ReadKey();
            Console.WriteLine("In front of you is...");
            Console.ReadKey();
            Console.WriteLine("\n" + @"          ____  
        o8%8888,    
      o88%8888888.  
     8'-    -:8888b   
    8'         8888  
   d8.-=. ,==-.:888b  
   >8 `~` :`~' d8888   
   88         ,88888   
   88b. `-~  ':88888  
   888b ~==~ .:88888 
   88888o--:':::8888      
   `88888| :::' 8888b  
   8888^^'       8888b  
  d888           ,%888b.   
 d88%            %%%8--'-.  
/88:.__ ,       _%-' ---  -  
    '''::===..-'   =  --.");
            Thread.Sleep(3000);
            
            CSwitch(true);
            Console.WriteLine("Who do you think this is?...");
            Console.ReadKey();
            Console.WriteLine("This fine... handsome young man...");
            Console.ReadKey();
            CSwitch(false);

            Console.WriteLine("\n" + @"\n
 ┌──────────────────────────────────────────────────────────────────────────────┐
 │ Dialogue Options:                                                            │
 │[A] You don't look that much like a man... maybe like a world-famous painting?│
 │[B] I don't know I just got here!                                             │
 │[C] I don't care                                                              │
 └──────────────────────────────────────────────────────────────────────────────┘
");
            ConsoleKeyInfo monaLisaChoice;
            bool acquiredTaste = false; // just if you like compliment Mork you know
            // i could do robust design but the funniest is always to give an alternate route if you say something else
            monaLisaChoice = Console.ReadKey();

            switch (monaLisaChoice.Key)
            {
                case ConsoleKey.A:
                    acquiredTaste = true;
                    CSwitch(true);
                    Console.WriteLine("\nYESSSSS I'm glad you know what I'm based off... the most beautiful painting out there!...");
                    Console.ReadKey();
                    Console.Write("My creator wanted me to be his best creation... unlike my brother - who you may meet in another universe ");
                    CSwitch(false);
                    Console.Write("(literally)");
                    CSwitch(true);
                    Console.Write(" - that was created as a complete mistake by my creator...");
                    Console.ReadKey();
                    Console.WriteLine("Anyway... that's enough about me, I should probably show you around...");
                    break;
                case ConsoleKey.B:
                    CSwitch(true);
                    Console.WriteLine("Fair point... well... who do you think's been talking to you this entire time?");
                    Console.ReadKey();
                    Console.WriteLine("...Speechless? It's been the legendary Mork himself that's who...");
                    Console.ReadKey();
                    Console.Write("Still not saying anything?... Wow, I guess I just have that effect on ");
                    if (mOrF == true)
                    {
                        Console.Write("men...");
                    }
                    else if (mOrF == false)
                    {
                        Console.Write("women...");
                    }
                    Console.ReadKey();
                    Console.WriteLine("Anyway... if you understand English, I'll show you around...");
                    break;
                case ConsoleKey.C:
                    CSwitch(true);
                    Console.Title = "You've got a bit of an attitude.";
                    Console.WriteLine("\nYou can just leave if you want you know what I hate you can you leave?...");
                    Console.ReadKey();
                    Console.WriteLine("You really are a quiet one... you know what, I can't stand the sight of you and your attitude, I'm kicking you out");
                    Thread.Sleep(2000);
                    CSwitch(false);
                    Console.WriteLine(@"
 ┌────────┐         ┌────────┐
 │        │         │        │
 │        │         │        │
 │        │         │        │
 │        │ ┌─────┐ │        │
 │        ├─┤     ├─┤        │
 │ BANNNN ├─┤     ├─┤ HAMMER │
 │        │ │     │ │        │
 │        │ │     │ │        │
 │        │ │     │ │        │
 │        │ │     │ │        │
 └────────┘ │     │ └────────┘
            │     │
            │     │
            │     │
            │     │
            │     │
            │     │
            │     │
            └─────┘
");

                    Console.Title = "Well, adventure avoided";
                    Console.WriteLine("You've been banished... back to your home...");
                    Console.ReadKey();
                    Console.WriteLine("While you didn't really lose anything, you feel like you've lost everything anyway... it feels like you could've had a huge adventure...");
                    Console.ReadKey();
                    Console.WriteLine("Well... well done then... you've annoyed some random guy and now you've missed out on a GREAT adventure");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nENDING: Annoyed sentient ethereal being; asked to leave."); // rude ending
                    Console.WriteLine("GAME CLOSING IN 8 SECONDS...");
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                    break;
                default:
                    CSwitch(true);
                    Console.WriteLine("\nSpeechless huh?...");
                    Console.ReadKey();
                    Console.WriteLine("I guess I'm just that awesome in a human's eyes...");
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("Well... there's not much around here, but you can choose which channel you'd like to visit...");
            Console.ReadKey();
            Console.WriteLine("It's been a while since I've been through 'em, so I can't truly explain what's on each side...");
            ConsoleKeyInfo channelEnter;
            CSwitch(false);
            Console.WriteLine(@"
 ┌────────────────────────────────────┐
 │                                    │
 │ WHERE TO?                          │
 │                                    │
 │ [A] CHANNEL 1                      │
 │ [B] CHANNEL 2                      │
 │ [ANY] I'm not very bothered lol... │
 │                                    │
 │                                    │
 └────────────────────────────────────┘
");

            channelEnter = Console.ReadKey();
            switch (channelEnter.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("\nYou go towards the door of the first channel; you say bye to Mork...");
                    ChannelA.ChannelAYEAH();
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("\nYou go towards the door of the second channel; you say bye to Mork...");
                    ChannelB.ChannelBYEAH();
                    break;
                default:
                    Console.Title = "Tea Time";
                    CSwitch(true);
                    Console.WriteLine("\nWell... that being said...");
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("Come sit with me, we can have some tea, I love tea...");
            Console.ReadKey();
            Console.WriteLine("You know, you can leave and come back any time, there's a door literally right behind us...");
            Console.ReadKey();
            CSwitch(false);
            Console.WriteLine(@"'Huh... that must be new, I've never seen that door before' - you think to yourself...");
            CSwitch(true);
            Console.WriteLine("Well, I hope you like sugar, cause I'm adding loads of sugar to your tea...");
            Console.ReadKey();
            Console.WriteLine("(P.S you don't have a choice.)");
            CSwitch(false);
            Console.WriteLine("\nYou spend the rest of your days visiting Mork; you still don't understand how a painting is drinking tea or doing any of this... but you enjoy the peaceful life you now have and the friend you've made...");
            Console.ReadKey();
            Console.WriteLine("Your drinking habits go away and things are really looking up... you still don't know whether this is real so thank god you don't have any friends to talk about this to...");
            Console.ReadKey();
            Console.WriteLine("ENDING: Peace and tranquility...");
            Console.WriteLine("GAME CLOSING IN 8 SECONDS.");
            Thread.Sleep(8000);
            Environment.Exit(0);



            Console.ReadKey(); // wait to quit readkey.
            // now that i'm a bit later in development from the point i wrote the line of code on top of this one i realised it's redundant, but i'm leaving it for the sake of character development
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
                string dR = "Dice Rolling..."; // dice rolling fx, this is 15 char, 14 index
                for (int i = 0; i < dR.Length; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(dR[i]);
                }
                Console.WriteLine("");
                Console.WriteLine(@"-----
|   |
|{0}|
|   |
-----",rngOutput);
            }
            else if (rngMeter == 3)
            {
                int num3 = rnggg.Next(1, 101); // the funny one, i probably won't use it.
                rngOutput = num3;
                Console.WriteLine(@"-----
|   |
|{0}|
|   |
-----", rngOutput);
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
