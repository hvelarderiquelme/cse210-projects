//Derived class EternalGoal
public class EternalGoal:Goal{
        
    //constructor
    public EternalGoal(string shortName, string description, string points):base(shortName,description,points){}
    //methods
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        TotalScorePerGoal();
    }

    public override bool IsComplete()
    {
            
            return false;
        
    }

    public override string GetStringRepresentation()
    {
         string row;
        row = $"{_shortName},{_description},{_points}";
        return row; 
    }

    public override int TotalScore(){
            int score;

            score = int.Parse(_points);
            return score;   
        }
    
}//end of class declaration