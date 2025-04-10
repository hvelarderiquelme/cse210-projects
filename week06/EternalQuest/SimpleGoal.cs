//Derived Class SimpleGoal
public class SimpleGoal : Goal{
    private bool _isComplete;
    
    //constructor
    public SimpleGoal(string shortName, string description, string points):base(shortName,description,points){}

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "yes";   
    }
}//end of Class declaration