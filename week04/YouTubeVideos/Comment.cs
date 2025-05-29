using System;
using System.Dynamic;

class Comment
{
    private string _author; //restrict access
    private string _commentText; //restrict access

    public Comment(string author, string commentText)
    {
        _author = author;
        _commentText = commentText;
    }

    public string Author // Constructor
    {
        get { return _author; }
        set { _author = value; }
    }
    public string CommentText // Constructor
    {
        get { return _commentText; }
        set { _commentText = value; }
    }
}