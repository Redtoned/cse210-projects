using System;
using System.Collections.Generic;

public class Video
{
    // Fields
    private string _title;
    private string _author;
    private int _length; // length in seconds
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Properties
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    // Add a comment to this video's list of comments
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Return the number of comments on this video
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}
