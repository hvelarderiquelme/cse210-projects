//Class Wtriting Assigment, derived from Assigment
public class WritingAssignment: Assignment{

    private string _title="";

    //constructor
    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic){
            _title = title;
    }
    //methods
    public string GetWritingInformation(){
        return $"Name: {GetStudentName()} Title: {_title}";
    }
}// end of class declaration