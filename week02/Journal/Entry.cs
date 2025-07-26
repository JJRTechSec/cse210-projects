using System;
// Represents a single journal entry
class Entry
{
    // Responsibility
    // To take the entry and store it.
    // State

    // Behaviour
    public string ReceiveNewEntry(string prompt)
    {
        string newestEntry = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        return $"{dateText}: {prompt} - {newestEntry}";
    }
}