using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
        Console.WriteLine($"Comments: {NumberOfComments()}");
        foreach (Comment c in _comments)
        {
            c.Display();
        }
        Console.WriteLine();
        
    }

    public void AddComment(string username, string comment)
    {
        Comment newComment = new Comment(username, comment);
        _comments.Add(newComment);

    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}
