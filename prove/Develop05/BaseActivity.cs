using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("\nPrepare to begin...");
        PauseWithAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        PauseWithAnimation(3);
    }

    public int GetDuration() => _duration;

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}
