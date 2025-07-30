using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joseph", "Exponentiation");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment maths = new MathAssignment("Joseph", "Exponentiation", "3.6", "1-9");
        Console.WriteLine(maths.GetHomeworkList());
    }
}