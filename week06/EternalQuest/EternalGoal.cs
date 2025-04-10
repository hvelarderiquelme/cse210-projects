//Derived class EternalGoal
public class EternalGoal:Goal{
    //constructor
    public EternalGoal(string shortName, string description, string points):base(shortName,description,points){}
    //methods
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

    
}//end of class declaration