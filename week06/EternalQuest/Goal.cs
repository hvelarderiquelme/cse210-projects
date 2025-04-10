//Base Class Goal
public abstract class Goal{
    private string _shortName;
    private string _description;
    private string _points;

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
}// end of class declaration