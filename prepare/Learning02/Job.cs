using System;

class Job
{
    public string _titleJob;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
        {
            Console.WriteLine($"{_titleJob} ({_company}) {_startYear}-{_endYear}");
        }
}