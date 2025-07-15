using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a new entry
        PromptGenerator prompt = new PromptGenerator();
        prompt.GenerateJournalPrompt();

        Entry response = new Entry();
        response.TakeResponse();

        Console.WriteLine(response._response);

        //prompt1._response = Console.ReadLine();
        // Display the journal
        // Save journal to a file
        // Load journal from a file
        // Provide a menu for user to choose from (initial prompts)
        // List of prompts for user to answer
    }
}