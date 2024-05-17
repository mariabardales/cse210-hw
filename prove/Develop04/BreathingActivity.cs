using System;
public class BreathingActivity:Activity
{
    public BreathingActivity()
    {
        _name="Breathing";
        _description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime stopTime =startTime.AddSeconds(_duration);

        do{
            Console.WriteLine("Breathe In");
            ShowCountDown(5);

            Console.WriteLine("Breathe Out");
            ShowCountDown(5);
        }
        while(DateTime.Now<stopTime);

        DisplayEndingMessage();
    }
}