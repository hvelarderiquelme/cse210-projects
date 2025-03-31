//Class MathAssignment, derived from Assignment
public class MathAssignment: Assignment{
    private string _textBookSection="";
    private string _problems="";
    //constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problems): base(studentName,topic){
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"Section: {_textBookSection}, problems: {_problems}";
    }
}// end of class declaration