

public class Video
{
    private string _title;
    private string _author;
    private int _length;
 
    private List<Comment> _comments = new List<Comment>();
    public string Title {
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


    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }
    
    public void DisplayComment()
    {
        int count = _comments.Count();
        
        for (int i = 0; i < count; i++){
        
            System.Console.WriteLine($"     {i+1} {_comments[i].GetName()}");
            System.Console.WriteLine($"         -- {_comments[i].GetText()}--");
        }

    } 

    public void AddComment()
    {
        
        Comment comment = new Comment("", "");
        comment.SetName("Unkown");

        System.Console.WriteLine("Enter your Comment down below:");
        string text = Console.ReadLine();
        comment.SetText(text);

        _comments.Add(comment);
    }
    
    public void RemoveComment()
    {
       DisplayComment();
       System.Console.Write("Which comment would you like to remove? ");
       string remove = Console.ReadLine();
       int removingIndex = int.Parse(remove);

       _comments.RemoveAt(removingIndex+1);
       System.Console.WriteLine($"Comment removed"); 

    }

    
    
    
}