//Derived Class SimpleGoal
public class SimpleGoal : Goal{
    private bool _isComplete=false;
    
    //constructor
    public SimpleGoal(string shortName, string description, string points):base(shortName,description,points){}

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        TotalScorePerGoal();
        _isComplete = true;
        

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string row;
        row = $"{_shortName},{_description},{_points},{_isComplete}";
        return row;   
    }

    public override int TotalScore(){
        int score;

        score = int.Parse(_points);
        return score;   
    }

}//end of Class declaration