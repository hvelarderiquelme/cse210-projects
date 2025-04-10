//Derived class ChecklistGoal
public class ChecklistGoal:Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //constructor
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus):base(shortName,description,points){
        _target= target;
        _bonus = bonus;
    }

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

    public override string GetDetailsString(){
        return "yes";
    }
}//end of class declaration