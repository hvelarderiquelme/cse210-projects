//Base class Activity
using System.Runtime;

public abstract class Activity{
    protected string _date;
    protected int _time;

    //constructor
    public Activity(string date, int time){
        _date = date;
        _time = time;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public void DisplayCalculations(){
        Console.WriteLine($"{_date} {GetType()} ({_time} min)- Distance {CalculateDistance()} Kilometers, Speed {CalculateSpeed()} Kph, Pace {CalculatePace()} min per Km ");
    }

    


}