using System;

class Lecture : Event
{
    private string _speakername;
    private int _capacity;

    public Lecture (string title, string description, string date, string time, Address address, string speakername, int capacity)
        : base(title, description, date, time, address)
    {
        _speakername = speakername;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Lecture, Speaker: {_speakername}, Capacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        return $"Lecture, {_title}, {_date}";
    }
}