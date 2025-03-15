//Class Journal
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.IO;

public class Journal
{
    public static List<string> _entries = new List<string>();
    DateTime currentDateTime = DateTime.Now;
    string entryEnteredOn;
    public void AddEntry(string _prompt, string _entry)
    {
        entryEnteredOn = currentDateTime.ToString();
        
        string completeEntry =  entryEnteredOn + ". Prompt: " + _prompt + " Your entry: " + _entry;
        _entries.Add(completeEntry);
         
    }// end of AddEntry method

    public void DisplayJournal()
    {
        Console.WriteLine();
        Console.WriteLine("********************************************************");
        Console.WriteLine("These are your entries:");
        foreach(string entry in _entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine("********************************************************");
    }// end of DisplayJournal method

    public void SaveJournal()
    {
        string filename;
        
        Console.Write("Please enter the name of the file: ");
        filename = Console.ReadLine();
       
        /*Writes in filename*/
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
             Console.WriteLine($"Saving your journal...");
            foreach(string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }            
        }

    }// end of SaveJournal method
    public void LoadJournal()
    {
        string filename;
        Console.Write("Please enter the name of the file to load: ");
        filename = Console.ReadLine();
        string[] entries = System.IO.File.ReadAllLines(filename);
    
        foreach (string entry in entries)
        {
            _entries.Add(entry);
        }

    }// end of LoadJournal method


}// end of class definition