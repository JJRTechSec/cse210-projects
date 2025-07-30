using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joseph", "Exponentiation");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment maths = new MathAssignment("Joseph J-R", "Exponentiation", "3.6", "1-9");
        Console.WriteLine($"{maths.GetSummary()}");
        Console.WriteLine(maths.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Jamie Lee", "English", "Animal Farm");
        Console.WriteLine($"{writing.GetStudentName()}, {writing.GetTopic()}");
        Console.WriteLine(writing.GetWritingInformation());
    }
}