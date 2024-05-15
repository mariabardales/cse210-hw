using System;
public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string nameStudent,string topic)
    {
        _studentName=nameStudent;
        _topic=topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
}