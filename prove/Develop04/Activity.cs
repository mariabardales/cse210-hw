using System;
using System.ComponentModel.Design;
public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;
    public Activity()
    {
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the Activity Menu!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Please enter the duration for this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.WriteLine($"Welcome to the {breathingActivity.GetName()} Activity");
                Console.WriteLine(breathingActivity.GetDescription());
                Console.Write("Please enter the duration for this activity (in seconds): ");
                _duration = int.Parse(Console.ReadLine());
                breathingActivity.Run();
                break;
            case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.WriteLine($"Welcome to the {reflectingActivity.GetName()} Activity");
                Console.WriteLine(reflectingActivity.GetDescription());
                Console.Write("Please enter the duration for this activity (in seconds): ");
                _duration = int.Parse(Console.ReadLine());
                reflectingActivity.Run();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                Console.WriteLine($"Welcome to the {listingActivity.GetName()} Activity");
                Console.WriteLine(listingActivity.GetDescription());
                Console.Write("Please enter the duration for this activity (in seconds): ");
                _duration = int.Parse(Console.ReadLine());
                listingActivity.Run();
                break;
            case "4":
                Console.WriteLine("Quitting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                DisplayStartingMessage();
                break;
        }


    }
    public void DisplayEndingMessage()
    {

    }
    public void Showspinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }
}