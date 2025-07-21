using System;
using System.IO;

class Journal
{
    public static void SaveToFile(List<Entry> _entries)
    {
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine(_entries);
        }
    }
}