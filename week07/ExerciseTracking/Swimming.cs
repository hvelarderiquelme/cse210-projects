//drived class swimming
public class Swimming:Activity{
    private double _laps;

    //constructor
    public Swimming(string date, int time, double laps):base(date, time){
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        
        return _laps*50/1000;
    }

    public override double CalculateSpeed()
    {
       return (CalculateDistance()/_time)*60; 
    }

    public override double CalculatePace()
    {
        double speed = CalculateSpeed();
        return 60/speed;
    }

    


}