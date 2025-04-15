using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("January 15, 2025", 29, 4.9);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("April 18, 2025", 58, 17);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("Jun 14, 2025", 21, 23);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}