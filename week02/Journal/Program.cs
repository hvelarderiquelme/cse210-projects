using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int choice;
        string strChoice;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        
        //Shows menu and asks what to do
        do{
            Console.WriteLine("Welcome to your journal. These are the menu options:");
            Console.WriteLine($"1-Add entry.");
            Console.WriteLine($"2-Display your journal.");
            Console.WriteLine($"3-Save your journal.");
            Console.WriteLine($"4-Load your journal.");
            Console.WriteLine($"5-Quit.");
            Console.WriteLine($"What would you like to do?");
            Console.Write(">");
            strChoice = Console.ReadLine();
            choice = int.Parse(strChoice);

            if (choice == 1){
                prompt.Prompt();
                
            }  

            if (choice == 2){
                journal.DisplayJournal();            
            }

            if (choice == 3){
                journal.SaveJournal();
            }

            if (choice == 4){
                journal.LoadJournal();
            }
            

        }while (choice < 5);

    }//main function
}//class program