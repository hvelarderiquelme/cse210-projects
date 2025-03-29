//Scripture class
using System.Runtime.Versioning;
using System.Security.Principal;

public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;
    private bool _is;
    private bool _completelyHidden = false;
    private int counter;
    //class constructor
    public Scripture(Reference reference, string text){
       
        _reference = reference;
        _text = text;
        string[] words = text.Split();
        for(int i=0;i<words.Length;i++){
            _words.Add(new Word(words[i], false));
        }

    }
    //Class methods
    public void HideRandomWords(){
            
            Random rndWordsQuantity = new Random();
            int WordsQuantity = rndWordsQuantity.Next(1,_words.Count/3+1);
            Random rnd = new Random();
            int index;
            string displayScripture="";
            
            for(int i=0; i<= WordsQuantity; i++){
                foreach(var word in _words){
                    index = rnd.Next(_words.Count);
                        if(word == _words[index]){
                            if(word.IsHidden() == false){
                                word.Hide();
                            }
                            else{
                                word.Show();
                            }    
                        }
                        else{
                            word.Show();
                        }
                }
            }
            Console.WriteLine();

            foreach(var word in _words){
                displayScripture += word.GetDisplayString();
                 
            }
            Console.Write($"{_reference.GetDisplayText()} {displayScripture}");   
            Console.WriteLine();
            
                              
    }
    public string GetDisplayText(){
        
        return $"{_reference.GetDisplayText()}: {_text}";

    }

    public bool IsCompletelyHidden(){
        bool hidden;
        counter = 0;
        
        foreach(var word in _words){
            hidden = word.IsHidden();
            if(hidden == true){
                counter+= 1;
            }
        }
        
        if(counter == _words.Count){
            _is = true;
        }
        
        return _is;
    }

}
