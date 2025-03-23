//Scripture class
using System.Security.Principal;

public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;//not for use just to finish method declaration
    private bool _is;//not for use just to finish method declaration
    
    //class constructor
    public Scripture(Reference reference, string text){
       
        _reference = reference;
        _text = text;
        string[] words = text.Split();
        for(int i=0;i<words.Length;i++){
            _words.Add(new Word(words[i]));
        }

    }
    //Class methods
    public void HideRandomWords(int numberToHide){
            
            Random rnd = new Random();
            int index = rnd.Next(_words.Count); 
            string hiddenWord = "";
            string words = "";
            

            foreach(var word in _words){
                                
                if (word == _words[index]){
                    
                    for( int i = 0; i < word.GetDisplayString().Length; i++){
                        
                        hiddenWord += "_";      
                    }

                    words += $"{hiddenWord} ";
                    hiddenWord ="";
                }

                else{

                    words += $"{word.GetDisplayString().ToString()} ";    
                    
                }
                
            }
            

            Console.WriteLine($"{_reference.GetDisplayText()} {words}");
    }
    public string GetDisplayText(){
                
        return $"{_reference.GetDisplayText()}: {_text}";
    }

    public bool IsCompletelyHidden(){
        return _is;
    }

}
