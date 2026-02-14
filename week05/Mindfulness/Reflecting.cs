using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a situation where you had to make a tough decision for the greater good.",
        "Think of a time when you supported someone through a challenging period in their life.",
        "Think of a moment when you stood up for your beliefs despite facing opposition.",
        "Think of an instance when you mentored or guided someone to achieve their potential.",
        "Think of a scenario where you made a personal sacrifice to help someone else succeed.",
    };
    private List<string> _questions = new List<string> {
        "How did this experience change your perspective on similar situations in the future?",
        "What challenges did you face during this experience, and how did you overcome them?",
        "In what ways did this experience influence your personal growth or development?",
        "How did your emotions evolve throughout this experience, from start to finish?",
        "What feedback did you receive from others about your actions or decisions during this experience, and how did it impact you?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}
