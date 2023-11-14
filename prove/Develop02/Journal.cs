using System;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    PromptGenerator _randomPrompt = new PromptGenerator();

    public void AddEntry()
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = _randomPrompt.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        Console.Write("> ");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToCSV()
    {
        string fileName;

        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            outputFile.WriteLine(entry.GetEntryAsCSV());
        }
    }

    public void LoadFromCSV()
    {
        string fileName;
        
        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            
            _entries.Add(newEntry);
        }
    }
}