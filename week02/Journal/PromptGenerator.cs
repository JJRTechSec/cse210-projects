using System;

public class PromptGenerator
{
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
    
    //int randomIndex = randomPrompt.Next(prompts.Count());
    public void GenerateJournalPrompt()
    {
        {
            Console.WriteLine(prompts[randomIndex]);
        }
    }
}