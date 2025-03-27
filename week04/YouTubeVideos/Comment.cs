//Class Comment
public class Comment{

//Attributes
    private string _name;
    private string _comment;

    //Constructor
    public Comment(string name, string comment){
        _name = name;
        _comment = comment;
    }

    //Methods
    public string GetComments(){
        string nameComment = $"{_name} {_comment}";
        return nameComment;

    }
    
}//end of class declaration