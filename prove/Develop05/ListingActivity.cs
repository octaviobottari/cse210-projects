using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are moments you felt peace recently?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the positives by listing as many things as you can.") { }

    public override void RunActivity()
    {
        StartActivity();
        int duration = GetDuration();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        PauseWithAnimation(3);

        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine())) count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}
