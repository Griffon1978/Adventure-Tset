using System;
using System.Collections.Generic;


namespace GameApp1
{
    class Program
    {
       static void Main()
        {
            string CharacterName = "John Doe";

            Console.WriteLine("Game 1.1");
            Console.WriteLine("Sunrise in the Underdark");
            Console.WriteLine("Enter your Name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Your Character is named " + CharacterName);
            Console.ReadKey();
        }

    }
}
