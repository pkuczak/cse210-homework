using System;

public class Entry
{
    public string _prompt, _date, _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }
}