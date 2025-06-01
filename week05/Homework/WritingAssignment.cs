using System;


public class WritingAssignment : Assignment
{
    private string _essayTitle;

    public string GetEssayTitle()
    {
        return _essayTitle;
    }

    public void SetEssayTitle(string essayTitle)
    {
        _essayTitle = essayTitle;
    }

    public string GetWritingDetails()
    {
        return $"{GetStudentName()} - {GetTopic()} - {_essayTitle}";
    }
}