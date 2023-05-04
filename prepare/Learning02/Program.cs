using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.job_title = "Software Engineer";
        job1.company = "Intel";
        job1.start_year = 2011;
        job1.end_year = 2022;

        Job job2 = new Job();
        job2.job_title = "Physical Therapist";
        job2.company = "The Hospital";
        job2.start_year = 2011;
        job2.end_year = 2019;
        
        job1.display_info();
        job2.display_info();

        resume myResume = new resume();
        myResume.name = "Brycen Williams";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.display_info();

    }
}