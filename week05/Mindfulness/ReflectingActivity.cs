//derived class ReflectingActivity
using System.Diagnostics;

public class ReflectingActivity:Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //constructor
    public ReflectingActivity(string activityName, string description, int duration, List<string> prompts, List<string> questions): base(activityName,description,duration){
        _prompts = prompts;
        _questions = questions;
    }
    //methods
    public void ReflectingExercise(){

    }

    public string GetRandomPrompt(){
        return "d";
    }

    public string GetRandomQuestion(){
        return "q";
    }

    public void DisplayPrompt(){

    }

    public void DisplayQuestions(){
        
    }
}//end of class declaration