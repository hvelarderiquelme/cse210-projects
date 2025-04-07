
//class Circle(derived)
public class Circle: Shapes{
    private double _radius;

    //constructor
    public Circle(string color, double radius): base(color){
        _radius = radius;
    }
    //methods
    public override double GetArea()
    {
        return _radius*_radius*Math.PI;
    }
}