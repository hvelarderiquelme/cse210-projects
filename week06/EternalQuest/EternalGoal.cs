//Derived class EternalGoal
public class EternalGoal:Goal{
        
    //constructor
    public EternalGoal(string shortName, string description, string points):base(shortName,description,points){}
    //methods
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
    }

    public override bool IsComplete()
    {
            
            return true;
        
    }

    public override string GetStringRepresentation()
    {
        return "yes";
    }

    public override int NewScore(){
        int score;
        score = int.Parse(_points);
        
        //Console.WriteLine($"You have {score} points for this goal.");
        
        return score;

        
    }

    
}//end of class declaration