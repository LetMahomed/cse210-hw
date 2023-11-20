using System;

namespace DailyScripture
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("Genesis ", 18, 14, "Is any thing too hard for the Lord? At the time appointed I will return unto thee, according to the time of life, and Sarah shall have a son. ");            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}