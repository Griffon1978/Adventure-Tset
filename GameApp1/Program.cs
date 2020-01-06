using System;
using System.Collections.Generic;

namespace GameApp1
{
    class Program
    {
        public static List<string> Left { get; private set; }
        public static List<string> Right { get; private set; }

        static void Main(string[] args)
        {
            new List<string>();

            while (true)
            {
                
                Console.WriteLine("Dashing around a corner, away from The Beast, you see 2 doors. " +
                    "Which door do you choose? Type: left or right");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (input == "left")
                    Console.WriteLine("You enter a long, torch lit hallway.");
                else if (input == "right")
                    Console.WriteLine("You enter a massive cathedral to The Dark Lord.");
                //I'd like to make this dependant on your initial choice of Left or Right.

                Console.WriteLine("Catching your breath, you see 2 weapons, an Axe and a Sword. " +
                    "Type: Axe or Sword");

                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (input == "axe")
                    Console.WriteLine("Power Axe, + 5 DMG");
                else if (input == "sword")
                    Console.WriteLine("Sword of Speed, + 5 DEX");
                                             
            }
            
            


            
            
        }

    }
}
