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
        for (int index = 1; index <= programListIndex; index++)
        {
            Console.WriteLine($"{index} - {programOptions[index-1]}");
        }
    }

    public string ReceiveUserProgramChoice()
    {
        Console.Write("Please select an option from above (1-5):");
        _userProgramChoice = Console.ReadLine();
        return _userProgramChoice;
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

    public static Random randomPrompt = new Random();

    public string GenerateJournalPrompt()
    {
        int randomIndex = randomPrompt.Next(prompts.Count());
        return prompts[randomIndex];
    }
}