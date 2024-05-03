public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        PromptGenerator randomPrompt = new PromptGenerator();
        string randomPromptResult = randomPrompt.GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPromptResult}");
        Console.Write("Input your entry: ");
        string entryUser = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        newEntry._promptText = randomPromptResult;
        newEntry._entryText = entryUser;
        newEntry._date = dateText;

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.Write("Input the filename: ");
        file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._promptText},{entry._entryText},{entry._date}";
                outputFile.WriteLine(line);
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.Write("Input the filename: ");
        file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string entry = parts[1];
            string date = parts[2];

            Entry newEntryLoad = new Entry();
            newEntryLoad._promptText = prompt;
            newEntryLoad._entryText = entry;
            newEntryLoad._date = date;
            _entries.Add(newEntryLoad);
        }
    }
}