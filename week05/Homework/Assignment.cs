// Assignment Class, Base
using System.Runtime.CompilerServices;

public class Assignment{

    private string _studentName="";
    private string _topic="";

    //constructor
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    //methods
    public string GetSummary(){
        return $"Name: {_studentName}, topic: {_topic}";
    }

    public string GetStudentName(){
        return _studentName;
    }

}// end of class declaration