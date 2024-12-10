using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by pacing your breathing. Clear your mind and focus on your breath.") { }

    public override void RunActivity()
    {
        StartActivity();
        int duration = GetDuration();
        for (int i = 0; i < duration / 2; i++)
        {
            Console.Write("Breathe in...");
            PauseWithAnimation(2);
            Console.Write("Breathe out...");
            PauseWithAnimation(2);
        }
        EndActivity();
    }
}
