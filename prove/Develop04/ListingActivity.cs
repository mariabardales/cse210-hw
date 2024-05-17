using System;
public class ListingActivity:Activity
{
    private int _count=0;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name="Listing";
        _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime stopTime =startTime.AddSeconds(_duration);
        GetRandomPrompt();
        ShowCountDown(4);
        List<string> userResponses = new List<string>();
        do{
            GetListFromUser(userResponses);
            _count=_count+1;
        }
        while(DateTime.Now<stopTime);
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        };
        Random random3 = new Random();
        int index = random3.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("You may begin in:");
    }
    public string GetListFromUser(List<string> list)
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        list.Add(response);
        return response; 
    } 
}