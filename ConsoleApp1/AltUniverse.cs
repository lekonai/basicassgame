using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BestGameEver
{
    public class AltUniverse // this one's just another universe entirely, it's one way down the game. I wonder how I'm gonna test this all lol, maybe I'll compile and send to my friends
    {
        static public int hp2 = Program.hp;
        static public int rngMeter2;
        static public int rngOutput2;
        static public bool failure;
        static public void AltUni()
        {
            Console.Title = "An Unfamiliar Blue...";
            
            string jorkArt = @"            ___          
            /   \\        
       /\\ | . . \\       
     ////\\|     ||       
   ////   \\ ___//\       
  ///      \\      \      
 ///       |\\      |     
//         | \\  \   \    
/          |  \\  \   \   
           |   \\ /   /   
           |    \/   /    
           |     \\/|     
           |      \\|     
           |       \\     
           |        |     
           |_________\    ";
            string heart = @"❤"; // for the romance ending.
            bool morkTAlt; // introduction of new character.
            morkTAlt = false;
            Program.CSwitch(morkTAlt);
            bool jorkTAlt = false;
            Console.WriteLine("\nNothing happens... your arm is stuck there...");
            Console.ReadKey();
            Console.WriteLine(@" │                                  │
 │ YOUR HP HAS BEEN REDUCED BY {1}  │
 │                                  │", Program.hp - 2);
            Thread.Sleep(1000);
            jorkTAlt = true;
            JCswitch(jorkTAlt);
            Console.WriteLine("\nYou're now on {0}HP loser...", hp2);
            Console.ReadKey();
            jorkTAlt = false;
            JCswitch(jorkTAlt);
            
            Console.WriteLine("You're in EXCRUCIATING pain as your arm is now released from the supernatural contraption...");
            Console.ReadKey();
            
            Console.WriteLine("And as you slowly drag your arm out, you see that it's literally just missing, the colours around your room start fading to a mellow chronic blue...");
            Console.ReadKey();

            Console.WriteLine("That being said... are you even in your room?...");
            Console.WriteLine(jorkArt);

            jorkTAlt = true;
            JCswitch(jorkTAlt);
            string funnyi = @"
 ┌───────────┐
 │!!!!!!!!!!!│
 └───!!!!!───┘
     │!!!│
     │!!!│
     │!!!│
     │!!!│
     │!!!│
     │!!!│
     │!!!│
     │!!!│
     │!!!│
 ┌───!!!!!───┐
 │!!!!!!!!!!!│
 └───────────┘
"; // for the comedic effect.
            Console.WriteLine("\nLook At ME!... Don't {0} look so cool in my new robes you stupid puny human...",funnyi);
            Console.ReadKey();
            jorkTAlt = false;
            JCswitch(jorkTAlt);
            Console.WriteLine(@"
 ┌─────────────────────────────────────────────────┐
 │                                                 │
 │ WHAT DO YOU THINK ABOUT HIS (LUXURIOUS) ROBES?  │
 │ [A] THEY'RE AWESOME, YOU'RE SO COOL.            │
 │ [B] YOU SUCK YOU LOSER.                         │
 │ [C] YOU'RE PRETTY HANDSOME.                     │
 │                                                 │
 └─────────────────────────────────────────────────┘
");
            Console.WriteLine("\nFun Game Tip: this is a key input, so just press a button :D (please obey this command sensibly.)");
            bool cKeyPCorrect = false; // just easier for a while loop, big up robust design!
            int jorkHP = 20;
            bool jorkDISPleased = false;
            ConsoleKeyInfo keyPOption;
            do
            {
                Console.WriteLine("Enter One Of Those Options!");
                keyPOption = Console.ReadKey();
                if (keyPOption.Key == ConsoleKey.A)
                {
                    // bool jorkPleased = true; // maybe will use, interested... nevermind, won't use because i can just use the displeased bool variable and put it on false
                    Console.WriteLine("HAHA !! I HAVE YOU IN AWE.");
                    cKeyPCorrect = true;
                }
                else if (keyPOption.Key == ConsoleKey.B)
                {
                    jorkTAlt = true;
                    JCswitch(jorkTAlt);
                    Console.WriteLine("WHAT??? Me and you will NEVER be friends...");
                    Console.ReadKey();
                    jorkTAlt = false;
                    JCswitch(jorkTAlt);
                    Console.WriteLine("Jork looks annoyed...");
                    Console.ReadKey();
                    jorkDISPleased = true;
                    cKeyPCorrect = true;
                }
                else if (keyPOption.Key == ConsoleKey.C)
                {
                    bool mOrF2 = Program.mOrF;
                    jorkTAlt = true;
                    JCswitch(jorkTAlt);
                    Console.WriteLine("HEHEHEHEHEH. I knew you'd think that... I think...");
                    Console.ReadKey();
                    Console.WriteLine("I'm... quite flattered. This isn't possible...");
                    Console.Title = "What's going on here?";
                    Console.ReadKey();
                    if (mOrF2 == false)
                    {
                        Console.WriteLine("WAIT, you're a GIRL, I'm NOT into GIRLS...");
                        Console.ReadKey();
                        Console.Title = "nvm";
                        Console.WriteLine("You remain a puny human in my eyes... forget what we could've had...");
                        Console.ReadKey();
                        cKeyPCorrect = true;
                    }
                    else
                    {
                        Console.Title = "Love?";
                        Console.WriteLine("You know... it gets a bit lonely in this dimension sometimes...");
                        Console.ReadKey();
                        string loveFound = "Do you see me in the same light that I see you ?"; // the set up for the first ending of the game 
                        Console.WriteLine("");
                        Console.ReadKey();
                        for (int j = 0; j < loveFound.Length; j++) // i should probably turn this into a method as I've used it like twice now and probably will use it more... but oh well
                        {
                            Thread.Sleep(90);
                            Console.Write(loveFound[j]);
                        }
                        Thread.Sleep(700);
                        Console.Write(".");
                        Thread.Sleep(700);
                        Console.Write(".");
                        Thread.Sleep(700);
                        Console.Write(".");
                        Console.ReadKey();
                        Console.WriteLine("");
                        jorkTAlt = false;
                        JCswitch(jorkTAlt);
                        Console.WriteLine(@"
 Y                Y      NN          N
  Y              Y       N N         N
   Y            Y        N  N        N
    Y          Y         N   N       N
     Y        Y          N    N      N
      Y      Y           N     N     N
        Y  Y             N      N    N
         YY              N       N   N
         YY     OOO RRR  N        N  N
         YY     O O R    N         N N
         YY     OOO R    N          NN ?
");
                        jorkTAlt = true;
                        JCswitch(jorkTAlt);
                        ConsoleKeyInfo loveAcceptance = Console.ReadKey();
                        if (loveAcceptance.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("I'm... glad you feel the same");
                            Console.ReadKey();
                            Console.WriteLine("With a puny human... heh heh heh...");
                            Console.ReadKey();
                            Console.WriteLine("ENDING OF THIS RUN: {0} V AND JORK FOREVER :D {0}",heart);
                            Console.WriteLine("\n\n\nGAME CLOSING IN 8 SECONDS...");
                            Thread.Sleep(8000);
                            Environment.Exit(0);
                        }
                        else if (loveAcceptance.Key == ConsoleKey.N)
                        {
                            Console.WriteLine("ok... i see how it is...");
                            jorkDISPleased = true; // this is what happens when you don't accept his love.
                            cKeyPCorrect = true;
                        }
                        
                    }
                }
                else
                {
                    cKeyPCorrect = false;
                }
            } while (cKeyPCorrect == false);
            Console.Title = "Jork's land!";
            jorkTAlt = true;
            JCswitch(jorkTAlt);



        }

        static public void JCswitch(bool jorkTalking)
        {
            // this one will be similar to the cswitch method, but for this universe, or something.
            if (jorkTalking == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (jorkTalking == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            // thanks copy and paste
        }

        static public void messedUpDie()
        {
            Random rng2 = new Random();
            Random rng3 = new Random();
            Random rng4 = new Random();
            int RANDOMISER = rng3.Next(1, 300);
            int FailRANDOMISER = rng4.Next(1, 21); // 1 in 20 chance to fail and it's COMPLETELY out your hands LOL
            if (rngMeter2 == 1)
            {
                int num2 = rng2.Next(1, 21); 
                rngOutput2 = num2 * RANDOMISER; // max output is 6000 LOL
                string dR = "Randomiser Dice Rolling..."; 
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
-----", rngOutput2);

            }
            // completely random bonkers type stuff that can just absolutely fail you but has a very small chance of doing so
            else if (rngMeter2 == 0) // funny :)
            {
                int failOutput;
                failOutput = FailRANDOMISER;
                Console.WriteLine("ULTIMATE FAIL DIE INITIATED.");
                if (failOutput > 1)
                {
                    Console.WriteLine("You DON'T FAIL this time. BE GLAD.");
                }
                else if (failOutput == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string failureSpeech = "You were destined to fail. From the moment you were born and now you die as a miserable sod; at this very point 'til forever... it'll be all you've ever known. A 1 in 20 chance and you fulfilled it... you stench of a smell unknown, one to be hidden forever..";
                    for (int i = 0; i < failureSpeech.Length; i++)
                    {
                        Thread.Sleep(50);
                        Console.Write(failureSpeech[i]);
                    }
                    Thread.Sleep(100);
                    Console.WriteLine("\nYou lost from an ultimate fail roll... embarrassing...");
                    Console.WriteLine("GAME EXITIING IN 8 SECONDS...");
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
