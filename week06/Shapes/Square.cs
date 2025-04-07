//Square classs(derived)
public class Square: Shapes{
    private double _side;

    //constructor
    public Square(string color, double side): base(color){
        _side = side;
    }
    //methods
    public override double GetArea()
    {
        return _side * _side;
    }

}// end of class declaration