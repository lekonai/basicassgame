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
            immersiveText("It's oddly quiet here");
            Console.WriteLine("");
            Thread.Sleep(1200);

            immersiveText("Where are you?");
            Console.WriteLine("");
            Thread.Sleep(1200);

            Console.WriteLine("Are you even in control of yourself?");
            Thread.Sleep(2000);
            immersiveText("In front of you stands a weird green man... with a weird letter branded on his head"); // introduction of a character, "the twelfth is his name"
            Console.WriteLine("");
            Thread.Sleep(2000);
            
            LSwitch(true);
            
            immersiveText("he..he took everything from me :)");
            Console.WriteLine();
            
            LSwitch(false);
            
            Thread.Sleep(1200);
            Console.WriteLine("You don't particularly have a good feeling about this");
            
            Thread.Sleep(1200);
            Console.WriteLine("You try move away... you can't, like you PHYSICALLY can't, your legs are locked in place by some invisible force");
            
            Thread.Sleep(1200);
            Console.WriteLine("You are entrapped, immovable, stuck there");
            
            LSwitch(true);
            
            immersiveText("i'm only the other guy, no one remembers me :)");
            Console.WriteLine("");
            Thread.Sleep(1200);

            Console.WriteLine("")
        }
        static public void immersiveText(string stringy) // to make the text look nice
        {
            for (int i = 0; i < stringy.Length; i++)
            {
                Thread.Sleep(100);
                Console.Write(stringy[i]);
            }
        }
        static public void LSwitch(bool switcher)
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
