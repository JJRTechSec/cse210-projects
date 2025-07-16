using System;

public class PromptGenerator
{
    public string _userProgramChoice;
    static List<string> programOptions = new List<string>
    {
        "Write new entry",
        "Display journal entries",
        "Save journal",
        "Load journal",
        "Exit"
    };

    public void DisplayProgramOptions()
    {
        Console.WriteLine("Welcome to your journal program.");
        int programListIndex = programOptions.Count();
        for (int index = 0; index <= programListIndex; index++)
        {
            index = index + 1;
            foreach (string option in programOptions)
            {
                Console.WriteLine(option[programListIndex] + " - " + option);
            }
        }

        Console.Write("Please select an option from above (1-5):");
    }

    public void ReceiveUserProgramChoice()
    {
        _userProgramChoice = Console.ReadLine();
    }

    // Journal Question Prompts
    static List<string> prompts = new List<string>
    {
        "What did you do to serve others today?",
        "What did you do to take care of yourself today?",
        "What are three things you did well today?",
        "Who do you think could use a bit of extra attention or loving tomorrow?",
        "What do you want to achieve tomorrow?"
    };

    static Random randomPrompt = new Random();
    public int randomIndex = randomPrompt.Next(prompts.Count());

    public void GenerateJournalPrompt()
    {
        {
            Console.WriteLine(prompts[randomIndex]);
        }
    }
}