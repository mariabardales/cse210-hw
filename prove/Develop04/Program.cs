using System;

//The program exceeds the core requirements:
//I have added an activity called Exercises Activity, it consists of giving 
//ideas of physical exercises to do and shows the ideas randomly until the 
//time entered by the user.
class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            Console.WriteLine("Welcome to the Activity Menu!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start exercises activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();
            if (choice=="1")
            {
                BreathingActivity breathingActivity =new BreathingActivity();
                breathingActivity.Run();
                Console.Clear();
            }
            else if (choice=="2")
            {
                ReflectingActivity reflectingActivity =new ReflectingActivity();
                reflectingActivity.Run();
                Console.Clear();
            }
            else if (choice=="3")
            {
                ListingActivity listingActivity =new ListingActivity();
                listingActivity.Run();
                Console.Clear();
            }
            else if (choice=="4")
            {
                ExercisesActivity exercisesActivity =new ExercisesActivity();
                exercisesActivity.Run();
                Console.Clear();
            }
            else if (choice=="5")
            {
                Console.WriteLine("Goodbye");
            }
            else 
            {
                Console.WriteLine("Invalid Choice. Try Again");
            }
            Console.Clear();
        }
        while (choice !="5");
        
    }
}