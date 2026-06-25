using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;
    private List<string> _prompts;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>();

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public void AddEntry(string prompt, string response, string date)
    {
        Entry newEntry = new Entry(prompt, response, date);
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void Save(string filename)
    {
        StreamWriter outputFile = new StreamWriter(filename);
        foreach (Entry e in _entries)
        {
          outputFile.WriteLine($"{e.GetDate()}: {e.GetPrompt()}: {e.GetResponse()}");  
        }
        outputFile.Close();
    }

    public void Load(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split(": ");
            AddEntry(parts[1], parts[2], parts[0]);
        }
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        return _prompts[index];
    }
}

