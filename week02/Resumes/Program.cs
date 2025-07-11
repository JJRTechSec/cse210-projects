using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2004;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Samsung";
        job2._jobTitle = "Lead Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Joseph Jameson-Rickard";

        resume._employmentHistory.Add(job1);
        resume._employmentHistory.Add(job2);

        resume.DisplayEmploymentHistory();
    }
}