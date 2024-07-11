using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "What are some recent achievements you are proud of?",  
        "Who in your life has had the most positive influence on you, and why?",
        "Describe a time when you stepped out of your comfort zone. What did you learn from the experience?",
        "What are some goals you are currently working towards?",
        "How do you handle stress and what are your coping mechanisms?",
        "What qualities do you look for in a friend, and why?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();
                
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}