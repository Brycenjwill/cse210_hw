using System;

public class Job {
    public string company;
    public string job_title;
    public int start_year;
    public int end_year;

public void display_info(){
 Console.WriteLine($"{job_title} ({company}) {start_year}-{end_year}");
}
}