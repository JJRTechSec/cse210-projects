using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 21);
        
        Scripture text = new Scripture(reference, "And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true");

        Console.WriteLine(text.GetDisplayText());
    }
}