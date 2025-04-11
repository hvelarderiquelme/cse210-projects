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
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "yes";
    }

    public override string GetDetailsString(){
        return $"{_shortName} ({_description}).";
    }

    public override int NewScore(){
        int score;
        score = int.Parse(_points);
        
        //Console.WriteLine($"You have {score} points for this goal.");
        
        return score;
        }
}//end of class declaration