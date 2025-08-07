// For the creativity side of things, I have added the feature of hiding a random number of words (between 3-5 words) instead of the same number each time.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 21);

        Scripture text = new Scripture(reference, "And now as I said concerning faith - faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true");

        while (!text.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(text.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit the program.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            Random random = new Random();
            text.HideRandomWords(random.Next(3, 6));
        }

        Console.WriteLine(text.GetDisplayText());
    }
}