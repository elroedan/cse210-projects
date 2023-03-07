public class EternalGoal : Goal
{
    public EternalGoal() : base("Eternal", "N/A", 0)
    {

    }

    public override string GetInformation()
    {
        string title = GetTitle();
        string description = GetDescription();
        int point = GetPoint();

        return $"{title} : {point} | {description} ";
        
    
    }
    public override string Save()
    {
        string data = GetInformation();
        System.Console.WriteLine("Enter name of the file (Entry1.txt): ");
        string _fileName = System.Console.ReadLine();


        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            writer.WriteLine(data);
        } 
        
        string _fileWritten = ("The entry has been written to the file.");
        System.Console.WriteLine(_fileWritten);
        return _fileName;
        

    }
}