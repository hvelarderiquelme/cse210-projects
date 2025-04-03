using System;

class Program
{
    static void Main(string[] args)
    {
      string option;
      int numOption = 0;
      string name;
      string description;
      List<string> prompts = new List<string>();
      List<string> questions = new List<string>();
      List<string> listOfPrompts = new List<string>();

      prompts.Add("Think of a time when you stood up for someone else.");
      prompts.Add("Think of a time when you did something really difficult.");
      prompts.Add("Think of a time when you helped someone in need.");
      prompts.Add("Think of a time when you did something truly selfless.");

      questions.Add("Why was this experience meaningful to you?");
      questions.Add("Have you ever done anything like this before?");
      questions.Add("How did you get started?");
      questions.Add("What made this time different than other times when you were not as sucessful?");
      questions.Add("What is your favorite thing about this experience?");
      questions.Add("What could you learn from this experience that applies to other situations?");
      questions.Add("What did you learn about yourself through this experience?");
      questions.Add("How can you keep this experience in mind in the future?");

      listOfPrompts.Add("Who are the people that you appreciate?");
      listOfPrompts.Add("What are personal strengths of yours?");
      listOfPrompts.Add("Who are the people that you have helped this week?");
      listOfPrompts.Add("When have you felt the HOly Ghost this month?");
      listOfPrompts.Add("Who are some of your personal heroes?");
    
    

      while(numOption < 4){
        Console.Clear();  
        Console.WriteLine("\nMenu Options:\n");
        Console.WriteLine("\t1.- Start breathing activity");
        Console.WriteLine("\t2.- Start reflecting activity");
        Console.WriteLine("\t3.- Start listing activity");
        Console.WriteLine("\t4.- Quit"); 
        Console.Write("Select a choice from the menu: ");
        option = Console.ReadLine();
        numOption = int.Parse(option);
        
        if(numOption == 1){
            name = "Breathing Activity";
            description = "This activity will help you relax by walking you through breathing exercises. Breathe in for four seconds and breathe out for another four seconds until the time elapses."; 
            Activity activity = new(name,description);
            activity.DisplaygreetingMessage();
            Console.Write($"\nFor how long(in seconds) would you like to do this activity? ");
            int duration = int.Parse(Console.ReadLine());
            BreathingActivity breathingActivity = new(name, description, duration);
            breathingActivity.BreathingExercise();
        }
        else if (numOption == 2){
            name = "Reflecting Activity";
            description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how to use it in other aspects of your life";
            Activity activity = new(name,description);
            activity.DisplaygreetingMessage();
            Console.Write($"\nFor how long(in seconds) would you like to do this activity? ");
            int duration = int.Parse(Console.ReadLine());
            ReflectingActivity reflectingActivity = new ReflectingActivity(name,description,duration,prompts,questions);
            reflectingActivity.ReflectingExercise();    
        }
        else if (numOption == 3){
            name = "Listing Activity";
            description = "This activity will help you reflect on the good things in tuor life by having you list as many things as you can ina certain area for a period of time.";
            Activity activity = new(name,description);
            activity.DisplaygreetingMessage();
            Console.Write($"\nFor how long(in seconds) would you like to do this activity? ");
            int duration = int.Parse(Console.ReadLine());
            ListingActivity listingActivity= new ListingActivity(name,description,duration,listOfPrompts);
            listingActivity.ListingExercise();   
        }

      }


    }//main method
}//class program