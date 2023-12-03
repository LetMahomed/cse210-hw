using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Recall a time when you helped a friend overcome a challenge.",
        "Think of a situation where you did something kind for a stranger.",
        "Remember a moment when you faced a fear and emerged stronger.",
        "Share a memory of when you made a positive difference in someone's day.",
        "Reflect on an instance where you showed patience during a difficult situation.",        
    };
    private List<string> _questions = new List<string> {
        "What differentiates this occasion from previous ones where you were less successful?",
        "What aspect of this experience resonated with you the most?",
        "What broader applications or lessons can you derive from this experience?",
        "What self-discoveries did you make through this encounter?",
        "How can you integrate the insights gained from this experience into future endeavors?",
        "What significance does this experience hold for you?",
        "Have you previously encountered a similar situation?",
        "What were the initial steps you took to initiate this process?",
        "How did you feel upon completing the task?",
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