using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BestGameEver
{
    public class ChannelA
    {
        static public void ChannelAYEAH()
        {
            Console.WriteLine("\n");
            Thread.Sleep(2500);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Console.WriteLine("");
            immersiveText("It's oddly quiet here");
            Console.WriteLine("");
            Thread.Sleep(1200);

            immersiveText("Where are you?");
            Console.WriteLine("");
            Thread.Sleep(1200);

            Console.WriteLine("Are you even in control of yourself?");
            Thread.Sleep(2000);
            immersiveText("In front of you stands a weird green man... with a weird letter branded on his head"); // introduction of a character, "the twelfth" is his name
            Console.WriteLine("");
            Thread.Sleep(2000);
            
            LSwitch(true);
            
            immersiveText("he... he took everything from me :)");
            Console.WriteLine();
            
            LSwitch(false);
            
            Thread.Sleep(2000);
            Console.WriteLine("You don't particularly have a good feeling about this");
            
            Thread.Sleep(1200);
            Console.WriteLine("You try move away... you can't, like you PHYSICALLY can't, your legs are locked in place by some invisible force");
            
            Thread.Sleep(3000);
            Console.WriteLine("You are entrapped, paralysed and unable to do anything.");
            Thread.Sleep(2000);

            LSwitch(true);
            
            immersiveText("\ni'm only the other guy, no one remembers me :)");
            Console.WriteLine("");
            Thread.Sleep(1200);

            immersiveText("i was before him ! i was first, i was THE twelfth, he was the thirteenth ! why am i not the important one ! he gets to do everything but i don't get to do anything ! :)");
            Console.WriteLine("");
            Thread.Sleep(1200);

            LSwitch(false);
            Console.WriteLine("He is quite obviously off his marbles, but you can't do anything except observe.");
            Thread.Sleep(1200);
            LSwitch(true);

            immersiveText("hello there, hi, do you notice me? you may be the first to notice me. please, do you see me? :D");
            Console.WriteLine("");
            Thread.Sleep(1000);
            LSwitch(false);
            Console.WriteLine("It seems he's talking to you...");
            Thread.Sleep(1000);
            LSwitch(true);
            immersiveText("you don't seem to be very talkative :(");
            immersiveText("\nyou don't look very talkative D:");
            immersiveText("\nyou don't happen to be very talkative :(");
            immersiveText("\nwhy don't you talk >:(");
            LSwitch(false);
            Thread.Sleep(2000);
            Console.WriteLine("He punches you in the face... for some absurd reason, completely knocking you out...");
            Console.WriteLine("\nYou feel like you're back in control...");
            Console.ReadKey();
            Console.WriteLine("Everything's black around you though; you're unconscious, but for some reason you KNOW that you are...");
            Console.ReadKey();
            Console.WriteLine("How strange. Are you stuck again? This time you may be stuck entirely...");
            Console.ReadKey();
            immersiveText("Forever... alone in your own mind, never to be conscious again...");
            Console.Write("\nENDING: he saw, he came, he conquered. the twelfth");
            LSwitch(true);
            Console.Write(" lives on... forever");
            LSwitch(false);
            Console.WriteLine("GAME CLOSING IN 8 SECONDS"); // the channels need to be bad, for the sake of metaphors ! TV is bad or something idk. power of friendship with jork and mork forever
            Thread.Sleep(8000);
            Environment.Exit(0);
        }
        static public void immersiveText(string stringy) // to make the text look nice
        {
            for (int i = 0; i < stringy.Length; i++)
            {
                Thread.Sleep(75);
                Console.Write(stringy[i]);
            }
        }
        static public void LSwitch(bool switcher) // switch colour to green
        {
            if (switcher == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (switcher == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
