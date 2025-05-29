using System;

class Video
{
    private string _title; // restrict access
    private string _author; // restrict access
    private int _length; // restrict access

    public Video(string title, string author, int length) // Constructor
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public string Title // Property for title
    {
        get { return _title; }
        set { _title = value; }
    }
    public string Author // Property for author
    {
        get { return _author; }
        set { _author = value; }
    }
    public int Length // Property for length
    {
        get { return _length; }
        set { _length = value; }
    }
    public string DisplayVideoInfo() // Method to display video information
    {
        return $"Title: {_title} created by {_author}, Length: {_length} seconds";
    }
}