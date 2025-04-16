//Derived class ChecklistGoal
using System.Threading.Channels;

public class ChecklistGoal:Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    private int _scorePlusBonus;

    //constructor
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus, int amountCompleted, bool isComplete):base(shortName,description,points){
        _target= target;
        _bonus = bonus;
        _isComplete = isComplete;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        TotalScorePerGoal();
        _amountCompleted++; 
    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target){       
            return true;
        }
        else{
            return false;
        }    
    }

    public override string GetStringRepresentation()
    {
         string row;
        row = $"{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted},{_isComplete}";
        return row; 
    }

    public override string GetDetailsString(){
        if(_amountCompleted == _target){

            return $"{_shortName} ({_description}). You have completed {_amountCompleted}/{_target} times for this goal. Great job! You've earned {_bonus} extra points!";
        }
        else{       
            return $"{_shortName} ({_description}). You have {_amountCompleted}/{_target} times for this goal. Keep going!";
        }    
    }

    public int GetBonus(){
        return _bonus;
    }

    public override int TotalScore(){
        int score;
        if(IsComplete()==true){
            score = int.Parse(_points) + _bonus;
            Console.WriteLine($"Congratulations! You have won {_bonus} extra points!");
        }
        else{
            score = int.Parse(_points);
        }
        
        return score;   
    }

}//end of class declaration