using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        resume._personName = "John Doe";
        Job job1 = new Job();
        job1._company = "My Company";
        job1. _jobTitle = "Ego Trip Advisor";
        job1._startYear = 1592;
        job1._endYear = 2078;
        Job job2 = new Job();
        job2._company = "Soul Search Inc";
        job2. _jobTitle = "Sr Ego Trip Advisor";
        job2._startYear = 2078;
        job2._endYear = 3032;
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.Display();

    }
}