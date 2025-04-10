//Goal MAnager Class where mmost of teh main program will be
using System.Runtime.Serialization;

public class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    //constructors
    public GoalManager(){
        _score = 0;
    }
    public GoalManager(List<Goal> goals, int score){
        _goals = goals;
        _score = score;
    }

    //methods
    public void Start(){
        string strChoice="";
        int intChoice = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Goals program! What would you like to do?");
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();

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
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;

            }//end of switch statement

        }
    }

    public void DisplayPlayerInfo(){

    }

    public void ListGoalNames(){
        Console.WriteLine();
        Console.WriteLine("These are your goals:");
        foreach(var goal in _goals){
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine();
    }

    public void ListGoalDetails(){

    }

    public void CreateGoal(){
        string strGoalType;
        int intGoalType;
        string shortName;
        string description;
        string points;

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
            Console.WriteLine(intGoalType);
        }


    }

    public void RecordEvent(){

    }

    public void SaveGoals(){

    }

    public void LoadGoals(){

    }

}//end of Class declaration