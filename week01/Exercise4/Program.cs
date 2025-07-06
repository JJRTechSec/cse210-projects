using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //  List<string> words = new List<string>();
        //  words.Add("help");
        //  words.Add("cripple");
        //  Console.WriteLine(words.Count);
        //  foreach (string word in words)
        // {
        //      Console.WriteLine(word);
        // }
        //  for (int i = 0; i < words.Count; i++)
        //  {
        //      Console.WriteLine(words[i]);
        //  }

        List<int> numbers = new List<int>();
        string userInput = "";
        int sum = 0;
        float average = 0;
        int largest = 0;

        do
        {
            Console.Write("Input a number: ");
            userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
            if (userNumber == 0)
            {
                numbers.Remove(0);
            }
        }
        while (userInput != "0");

        foreach (int number in numbers)
        {
            sum += number;
            average = ((float)sum) / numbers.Count;
            largest = numbers.Max();
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}