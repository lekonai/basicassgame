using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BestGameEver
{
    public class ChannelB
    {
        static public void ChannelBYEAH()
        {
            Console.Clear();
            Thread.Sleep(2000);
            Console.Title = "TRAPPED?";
            Thread.Sleep(4500);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(5000);
            fastImmersiveText("Hi There.");
            Thread.Sleep(1000);
            fastImmersiveText("Testing testing...");
            Console.ReadKey();
            Console.WriteLine("Welcome, hi, hello !...");
            Console.ReadKey();
            Console.WriteLine("So you decided to come down my door, I'm glad !! I love meeting new people...");
            Console.ReadKey();
            Console.WriteLine("There's not really much here....");
            Console.ReadKey();
            Console.WriteLine("When I mean there's not much here I mean I have no idea what you could do here...");
            Console.ReadKey();
            Console.WriteLine("Wanna play chess?");
            Console.WriteLine("\n[GAME TIP IN THIS DIMENSION: Because white text would be highly inconvenient, all game tips and thoughts will be written in square brackets]");
            Thread.Sleep(5000);
            Console.WriteLine(@"
 ┌─────────────────────────────────────────────────────┐
 │                                                     │
 │ What do you say? Do you accept or reject his offer? │
 │  [A] YES                                            │
 │  [B] NO                                             │
 │                                                     │
 └─────────────────────────────────────────────────────┘
");
            Console.ReadKey();
            Console.WriteLine("[Odd.. it seems that none of the options matter, for some reason you're compelled to... say something else]...");
            Console.ReadKey();
            Console.WriteLine("[The option is going to pop up again, maybe it'll work this time?]...");
            Console.ReadKey();
            Console.WriteLine(@"
 ┌─────────────────────────────────────────────────────┐
 │                                                     │
 │ What do you say? -- --- ------ -- reject his offer. │
 │  [A] NO                                             │
 │  [B] NO                                             │
 │                                                     │
 └─────────────────────────────────────────────────────┘
");
            Console.WriteLine("[[[[GAME REGISTERED AN INPUT THAT WOULD LEAD TO REJECTION]]]]");
            Console.ReadKey();
            Console.WriteLine("[It seems no matter what you input, you're bound to reject the thing's offer]...");
            Console.ReadKey();
            Console.WriteLine("[You have an incredibly bad feeling about this]...");
            Console.ReadKey();
            Console.WriteLine("Oh? You don't want to play chess?...");
            Console.ReadKey();
            Console.WriteLine("It's the only thing I wanted to do...");
            Console.ReadKey();
            fastImmersiveText("There's nothing much else to do...");
            Console.ReadKey();
            fastImmersiveText("... except kill you");
            Thread.Sleep(3000);
            Console.WriteLine("\n\n[It takes a few seconds to clock it, but you've just realised that it seems EVERYONE around is hostile for some absurd reason]...");
            Console.ReadKey();
            int persuasion = 0; // score for a quick quiz to try and persuade him for you to stay alive
            Console.WriteLine("[Guess this is what your mother meant by too much TV is bad for you :/]...");
            Console.ReadKey();
            Console.WriteLine("Hmm... I could, but first, let me question you on a few things...");
            Console.ReadKey();
            Console.WriteLine("\n[Q1] If Magnus Karlsen is the greatest of all time, where would LoLTyler1 be in the worldwide FIDE rankings?\n1. GOAT\n2. INHUMAN\n3. stupid.");
            bool q1inpValid = false;
            bool q2inpValid = false;
            bool q3inpValid = false;
            ConsoleKeyInfo inputterQ1;
            ConsoleKeyInfo inputterQ2;
            ConsoleKeyInfo inputterQ3;
            while (q1inpValid == false)
            {
                Console.WriteLine("Enter a number for input:");
                inputterQ1 = Console.ReadKey();
                Console.WriteLine("");
                switch (inputterQ1.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Understood.");
                        q1inpValid = true;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("That's one way to put it I guess.");
                        q1inpValid = true;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("CORRECT! No one is equal to the greatest of all time Magnus Karlsen!");
                        persuasion++;
                        q1inpValid = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid input... TRY AGAIN!");
                        q1inpValid = false;
                        break;
                }
            }


            Console.WriteLine("\n[Q2?] This is not related to chess, my personality is chess and I'm unafraid to admit that, but essentially, if you have a girlfriend, hypothetically, well, actually... I can't say much nvm");
            Thread.Sleep(7500);
            Console.WriteLine("[Q2] What's your favourite flavour of ice cream out of the famous neapolitan combo?\n1. Chocolate\n2. Vanilla\n3. Strawberry");

            while (q2inpValid == false) // question 2
            {
                Console.WriteLine("Enter a number for input:");
                inputterQ2 = Console.ReadKey();
                Console.WriteLine("");
                switch (inputterQ2.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Basic to say the least...");
                        q2inpValid = true;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("LEGENDARY. CORRECT! There is no other correct answer I don't care about your opinion but this is the right one :)");
                        persuasion++;
                        q2inpValid = true;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("You are disgusting"); // matt i know what it looks like but i promise that i love strawberry ice cream
                        q2inpValid = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid input... TRY AGAIN!");
                        q2inpValid = false;
                        break;
                }
            }

            Console.WriteLine("\n[Q3] Ok this one's a bit more personal, but somehow right, I moved my pawn two forward and I was side by side with this other pawn but somehow my opponent's pawn managed to take my pawn LEGALLY? What does this mean?");
            Console.WriteLine("1. Google 'En Passant'\n2. I don't know, I don't play chess\n3. They were cheating.");

            while (q3inpValid == false) // q3
            {
                Console.WriteLine("Enter a number for input:"); // this one has two correct answers
                inputterQ3 = Console.ReadKey();
                Console.WriteLine("");
                switch (inputterQ3.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Okay then hang on.");
                        Thread.Sleep(2000);
                        Console.WriteLine("... Holy hell.");
                        persuasion++;
                        q3inpValid = true;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("What a loser... sorry did I say that out loud? Woops.");
                        q3inpValid = true;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("THAT'S WHAT I'M SAYING THEY MUST HAVE BEEN CHEATING!");
                        persuasion++;
                        q3inpValid = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid input... TRY AGAIN!");
                        q3inpValid = false;
                        break;
                }
            }
            if (persuasion == 3)
            {
                Console.WriteLine("Personally, I think you're a fun guy...");
                Console.ReadKey();
                Console.WriteLine("I've known you for like 4 seconds but it feels like we could've been such good friends, however knowing your little human self you'd starve to death here, which'd be sad :(...");
                Console.ReadKey();
                Console.WriteLine("I'll let you off now and send you back on your way.");
                
                fastImmersiveText("I'm going to miss you...           :)");
                Thread.Sleep(2000);
                Console.WriteLine("\n\n[They grab a wand from beneath their back and smack you across the head with it with the power of 1000 gods... ouch.");
                Thread.Sleep(4000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Title = "Back Home";
                Console.WriteLine("Hm, that was quite something....");
                Console.ReadKey();
                Console.WriteLine("Life goes back to normal; it seems like it was all real so you ponder the limitations of the human mind and you think to yourself...");
                Console.ReadKey();
                Console.Write("'Am I just in a drunken haze? Why was that so vivid... it couldn't have been...");
                fastImmersiveText("...just a dream'");
                Console.WriteLine("GAME ENDING: Peaceful, friendly ending. Life is back to normal. P.S You're still an alcohol addict and you yearn for this weird haze again.");
                Thread.Sleep(2000);
                Console.WriteLine("GAME CLOSING IN 8 SECONDS");
                Thread.Sleep(8000);
                Environment.Exit(0);
            }
            else if (persuasion > 0 && persuasion < 3) // i understand the second condition ehre isn't necessary but it's jsut to make sure everything worsk !
            {
                Console.WriteLine("I'll give props to the fact you tried...");
                Console.ReadKey();
                Console.WriteLine("Sadly, there's no way out of this weird red prison place, so I'm just going to kill you ! That's a great alternative to starving here :D");
            }
            else if (persuasion == 0)
            {
                Console.WriteLine("Wow. I'm genuinely in awe how you never had a single correct answer...");
                Console.ReadKey();
                Console.WriteLine("Yeah I'm just gonna send you to the other channel for the fun of it!...");
                Console.ReadKey();
                fastImmersiveText("And you can deal with my 'friend'");
                Thread.Sleep(2000);
                Console.WriteLine("[BEFORE you can even COMPREHEND what they have to say, they bring out a 1982 American-Produced Official Military-Issued 5.56mm M16A2 Capable of Burst Fire and shoots you in the head]...");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                ChannelA.ChannelAYEAH();
            }

        }

        static public void fastImmersiveText(string genericString)
        {
            for (int i = 0; i < genericString.Length; i++)
            {
                Thread.Sleep(50);
                Console.Write(genericString[i]);
            }
            Console.WriteLine(""); // used so then if i use this function multiple times it doesn't write it all on one line
        }
    }
}
