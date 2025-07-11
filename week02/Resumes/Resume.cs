using System;

public class Resume
{
	public string _name;
	public List<Job> _employmentHistory = new List<Job>();

	public void DisplayEmploymentHistory()
	{
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine("Employment History: ");

		foreach (Job job in _employmentHistory)
		{
			job.DisplayJobDetails();
		}
	}
}