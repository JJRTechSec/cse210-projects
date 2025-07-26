using System;

class Program
{
    static void Main(string[] args)
    {
        string programChoice = "";
        Journal journal = new Journal();

        while (programChoice != "5")
        {
            PromptGenerator programOptions = new PromptGenerator();
            programOptions.DisplayProgramOptions();
            programChoice = programOptions.ReceiveUserProgramChoice();

            if (programChoice == "1")
            {
                //WRITE
                PromptGenerator journalPrompt = new PromptGenerator();
                string prompt = journalPrompt.GenerateJournalPrompt();
                Console.WriteLine(prompt);

                Entry newEntry = new Entry();
                string userEntry = newEntry.ReceiveNewEntry(prompt);
                journal.Entries.Add(userEntry);
            }

            else if (programChoice == "2")
            {
                //DISPLAY
                journal.DisplayJournalEntries();
            }

            else if (programChoice == "3")
            {
                //SAVE
                Console.WriteLine("Please name the file you wish to save your journal to: ");
                journal._filename = Console.ReadLine();
                journal .SaveFile(journal._filename);
            }

            else if (programChoice == "4")
            {
                //LOAD
            }

            else if (programChoice == "5")
            {
                Console.WriteLine("Have an amazing rest of your day");
                break;
            }
        }
    }
}