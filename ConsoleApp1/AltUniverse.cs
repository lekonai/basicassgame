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
        static public bool firstTime;
        static public int jorkHP = 20;
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
            bool jorkDISPleased = false;
            ConsoleKeyInfo keyPOption;
            do
            {
                Console.WriteLine("Enter One Of Those Options!");
                keyPOption = Console.ReadKey();
                if (keyPOption.Key == ConsoleKey.A)
                {
                    // bool jorkPleased = true; // maybe will use, interested... nevermind, won't use because i can just use the displeased bool variable and put it on false
                    jorkTAlt = true;
                    JCswitch(jorkTAlt);
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
            Console.WriteLine("WELL WELL well. Hello there little one...");
            Console.ReadKey();
            jorkTAlt = false;
            JCswitch(jorkTAlt);
            Console.WriteLine("Jork is thinking...");
            Console.ReadKey();
            if (jorkDISPleased == true)
            {
                rngMeter2 = 0;
                Console.WriteLine("Do you ever know what it's like to always fail? to feel so insignificant in comparison to my brother?...");
                Console.ReadKey();
                morkTAlt = true;
                Program.CSwitch(morkTAlt);
                morkTAlt = false;
                immersiveText("Hi that'd be me I'm his-");
                jorkTAlt = true;
                JCswitch(jorkTAlt);
                Console.Write(" GO AWAY...");
                Console.ReadKey();
                Console.WriteLine("Would you like to experience what it's like to fail?...\n[Y/N]");
                Console.ReadKey();
                Console.WriteLine("JUST KIDDING! THIS IS NO OPTION, HERE WE GOOOOO!");
                messedUpDie();
                JCswitch(jorkTAlt);
                Console.ReadKey();
                Console.WriteLine("Hmph... you're lucky...");

            }
            else
            {
                Console.WriteLine("Jork seems to be nor pleased nor displeased...");
                Console.ReadKey();
                Console.WriteLine("You seem slightly threatened... but that's it, it's only slight...");
            }
            jorkTAlt = true;
            JCswitch(jorkTAlt);
            Console.ReadKey();
            Console.WriteLine("Now... what to do with YOU...");
            Console.ReadKey();
            jorkTAlt = false;
            JCswitch(jorkTAlt);
            Console.WriteLine(@"
 CHOOSE YOUR WEAPON.
 ┌─────────────────┐
 │    [A] SWORD    │
 │    [B] GUN      │
 └─────────────────┘
");
            int sworGunC; // simple int that decides what weapon
            // 0 for sword
            // 1 for gun
            // 2 for stick
            ConsoleKeyInfo weaponSelector;
            Console.WriteLine("\nSELECT A KEY."); 
            weaponSelector = Console.ReadKey(); // i'm not gonna do no robust design and instead purposefully give you a stick if you don't pick A or B
            if (weaponSelector.Key == ConsoleKey.A)
            {
                Console.WriteLine("Sword selected!");
                sworGunC = 0;
            }
            else if (weaponSelector.Key == ConsoleKey.B)
            {
                Console.WriteLine("Gun selected!");
                sworGunC = 1;
            }
            else
            {
                Console.WriteLine("Because you're annoying, you can get a stick.");
                sworGunC = 2;
            }
            jorkTAlt = true;
            JCswitch(jorkTAlt); // there's one thing i realised a while back and that's i could've just put true or false in jcswitch LOL, so i'm going to do that from now on.
            Thread.Sleep(1000);
            Console.WriteLine("\nFIGHT ME, SQUIRE, I DON'T WANT TO SEE YOUR PATHETIC FACE...");
            firstTime = true;
            JCswitch(false);
            Console.Title = "Blue Banishment";
            Console.WriteLine("You initiate the first attack...");
            Console.ReadKey();
            int jorkDecider;
            Random jorkDChance = new Random(); // this will dictate what jork does in this combat scenario.
            while (jorkHP > 0 && hp2 > 0)
            {
                jorkDecider = jorkDChance.Next(1, 3);
                Console.WriteLine("You go in for an attack...");
                attackCMD(sworGunC);
                Console.ReadKey();
                JCswitch(true);
                Console.WriteLine("My turn...");
                JCswitch(false);
                if (jorkDecider == 1 && jorkHP > 0) // attack
                {
                    jorkAttackCMD();
                    Console.ReadKey();
                }
                else if (jorkDecider == 2 && jorkHP > 0) // heal
                {
                    jorkHealCMD();
                    Console.ReadKey();
                }
            }
            if (jorkHP <= 0)
            {
                JCswitch(true);
                Console.WriteLine("Wow... it's true... I will forever be inferior to my brother...");
                Console.ReadKey();
                Console.WriteLine("You know, this battle, of all battles, I finally felt something in this one...");
                Console.ReadKey();
                Console.WriteLine("It was nice knowing you.");
                Console.Title = "Back To Reality...";
                JCswitch(false);
                Thread.Sleep(1000);
                Console.WriteLine(@"
        _.---,._,'
       /' _.--.<
         /'     `'
       /' _.---._____
       \.'   ___, .-'`
           /'    \\             .
         /'       `-.          -|-
        |                       |
        |                   .-'~~~`-.
        |                 .'         `.
        |                 |  R  I  P  |
        |                 |  J O R K  |
        |                 |           |
         \              \\|           |//
   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("\nAnd that wraps up the story of Jork...");
                Console.ReadKey();
                Console.WriteLine("Everything around you returns to normal...");
                Console.ReadKey();
                Console.WriteLine("Even your arm... that's back too. Your head feels better too... that's odd, was any of this of reality?");
                Thread.Sleep(1200);
                immersiveText("Could this all have been a dream...      ?");
                Thread.Sleep(2000);
                Console.WriteLine("No, that'd be an embarrassingly bad ending, let's just write it off as a big unknown, make this ending whatever you want it to be.");
                Console.WriteLine("\nGAME CLOSING IN 8 SECONDS...");
                Thread.Sleep(8000);
                Environment.Exit(0);
            }
            else if (hp2 <= 0)
            {
                JCswitch(true);
                Console.WriteLine("\nI expected more fight in you... pathetic");
                Console.ReadKey();
                Console.WriteLine("Live a good life, gone from this realm.");
                JCswitch(false);
                if (sworGunC == 2)
                {
                    Console.WriteLine("EPIC GAME TIP: DON'T USE STICK NEXT TIME...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Good luck on your next run...");
                    Console.ReadKey();
                }
                Console.WriteLine("GAME CLOSING IN 8 SECONDS.... LOSER.");
                Thread.Sleep(8000);
                Environment.Exit(0);
            }



            Console.ReadKey();
        }

        static public void attackCMD(int sworGun)
        {
            Random gunRNGC = new Random();
            Random gunRNGdmg = new Random();
            Random swordRNGC = new Random();
            Random swordRNGdmg = new Random();
            Random stickRNGC = new Random();
            Random stickRNGdmg = new Random();
            // gives a 70 % chance to hit, gun does substantially more damage
            if (sworGun == 0)
            {
                int gunLuck = gunRNGC.Next(1, 11);
                int gunDMG = gunRNGdmg.Next(7, 13);
                if (gunLuck <= 3)
                {
                    Console.WriteLine("You miss spectacularly!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
                }
                else if (gunLuck > 3)
                {
                    Console.WriteLine("You hit! Dealing {0} damage", gunDMG);
                    jorkHP -= gunDMG;
                    Thread.Sleep(1000);
                    Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
                }
            }
            else if (sworGun == 1) // tbf, i could have a singular luck random and change the conditionals, but i'd rather have separate luck stats
            {
                int swordLuck = swordRNGC.Next(1, 7);
                int swordDMG = swordRNGdmg.Next(3, 10);
                if (swordLuck >= 2)
                {
                    Console.WriteLine("YOU HIT! DOING {0} DAMAGE!", swordDMG);
                    jorkHP -= swordDMG;
                    Thread.Sleep(1000);
                }
                else if (swordLuck == 1)
                {
                    Console.WriteLine("You missed... horrifically.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
                }

            }
            else if (sworGun == 2)
            {
                int stickLuck = stickRNGC.Next(1, 5);
                int stickDMG = stickRNGdmg.Next(1, 3);
                if (stickLuck == 1)
                {
                    Console.WriteLine("You hit! Dealing {0} DMG");
                    jorkHP -= stickDMG;
                    Thread.Sleep(1000);
                    Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
                }
                else if (stickLuck > 1)
                {
                    Console.WriteLine("you FAILED!");
                    rngMeter2 = 0;
                    if (firstTime == true)
                    {
                        Console.WriteLine("Oh.. by the way, this is your first time so you don't know about this... but essentially, every time you miss with the stick the failure die gets rolled...");
                        immersiveText(".... you brought this upon yourself");
                        messedUpDie();
                        firstTime = false;
                    }
                    else if (firstTime == false)
                    {
                        Console.WriteLine("YOU MISSED! AND FAILED!");
                        messedUpDie();
                    }
                }

            }
        }
        static public void jorkAttackCMD()
        {
            // to copy and paste: Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
            Random rngHIT = new Random();
            Random rngDMG = new Random();
            int hitChances = rngHIT.Next(1, 5); // he has a 25% chance to fail
            if (hitChances == 1)
            {
                Console.WriteLine("Jork misses... he's visibly sad");
                Thread.Sleep(1000);
                Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
            }
            else if (hitChances > 1)
            {
                int hitDMG = rngDMG.Next(1, 3);
                Console.WriteLine("Jork FLATTENS you with a whole {0} DAMAGE!", hitDMG);
                Thread.Sleep(1000);
                Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
            }

        }
        // i could pack the heal and attack method into one, but for the sake of comprehensibility and ease of use, i'll separate them
        static public void jorkHealCMD()
        {
            Random rngSPELL = new Random();
            Random rngHEAL = new Random();
            int spellChance = rngSPELL.Next(1,11);
            if (spellChance <= 5)
            {
                int selfHeal = rngHEAL.Next(1, 4);
                Console.WriteLine("Jork successfully heals himself with {0} HP!", selfHeal);
                jorkHP += selfHeal;
                Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);

            }
            else if (spellChance > 5)
            {
                int woopsHeal = rngHEAL.Next(4, 9);
                Console.WriteLine("Somehow... Jork healed YOU with {0} HP!", woopsHeal);
                JCswitch(true);
                Console.WriteLine("woops.");
                Thread.Sleep(1000);
                JCswitch(false);
                hp2 += woopsHeal;
                Console.WriteLine("Your health is: {0}, Jork's health is: {1}...", hp2, jorkHP);
            }
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You DON'T FAIL this time. BE GLAD.");
                    Console.ForegroundColor = ConsoleColor.White;
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
        static public void immersiveText(string stringy) // to make the text look nice
        {
            for (int i = 0; i < stringy.Length; i++)
            {
                Console.WriteLine(stringy[i]);
            }
        }
    }
}
