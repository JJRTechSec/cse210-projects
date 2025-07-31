using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 21);
        string scriptureReference = reference.GetReference();
        Scripture text = new Scripture("And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true");

        Word scripture1 = new Word();
        scripture1.GetDisplayText(); 


        //string hiddenScripture = text.GetDisplayText();

        //Console.WriteLine(hiddenScripture);
    }
}