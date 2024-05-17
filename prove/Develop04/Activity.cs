using System;
using System.ComponentModel.Design;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name="";
        _description="";
        _duration=0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.Write("Please enter the duration for this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready!");
        Showspinner(3);
        Console.WriteLine(" ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine($" ");
        Showspinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        Showspinner(3);
        Console.Clear();
    }
    public void Showspinner(int seconds)
    {
        List<string> animation=new List<string>();
        animation.Add("»");
        animation.Add("»");
        animation.Add("«");
        animation.Add("«");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i =0;
        while(DateTime.Now<endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i>=animation.Count)
            {
                i=0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {     
        for (int i=1;i<seconds;i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
    }
}