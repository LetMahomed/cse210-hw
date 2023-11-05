using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 92)
        {
            letter = "A";
        }
        else if (percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 88)
        {
            letter = "B+";
        }
        else if (percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 78)
        {
            letter = "C+";
        }
        else if (percent >= 72)
        {
            letter = "C";
        }
        else if (percent >= 70)
        {
            letter = "C-";
        }
        else if (percent >= 65)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}