using System;

class Program
{
    static void Main(string[] args)
    {
      string option;
      int numOption = 1;
      

      while(numOption >= 1 && numOption <= 4){
        Console.WriteLine("Menu Options:\n");
        Console.WriteLine("\t1.- Start breathing activity");
        Console.WriteLine("\t2.- Start reflecting activity");
        Console.WriteLine("\t3.- Start listing activity");
        Console.WriteLine("\t4.- Quit"); 
        Console.Write("Select a choice from the menu: ");
        option = Console.ReadLine();
        numOption = int.Parse(option);
      }


    }//main method
}//class program