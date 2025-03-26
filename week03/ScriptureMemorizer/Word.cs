//Word class
public class Word{
    private string _text;
    private bool _isHidden;
    //private string displayMemorizerText="";

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
        //displayMemorizerText += undereScore;
        Console.Write(_text);
              
    }

    public void Show(){
       
        Console.Write(_text);

    }
    public bool IsHidden(){   
        return _isHidden;
    }

    // public string GetDisplayString(){
        
    //     return displayMemorizerText;

    // }
}//end of class declaration