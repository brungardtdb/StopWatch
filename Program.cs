using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
    static void Main()
    {
        var timer = new Timer();

        // Prompt user to begin timer
        Console.WriteLine("\nPlease enter 'start' to begin stopwatch.");
       
        
        
            
            var start = Convert.ToString(Console.ReadLine());
        timer.Start = start;
        var startTime = DateTime.Now;

        // check to see if input is valid
        if (timer.Start != "start")
        {
            // Throw exception if input != valid
            throw new System.Exception("Input was not valid.");
        }


        // Prompt user to end timer
        Console.WriteLine("\nPlease enter 'stop' to stop timer.");

        var stop = Convert.ToString(Console.ReadLine());
        timer.Stop = stop;
        var stopTime = DateTime.Now;

        // check to see if input is valid
        if (timer.Stop == "stop")
        {
            // Calculate time passed using TotalTime method
            Console.WriteLine("Total time is: {0}", timer.TotalTime(startTime, stopTime)); 
        }
        else
        {
            // Throw exception if input != valid
            throw new System.Exception("Input was not valid.");
        }


        
        



    }
}
        
     

