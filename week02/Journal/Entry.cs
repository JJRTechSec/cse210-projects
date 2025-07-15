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
        Console.ReadLine();
        Console.WriteLine(_response);
        return _response;
    }
}