//Goal MAnager Class where mmost of teh main program will be
using System.Runtime.Serialization;

public class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _totalPoints=0;
    
    //constructor
    
    public GoalManager(){
        _score = 0;
    }

    //methods
    public void Start(){
        
        string strChoice;
        int intChoice = 0;
        bool completedOneGoal = false;

        Console.Clear();
        Console.WriteLine("Welcome to the Goals program! What would you like to do?");
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        

        while(intChoice < 6){
            
            Console.WriteLine("Menu options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            strChoice = Console.ReadLine();
            intChoice = int.Parse(strChoice);
           
            switch(intChoice){

                case 1:
                    CreateGoal();
                    if(completedOneGoal == false){
                        Console.WriteLine($"\nYou have 0 points.");
                    }
                    else{
                        TotalPoints(0);
                    }
                    break;
                case 2:
                    ListGoalDetails();
                    if(completedOneGoal == false){
                        Console.WriteLine($"\nYou have 0 points.");
                    }
                    else{
                        TotalPoints(0);
                    }
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    ListGoalNames();
                    completedOneGoal=true;
                    break;

            }//end of switch statement

        }
    }

    public void DisplayPlayerInfo(){

    }

    public void ListGoalNames(){
        
        int i=1;

        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach(var goal in _goals){
            Console.WriteLine($"{i++}. {goal.GetName()}.");
        }
        
        RecordEvent();
}

    public void ListGoalDetails(){

       int i=1;
       bool complete;
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach(var goal in _goals){
            complete = goal.IsComplete();
            
            if(complete == true){
                Console.WriteLine($"{i++}. [X] {goal.GetDetailsString()}");
            }
            else{
                Console.WriteLine($"{i++}. [ ] {goal.GetDetailsString()}");
            }    
        }
        Console.WriteLine();

    }

    public void CreateGoal(){
        string strGoalType;
        int intGoalType;
        string shortName;
        string description;
        string points;
        string strAmountCompleted;
        string strBonus;

        Console.WriteLine();
        Console.WriteLine("Types of goals:");
        Console.WriteLine("\t1.Simple Goal");
        Console.WriteLine("\t2.Eternal Goal");
        Console.WriteLine("\t3.Checklist Goal");
        Console.WriteLine();
        Console.Write("Which type of goal do you want to create? ");
        strGoalType = Console.ReadLine();
        intGoalType = int.Parse(strGoalType);

        if(intGoalType == 1){
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("Please describe the goal: ");
            description = Console.ReadLine();   
            Console.Write("How many points do you want to give yourself for this goal? ");
            points = Console.ReadLine();

            SimpleGoal simpleGoal = new(shortName,description,points);
            _goals.Add(simpleGoal);
             
        }
        else if(intGoalType == 2){
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("Please describe the goal: ");
            description = Console.ReadLine();   
            Console.Write("How many points do you want to give yourself for this goal? ");
            points = Console.ReadLine();

            EternalGoal eternalGoal = new(shortName,description,points);
            _goals.Add(eternalGoal);
        }
        else if(intGoalType == 3){
            Console.Write("What is the name of your goal? ");
            shortName = Console.ReadLine();
            Console.Write("Please describe the goal: ");
            description = Console.ReadLine();   
            Console.Write("How many points do you want to give yourself for this goal? ");
            points = Console.ReadLine();
            Console.Write("How many times does this goal need to be done to be considered completed? ");
            strAmountCompleted = Console.ReadLine();
            Console.Write("What is the bonus points added to this goal when it is completed? " );
            strBonus = Console.ReadLine();

            ChecklistGoal checklistGoal = new(shortName,description,points,int.Parse(strAmountCompleted),int.Parse(strBonus));
            _goals.Add(checklistGoal);
           
        }


    }// end of CreateGoal method

    public void RecordEvent(){
        string strGoalNumber;
        
        Console.Write($"\nWhich goal did you accomplished? ");
        strGoalNumber = Console.ReadLine();
        _goals[int.Parse(strGoalNumber)-1].RecordEvent();
        _score = _goals[int.Parse(strGoalNumber)-1].TotalScore();
        TotalPoints(_score);   
    }

    public void SaveGoals(){
        
        string filename;
        
        Console.Write("Please enter the name of the file: ");
        filename = Console.ReadLine();
       
        /*Writes in filename*/
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
             Console.WriteLine($"Saving your goals...");
             outputFile.WriteLine($"{_totalPoints}");
            foreach(var goal in _goals)
            {
                outputFile.WriteLine($"{goal}:{goal.GetStringRepresentation()}");
            }            
        }

    }

    public void LoadGoals(){
        // string filename;
       
        // Console.Write("Please enter the name of the file to load: ");
        // filename = Console.ReadLine();
        
        // string[] goals = System.IO.File.ReadAllLines(filename);
        // Console.WriteLine(goals[0]);
        // _totalPoints = int.Parse(goals[0]);
        
        // for(int i=1; i < goals.Length; i++)
        // {
        //    Console.WriteLine(goals[1]);
        //    string[] objectAndAttributes = goals[1].Split(":");
           
           
        //    string strAttributes = objectAndAttributes[1];
        //    Console.WriteLine(strAttributes);
        //    string[] splitAttributes = strAttributes.Split(",");
           
        //    for (int n = 0; n < splitAttributes.Length; n++){
        //         Console.WriteLine(splitAttributes[n]);
        //         objectAndAttributes.ToList().Add(splitAttributes[n]);
        //    }
        
        // }
    }

    public void TotalPoints(int sumScore){
        
            _totalPoints += sumScore;
        
        Console.WriteLine($"You have {_totalPoints} total points.");
    }

    public void ReadGoal(){
        
        Console.WriteLine("Hi");
    }

}//end of Class declaration