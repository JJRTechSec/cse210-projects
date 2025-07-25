using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a new entry


        PromptGenerator programPrompt = new PromptGenerator();
        programPrompt.DisplayProgramOptions();

        if (programPrompt.ReceiveUserProgramChoice() == "1")
        {
            PromptGenerator journalPrompt = new PromptGenerator();
            Console.WriteLine(journalPrompt.GenerateJournalPrompt());

            Entry newEntry = new Entry();
            string userEntry = newEntry.ReceiveNewEntry();

            Journal journalEntries = new Journal();
            journalEntries.Entries.Add(userEntry);
            journalEntries.DisplayJournalEntries();

            // TO CONTINUE
            // STORE DATE AND PROMPT AS WELL TO ENTRY.
        }
        

        // Display the journal
        // Save journal to a file
        // Load journal from a file
        // Provide a menu for user to choose from (initial prompts)
        // List of prompts for user to answer
    }
}