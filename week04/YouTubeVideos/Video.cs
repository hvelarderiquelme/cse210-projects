// Class Video
//Attributes
using System.Transactions;

public class Video{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    private List<Video> _videos = new List<Video>();

    //Constructor
    public Video(string title, string author, double length, List<Comment> comments){
       
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
       
    }

    //Methods
    public void NumberOfComments(){
        Console.WriteLine($"Video name:{_title}, made by: {_author}, {_length}s long, {_comments.Count} comments:");
        string strComments;
        
        foreach(var comment in _comments){
            strComments = comment.GetComments();
            Console.WriteLine(strComments);
        }
        
        
    }

}//end of class declaration