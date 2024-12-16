using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
    
        List<Activity> activities = new List<Activity>();

  
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0)); 
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 20.0)); 
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 40)); 

        // make list and print the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
