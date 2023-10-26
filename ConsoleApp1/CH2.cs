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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(5000);
            fastImmersiveText("Hi There.");
            Thread.Sleep(1000);
            fastImmersiveText("Testing testing...");


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
