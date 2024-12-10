using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on your strengths and resilience.") { }

    public override void RunActivity()
    {
        StartActivity();
        int duration = GetDuration();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        PauseWithAnimation(3);

        int questionTime = duration / Questions.Count;
        foreach (var question in Questions)
        {
            Console.WriteLine(question);
            PauseWithAnimation(questionTime);
        }
        EndActivity();
    }
}
