using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What's a memorable experience from today that you'd like to share?",
                "Is there a particular person who brightened your day, and how did they do it?",
                "What's a personal achievement or goal you made progress on today?",
                "Did you encounter any interesting challenges that tested your problem-solving skills?",
                "Share a moment when you felt a strong sense of gratitude today.",
                "What's something you're looking forward to in the near future?",
                "Did you explore a new interest or hobby today?",
                "What's a lesson you learned from a mistake or setback today?",
                "Tell me about a random act of kindness you witnessed or participated in today.",
                "How did you take care of your physical or mental well-being today?",
                "Share a recent discovery that piqued your curiosity.",
                "What's a fun or exciting plan you have for tomorrow?",
                "Describe an instance when you made someone else's day a little better.",
                "Did you take time for self-reflection or meditation today?",
                "What's a small step you took towards achieving a long-term goal?",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Until next time, keep writing!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}