// Class Video
//Attributes
using System.Transactions;

public class Video{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }

    //Methods
    public int NumberOfComments(){
        return 3;
    }

}//end of class declaration