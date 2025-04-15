//derived clkass Running
public class Running:Activity{
    private double _distance;

    //constructor
    public Running(string date, int time, double distance):base(date,time){
        _distance = distance;
    }

    public override double CalculateDistance()
    {
       return _distance;
    }

    public override double CalculateSpeed()
    {
        return Math.Round((_distance/_time)*60,2);
    }

    public override double CalculatePace()
    {
        return Math.Round(_time/_distance,2);
    }

    

}