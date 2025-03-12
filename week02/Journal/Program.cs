using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        string strChoice;
        //Shows menu and asks what to do
        
        do{
            Console.WriteLine("Welcome to your journal. These are the menu options:");
            Console.WriteLine($"1-Add entry.");
            Console.WriteLine($"2-Display your journal.");
            Console.WriteLine($"3-Save your journal.");
            Console.WriteLine($"4-Load your journal.");
            Console.WriteLine($"5-Quit.");
            Console.WriteLine($"What would youlike to do?");
            strChoice = Console.ReadLine();
            choice = int.Parse(strChoice);

            if (choice == 1){
                PromptGenerator prompt = new PromptGenerator();
                prompt.prompt();
                Journal add = new Journal();
                add.AddEntry();
            }  

            if (choice == 2){
                Journal display = new Journal();
                display.DisplayJournal();
            }

            if (choice == 3){
                Journal save = new Journal();
                save.SaveJournal();
            }

            if (choice == 4){
                Journal load = new Journal();
                load.LoadJournal();
            }
            

        }while (choice < 5);

        Console.WriteLine($"{choice}");
    }
}