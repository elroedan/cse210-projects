public class SimpleGoal : Goal
{   
    
    public SimpleGoal() : base("Simple", "N/A", 0)
    {

    }

    public override string GetInformationSaved()
    {
        string title = GetTitle();
        string description = GetDescription();
        int point = GetPoint();

        return $"Simple:{title} | {point} | {description} ";
        
    
    }

    public override string DisplayInformation()
    {
        return base.DisplayInformation();
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

    public override bool GetFinished()
    {
        throw new NotImplementedException();
    }

    public override string DisplayGoals()
    {
        return GetTitle();
    }

   
}


