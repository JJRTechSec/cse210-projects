using System;
using System.IO;

class Journal
{
    public List<string> Entries = new List<string>();

    public void DisplayJournalEntries()
    {
        foreach (string entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }
}