// Class PromptGenerator for the Journal project
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


public class PromptGenerator
{
    List<string> _prompts = new List<string>();
    public string _entry = "";
    Journal journal = new Journal();
    //Chooses the prompt randomly
    public void Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);

        Console.WriteLine(_prompts[index]);
        _entry = Console.ReadLine();
        journal.AddEntry(_entry);
        
    }//end Prompt method
}//end class declaration