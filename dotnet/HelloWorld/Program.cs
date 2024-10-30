using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int loopCount = 100000;
        double totalLoopTime = 0;
        double[] times = new double[loopCount];

        // Start a single Stopwatch
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < loopCount; i++)
        {
            double loopStart = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine("Hello, World!");
            double loopEnd = stopwatch.Elapsed.TotalSeconds;
            
            double elapsed = loopEnd - loopStart;
            totalLoopTime += elapsed;
            times[i] = elapsed;  // Store the elapsed time for median calculation
        }

        stopwatch.Stop();
        double totalTime = stopwatch.Elapsed.TotalSeconds;
        double avgTime = totalLoopTime / loopCount;

        // Median calculation after sorting
        Array.Sort(times);
        double medianTime = (loopCount % 2 == 0) ? 
                            (times[loopCount / 2 - 1] + times[loopCount / 2]) / 2.0 : 
                            times[loopCount / 2];

        Console.WriteLine($"\nTotal Time: {totalTime:F6} seconds");
        Console.WriteLine($"Average Time per Loop: {avgTime:F6} seconds");
        Console.WriteLine($"Median Time per Loop: {medianTime:F6} seconds");
    }
}
