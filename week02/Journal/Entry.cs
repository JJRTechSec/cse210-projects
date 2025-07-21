using System;
// Represents a single journal entry
class Entry
{
    // Responsibility
    // To take the entry and store it.
    // State
    public string _response;
    public string _givenPrompt;
    
    // Behaviour
    public string TakeResponse()
    {
        _response = Console.ReadLine();
        return _response;
    }

    public string ReturnEntry(string _givenPrompt)
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        return $"{_givenPrompt} - {dateText} - {_response}";
    }
}