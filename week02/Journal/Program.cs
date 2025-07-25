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
            journalPrompt.GenerateJournalPrompt();
        }
        

        // Display the journal
        // Save journal to a file
        // Load journal from a file
        // Provide a menu for user to choose from (initial prompts)
        // List of prompts for user to answer
    }
}