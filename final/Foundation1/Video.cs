
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> ListOfComments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public int ReturnNumOfComments()
    {
        return ListOfComments.Count();
    }

    public void AddComment(Comment comment)
    {
        ListOfComments.Add(comment);
    }



    public void DisplayVideo()
    {
        Console.WriteLine($"Title: '{_title}'");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {ReturnNumOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in ListOfComments)
        {
            Console.WriteLine($"{comment.GetDisplayComment()}");
        }
    }
}
