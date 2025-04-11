//Derived Class SimpleGoal
public class SimpleGoal : Goal{
    private bool _isComplete;
    
    //constructor
    public SimpleGoal(string shortName, string description, string points):base(shortName,description,points){}

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

    public override int NewScore(){
        int score;
        score = int.Parse(_points);
        
        //Console.WriteLine($"You have {score} points for this goal.\n");
        
        return score;   
    }
}//end of Class declaration