//Word class
public class Word{
    private string _text;
    private bool _isHidden;
    private string _values="";
    //Constructor
    public Word(string text, bool isHidden){
        _text = text;
        _isHidden = isHidden;
    }

    //Class methods
    public void Hide(){
        string undereScore = "";
        
        for( int i = 0; i < _text.Length; i++){
            undereScore += "_";        
        }

        _text = undereScore;
        _isHidden = true;
              
    }

    public void Show(){
       
       // _isHidden = false;

    }
    public bool IsHidden(){   
        return _isHidden;
    }

    public string GetDisplayString(){
        
        return _text + " ";

    }

    
}//end of class declaration