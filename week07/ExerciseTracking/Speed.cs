//Derivred class Speed

public class Speed:Activity{
    private double _speed;

    //constructor
public Speed(string date, int time, double speed):base(date, time){
    _speed = speed;
}

    public override double CalculateDistance()
    {
        return (_speed*_time)/60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60/_speed;
    }
}