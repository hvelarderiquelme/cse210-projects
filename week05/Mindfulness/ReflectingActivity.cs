//derived class ReflectingActivity
using System.Diagnostics;

public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //constructor
    
    public ReflectingActivity(string activityName, string description, int duration, List<string> prompts, List<string> questions): base(activityName,description,duration){
        _prompts = prompts;
        _questions = questions;
    }
    //methods
    public void ReflectingExercise(){
        
        
        Console.Clear();
        Console.WriteLine("Let's get ready...");
        DisplayDelay();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Ponder on each of the following questions as related to this experience.");
        Console.WriteLine("Starting in...");
        DisplayTimer();
        DisplayQuestions();
        DisplayFinishMessage();
        DisplayDelay();
              
        
    }

    public string GetRandomPrompt(){
       
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index].ToString();
                
        return prompt;
    }

    public string GetRandomQuestion(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string question = _questions[index].ToString();
        return question;
    }

    public void DisplayPrompt(){
        Console.WriteLine($"{GetRandomPrompt()}");
    }

    public void DisplayQuestions(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
         while (DateTime.Now < endTime){
            
            Console.WriteLine($"> {GetRandomQuestion()}");
            DisplayDelay();
                
        }    

    }
}//end of class declaration