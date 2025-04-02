//derived class ListingActivity
public class ListingActivity:Activity{
    private int _time;
    private List<string> _prompts = new List<string>();

    //constructor
    public ListingActivity(string activityName, string description, int duration, int time, List<string> prompts): base(activityName,description,duration){
        _time = time;
        _prompts = prompts;
    }

    //methods
    public void ListingExercise(){

    }

    public void GetRamdomPrompt(){

    }

    public List<string> GetListOfPrompts(){
        return _prompts;
    }

}//end of class declaration