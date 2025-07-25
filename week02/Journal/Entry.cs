using System;
// Represents a single journal entry
class Entry
{
    // Responsibility
    // To take the entry and store it.
    // State

    // Behaviour
    public string ReceiveNewEntry()
    {
        string newestEntry = Console.ReadLine();
        return newestEntry;
    }
}