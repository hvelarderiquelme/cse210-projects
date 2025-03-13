//Class Journal
using System.Reflection.Metadata.Ecma335;

public class Journal
{
    public static List<string> _entries = new List<string>();

    public void AddEntry(string _entry)
    {
        _entries.Add(_entry);
         
    }// end of AddEntry method

    public void DisplayJournal()
    {
        Console.WriteLine("These are your entries:");
         foreach(string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }// end of DisplayJournal method

    public void SaveJournal()
    {
        Console.WriteLine("you have chosen option 3.");

    }// end of SaveJournal method

    public void LoadJournal()
    {
        Console.WriteLine("you have chosen option 4.");

    }// end of LoadJournal method


}// end of class definition