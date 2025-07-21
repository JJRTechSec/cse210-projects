using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a new entry


        PromptGenerator prompt = new PromptGenerator();
        prompt.DisplayProgramOptions();

        if (prompt.ReceiveUserProgramChoice() == "1")
        {
            prompt.GenerateJournalPrompt();
            Entry response = new Entry();
            response.TakeResponse();
            response.ReturnEntry(prompt.GenerateJournalPrompt());
        }
        else if (prompt.ReceiveUserProgramChoice() == "2")
        {
            //Display Journal
        }
        else if (prompt.ReceiveUserProgramChoice() == "3")
        {
            string filename = "Journal.txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Journal entry in outputFile)
                {
                    outputFile.WriteLine(entry);
                }
            }
        }
        else if (prompt.ReceiveUserProgramChoice() == "4")
        {

        }
        else if (prompt.ReceiveUserProgramChoice() == "5")
        {
            Console.WriteLine("Have a great rest of your day!");
        }

        // Display the journal
        // Save journal to a file
        // Load journal from a file
        // Provide a menu for user to choose from (initial prompts)
        // List of prompts for user to answer
    }
}