using System;
using System.IO;

class Journal
{
    public List<string> Entries = new List<string>();

    public string _filename;

    public void DisplayJournalEntries()
    {
        foreach (string entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveFile(string _filename)
    {
        using (StreamWriter journal = new StreamWriter(_filename))
        {
            foreach (string entry in Entries)
            {
                journal.WriteLine(entry);
            }
        }
    }

    public void LoadFile(string _filename)
    {
        Entries.Clear();
        using (StreamReader journal = new StreamReader(_filename))
        {
            string entry;
            while ((entry = journal.ReadLine()) != null)
            {
                Entries.Add(entry);
            }
        }
    }
}