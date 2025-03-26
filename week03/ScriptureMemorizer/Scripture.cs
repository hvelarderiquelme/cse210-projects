//Scripture class
using System.Security.Principal;

public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;//not for use just to finish method declaration
    private bool _is;//not for use just to finish method declaration
    //private List<int> _indexes = new List<int>();

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
    public void HideRandomWords(int numberToHide){
            
            Random rnd = new Random();
            int index;
            
            for(int i=0; i<3;i++){
                index = rnd.Next(0,_words.Count);
                Console.WriteLine(index);
                _words[index].Hide();
                _words[24].Show();
            }
            
            // if (!_indexes.Contains(index)){
            //     _indexes.Add(index);
            // }
            // foreach(var Index in _indexes){
            //     Console.WriteLine(Index);
            // }
            
            //if(_indexes.Contains(index)){
                //foreach(var word in _words){

                    //if ((word == _words[index]) && (word.IsHidden() == false)){
                           
                       
        
                    //}

                    //else{
                        
                       
                        
                    //}
                
                
                //}
            //}

            Console.WriteLine();
            
    }
    public string GetDisplayText(){
        string strScripture = "";
         foreach(var word in _words){
            strScripture += _words.ToString();
         }       
        return $"{_reference.GetDisplayText()}: {_text}";

    }

    public bool IsCompletelyHidden(){
        return _is;
    }

}
