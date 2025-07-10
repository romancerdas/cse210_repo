public class Video
{
    public string _title;
    public string _author;
    public int _length;

    new Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        List<Comment> ListOfComments = new List<Comments>();
    }


    public int ReturnNumOfComments()
    {
        return ListOfComments.count();
    }


    public string DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {ReturnNumOfComments()}");
        foreach (Comment comment in ListOfComments)
        {
            Console.WriteLine(comment);
        }
    }
}
