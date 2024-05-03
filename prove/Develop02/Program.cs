using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        //Entry anEntry = new Entry();
        //anEntry.Display();
        //theJournal.AddEntry(anEntry);
        //theJournal.DisplayAll();
        bool next = true;
        while(next)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    Entry anEntry = new Entry();
                    theJournal.AddEntry(anEntry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    string _namefileload="";
                    theJournal.LoadFromFile(_namefileload);
                    break;
                case "4":
                    string _namefile="";
                    theJournal.SaveToFile(_namefile);
                    break;
                case "5":
                    next = false;
                    break;
            }
        }
    }
}