using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Alicorp";
        job1._titleJob = "Data Analyst";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Google";
        job2._titleJob = "Data Engineer";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "Maria";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }

}