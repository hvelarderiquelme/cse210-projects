//Word class
public class Word{
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text){
        _text = text;
    }

    //Class methods
    public void Hide(){
        
        
    }

    public void Show(){
        
    }
    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplayString(){
        return _text;
    }
}//end of class declaration