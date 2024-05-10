using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _textStart;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertTextToList(text);
        _textStart = text;
    }

    private List<Word> ConvertTextToList(string text)
    {
        List<Word> wList = new List<Word>();
        string[] wArray = text.Split(" ");
        foreach(string w in wArray)
        {
            wList.Add(new Word(w));
        }
        return wList;
    }
    
    public void HideRandomWords()
    {
        for(int i=0;i<_words.Count;i++)
        {
            Word currentWord = _words[i];
            string displayText = currentWord.GetDisplayText();
            Word modWord = new Word(displayText);
            _words[i] = modWord; 

        }

    }
    public string GetDisplayText()
    {
        string displayTextRef = _reference.GetDisplayText();
        string textcomplete = _textStart;
        string menu ="Press enter to continue or type 'quit' to finish: ";
        Console.WriteLine($"{displayTextRef} --> {textcomplete}");
        Console.WriteLine(menu);
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                if (!IsCompletelyHidden())
                {
                    HideRandomWords();
                    string modifiedText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
                    Console.Clear();
                    Console.WriteLine($"{displayTextRef} --> {modifiedText}");
                    Console.WriteLine(menu);
                }
                else
                {
                    break; 
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to continue or type 'quit' to finish:");
            }
        }
        return "";
    }
    public bool IsCompletelyHidden()
    {
        bool allHidden=true;
        foreach (Word w in _words)
        {
            if (w.GetDisplayText() != "____")
            {
                allHidden = false;
                break;
            }
        }
        return allHidden; 
    }
}