//derived class ListingActivity
public class ListingActivity:Activity{
    private int _numberOfEntries;
    private List<string> _prompts = new List<string>();
    private List<string> _entries = new List<string>();

    //constructor
    public ListingActivity(string activityName, string description, int duration, List<string> prompts): base(activityName,description,duration){
        
        _prompts = prompts;
    }

    //methods
    public void ListingExercise(){
        
        Console.Clear();
        Console.WriteLine("Let's get ready...");
        DisplayDelay();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRamdomPrompt();
        Console.WriteLine("You may beging in: ");
        DisplayTimer();
        GetListofEntries();
                    
        _numberOfEntries = _entries.Count;
        Console.WriteLine($"You listed {_numberOfEntries} responses!");
        DisplayFinishMessage();
        DisplayDelay();  

    }

    public void GetRamdomPrompt(){
        
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index].ToString();
        Console.WriteLine($"-----{prompt}-----");
        Console.ReadLine();
                
    }

    public List<string> GetListofEntries(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        string entry;
        while(DateTime.Now < endTime){
            Console.Write($"> ");
            entry = Console.ReadLine();
            _entries.Add(entry);
        }    
        return _entries;
    }

}//end of class declaration