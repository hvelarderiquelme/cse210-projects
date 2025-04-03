//derived class BreatingActivity
using System.ComponentModel;

public class BreathingActivity: Activity{
    //constructor
    public BreathingActivity(string activityName, string description, int duration):base(activityName, description, duration){
        
    }
    //methods
    public void BreathingExercise(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.Clear();
        Console.WriteLine("Let's get ready...");
        DisplayDelay();
        
        while (DateTime.Now < endTime){
            Console.Write("\n\nBreathe in ");
            for(int i = 1; i <= 4; i++){
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.Write("\n\nBreathe out ");
            for(int i = 1; i <= 4; i++){
                Thread.Sleep(1000);
                Console.Write(".");
            }
        }
        DisplayFinishMessage();
        DisplayDelay();

    }

}// end o fclass declaration