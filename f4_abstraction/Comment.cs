public class Comment
{
    public string _person;
    public string _text;

    new Comment(string person, string text)
    {
        _person = person;
        _text = text;
    }

    public string GetPerson()
    {
        return _person;
    }

    public string GetText()
    {
        return _text;
    }

    public string GetDisplayComment()
    {
        return $"{_author}: {_text}";
    }
}