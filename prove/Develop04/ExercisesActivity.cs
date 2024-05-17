using System;
public class ExercisesActivity:Activity
{
    private List<string> _prompts;
    public ExercisesActivity()
    {
        _name="Exercises";
        _description="This activity will help you prevent diseases and increase your defenses through physical exercises at home. Find yourself in a clear place.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime stopTime =startTime.AddSeconds(_duration);
        Console.WriteLine("Do the following exercises.");
        Console.WriteLine(" ");
        Console.WriteLine("When you are ready press enter: ");
        Console.ReadLine();
        do{
            GetRandomPrompt();
            ShowCountDown(7);
        }
        while(DateTime.Now<stopTime);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>{
        "Rest your arms on a chair and do push-ups.",
        "With your arms forward, slowly lower yourself into squats.",
        "Perform jump rope."
        };
        Random random4 = new Random();
        int index = random4.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine($"--- {randomPrompt} ---");
    }
}