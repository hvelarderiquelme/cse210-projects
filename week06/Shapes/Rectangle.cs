//class Rectangle(derived)

public class Rectangle: Shapes{
    private double _length;
    private double _width;

    //constructor
    public Rectangle(string color, double length, double width):base(color){
        _length = length;
        _width = width;
    }

   //methods
        public override double GetArea()
    {
        return _length * _width;
    }

    

}//end of class declaration