//class Activity Manager

using System.Dynamic;

public class ActivityManager{
    private List<Activity> _activities = new List<Activity>();
   

    public void Start(){
        // fro running provide date, time in min and distance in Km
        Running running = new Running("July 8th 2025", 45, 3.5);
        //For speed provide date, time in min and speed in Kph
        Speed speed = new Speed("April 13 2025", 90, 40);
        //for swimming provide date, time in min and number of laps
        Swimming swimming = new Swimming("Feb 24 2025", 60, 15);
        Running running1 = new Running("03 Nov 2022", 30, 4.8);
       
        _activities.Add(running);
        _activities.Add(speed);
        _activities.Add(swimming);
        _activities.Add(running1);
        Console.WriteLine();
       foreach(var activity in _activities){
            activity.DisplayCalculations();
       }
       
       Console.WriteLine();
        
    }
    
}