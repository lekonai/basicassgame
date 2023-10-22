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
            Console.WriteLine("\nFun Game Tip: this is a key input type input, so just press a button :D (please obey this command");
            bool cKeyPCorrect = false; // just easier for a while loop, big up robust design!
            ConsoleKeyInfo keyPOption;
            do
            {
                Console.WriteLine("Enter Any KEY!!!");
                keyPOption = Console.ReadKey();
                if (keyPOption.Key == ConsoleKey.A)
                {

                }
                else if (keyPOption.Key == ConsoleKey.B)
                {

                }
                else if (keyPOption.Key == ConsoleKey.C)
                {

                }
            } while (cKeyPCorrect = false);
            int jorkHP = 20;
            



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
                string dR = "Dice Rolling..."; 
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

                }
            }
        }
    }
}
