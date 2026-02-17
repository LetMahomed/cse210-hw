using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("Feb 1, 2026", 30, 4.8);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("Feb 12, 2026", 60, 15);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("Feb 20, 2026", 20, 20);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}