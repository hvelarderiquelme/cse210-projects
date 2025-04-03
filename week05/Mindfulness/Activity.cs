//base class Activity
public class Activity{
    private string _activityName = "";
    private string _description = "";
    private int _duration;
    //constructors
    public Activity(){

    }
    public Activity(int duration){
        _duration = duration;
    }
    public Activity(string activityName, string description){
        _activityName = activityName;
        _description = description;
    }
    public Activity(string activityName, string description, int duration){
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    //methods
    public void DisplaygreetingMessage(){
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_activityName}.");
        Console.WriteLine($"{_description}");

    }

    public void DisplayFinishMessage(){
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
    }

        public void DisplayDelay(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);
        string[] animation={"-","\\","|","/","-","\\","|","/"};
        int i = 0;
        
        while (DateTime.Now < endTime){

             Console.Write($"{animation[i]}");
             Thread.Sleep(500);
             Console.Write($"\b\b");
             i++;

            if(i >= animation.Count()){
                i=0;
            } 
        }
    }

    public void DisplayTimer(){
        for(int i=8; i>0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b");

        }
        
    }

    public int GetDuration(){
        return _duration;
    }
}//end of class declaration