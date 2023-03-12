public class EternalGoal : Goal
{   
    
    public EternalGoal() : base("Eternal", "N/A", 0)
    {

    }
    public void SetDataForLoad(string title, string description, int point)
    {
        SetTitle(title);
        SetDescription(description);
        SetPoint(point);
        
    }

    /*
        This method Gets information and returns it in 
        a string format (Might help when saving and loading file)
    */
    public override string GetInformationSaved()
    {
        string title = GetTitle();
        string description = GetDescription();
        int point = GetPoint();

        return $"Eternal:{title}|{point}|{description} ";
        
    
    }

    public override bool GetFinished()
    {
        throw new NotImplementedException();
    }
    public override void SetInformation(string stringRep)
    {
           string[] parts = stringRep.Split("|");
           string title = parts[0];
           string pointString = parts[1];
           int point = int.Parse(pointString);
           string description = parts[2];

           SetTitle(title);
           SetDescription(description);
           SetPoint(point);
    }
    public override string DisplayInformation()
    {
        return base.DisplayInformation();
    }


    public override string DisplayGoals()
    {
        return GetTitle();
    }
}