using System;
// Represents a single journal entry
class Entry
{
    // Responsibility
    // To take the entry and store it.
    // State
    public string _response;
    
    // Behaviour
    public string TakeResponse()
    {
        _response = Console.ReadLine();
        return _response;
    }

    public void DisplayResponse()
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        Console.WriteLine($"{dateText} - {_response}");
    }
}