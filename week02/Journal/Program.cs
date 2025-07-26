using System;

class Program
{
    static void Main(string[] args)
    {
        string programChoice = "";
        //do
        //{
        //    PromptGenerator programOptions = new PromptGenerator();
        //    programOptions.DisplayProgramOptions();
        //    programChoice = programOptions.ReceiveUserProgramChoice();
        //} while (programChoice != "5");

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

                Journal journalEntries = new Journal();
                journalEntries.Entries.Add(userEntry);
            }

            else if (programChoice == "2")
            {
                //DISPLAY
            }

            else if (programChoice == "3")
            {
                //SAVE
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