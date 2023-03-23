

public class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }

// Set name doesn't prompt the user 
// Make a change
    public void SetName(string userName)

    {
        System.Console.Write("Enter Your Name: ");
        userName = Console.ReadLine();
        _name = userName;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    
}