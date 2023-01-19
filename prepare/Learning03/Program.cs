using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Amazon";
        job1._startYear = 2012;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Software engineer";
        job2._company = "Netflix";
        job2._startYear = 2006;
        job2._endYear = 2012;

        Resume resume = new Resume();
        resume._firstName = "Elroe";
        resume._lastName = "Daniel";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();




       
    }
}