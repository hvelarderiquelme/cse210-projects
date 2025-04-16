//Derived Class SimpleGoal
public class SimpleGoal : Goal{
    private bool _isComplete;
    
    //constructor
    public SimpleGoal(string shortName, string description, string points, bool isComplete):base(shortName,description,points){
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        TotalScorePerGoal();
        _isComplete = true;
        

    }

    public override bool IsComplete()
    {
        
        if (_isComplete == true)
             return true;
         else{
            return false;
         }    
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