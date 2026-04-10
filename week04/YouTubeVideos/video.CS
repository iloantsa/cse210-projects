public class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;


    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLength)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = videoLength;

    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }


}

