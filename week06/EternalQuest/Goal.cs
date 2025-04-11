//Base Class Goal
public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;

    protected int newScore;
    

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
    
    public abstract string GetStringRepresentation();

    public abstract int NewScore();

    public string GetName(){
        return _shortName;
    }

    public int GetPoints(){
        return int.Parse(_points);
    }
}// end of class declaration