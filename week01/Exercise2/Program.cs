using System;

class Program
{
    static void Main(string[] args)
    {
        // ASK FOR PERCENTAGE
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);
        string grade = "";

        // IF ELSE STATEMENTS TO PRINT GRADE 
        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            grade = "D";
        }
        else if (gradePercentage < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade: {grade}");


        // 70 TO PASS, DETERMINE IF THE USER PASSED AND PRINT YES/NO MESSAGE

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass this time. You either win or learn, so use this to learn for next time");
        }
    }
}