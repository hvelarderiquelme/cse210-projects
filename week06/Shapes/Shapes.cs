//Base class Shapes(abstract)

using System.Dynamic;


public class Shapes{
    private string _color;
    
    //constructor
    public Shapes(string color){
        _color = color;
    }

    //methods
    public virtual double GetArea(){
        return 0.0;
    }

    public string GetColor(){
        return _color;
    }
}