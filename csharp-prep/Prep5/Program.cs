using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squnumber = SquareNumber(number);

        DisplayResult(name, squnumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username=Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favnumbers=Console.ReadLine();
        int favnumber = int.Parse(favnumbers);
        return favnumber;
    }

    static int SquareNumber(int favnumber)
    {
        int squnumber =  favnumber*favnumber;
        return squnumber;
    }

    static void DisplayResult(string userName,int squnumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squnumber}");
    }
}