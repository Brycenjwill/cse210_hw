using System;

public class resume
{
    public string name;

    public List<Job> jobs = new List<Job>();

    public void display_info()
    {
        Console.WriteLine($"Name: {name}");
        
        Console.WriteLine("Jobs:");

        foreach (Job job in jobs)
        {
            job.display_info();
        }
    }
}