//Base Class Goal
public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;

    protected int _goalScore;
    

    //Constructor
    public Goal(string shortName, string description, string points){
        _shortName = shortName;
        _description = description;
        _points = points; 
    }

    public virtual string GetDetailsString(){
        return $"{_shortName} ({_description}).";
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract int TotalScore(); 
    
    public abstract string GetStringRepresentation();
    //****************************************Creativity. This methos keep strack of teh individual goal score*****************************//
    public void TotalScorePerGoal(){
        
        _goalScore += int.Parse(_points);
        Console.WriteLine($"You have {_goalScore} points for this goal.");
        
    }
    //*************************************************************************************************************************************//

    public string GetName(){
        return _shortName;
    }

    public int GetPoints(){
        return int.Parse(_points);
    }

    
}// end of class declaration