using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Timer

{
    // Initialize variables
    private TimeSpan _totalTime;

    public DateTime StartTime;
    public DateTime EndTime;
    public string Start { get; set; }
    public string Stop { get; set; }

    // Constructor that reads "Stopwatch" whenever there is a new instance of the "Timer" class.
    public Timer()
    {
        Console.WriteLine("Stopwatch");        

    }

    // Timespan method that calculates time passed while stopwatch is running
    public TimeSpan TotalTime(DateTime startTime, DateTime endTime)
    {
        this.StartTime = startTime;
        this.EndTime = endTime;

        // Total time passed is the current time when the stopwatch application is begun subtracted
        // from the current time when the stopwatch application is terminated.
        _totalTime = endTime - startTime;

        return _totalTime;

    }


    

}

