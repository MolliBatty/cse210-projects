using System;

class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}: {_response}");
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public string GetDate()
    {
        return _date;
    }
    
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
}
