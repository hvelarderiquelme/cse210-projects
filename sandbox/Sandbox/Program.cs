using System;
using System.Runtime.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    //    Person p1 = new Person();
    //    p1._firstName = "Mary";
    //    p1._lastName = "Smith";
    //    p1._age = 25;

    //    Person p2 = new Person();
    //    p2._firstName = "John";
    //    p2._lastName = "Watkins";
    //    p2._age = 30;

    //    List<Person> people = new List<Person>();

    //    people.Add(p1);
    //    people.Add(p2);

    //    foreach(Person p in people)
    //    {
    //         Console.WriteLine(p._firstName);
    //    }

    //    SaveToFile(people);
    //    List<Person> people = ReadFromFile();
       
    //    foreach (Person p in people)
    //    {
    //         Console.WriteLine(p._lastName);
    //    }

    // }

    // public static void SaveToFile(List<Person> people)
    // {
    //     Console.WriteLine("Saving File...");
    //     string filename = "people.txt";

    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach (Person p in people)
    //         {
    //             outputFile.WriteLine($"{p._firstName} {p._lastName} {p._age}");
    //         }   
    //     }
    // }

    // public static List<Person> ReadFromFile()
    // {
    //    Console.WriteLine("Reading list from file...");
    //    List<Person> people = new List<Person>();
    //     string filename = "people.txt";

    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         Console.WriteLine(line);
    //         people.Add(int.Parse(line));
    //     }

        
    //     return people;

    //********************Text Animation**************************
    // Console.WriteLine("going to sleep for four seconds...");
    // for(int i = 1; i<=4;i++){
    //     Thread.Sleep(1000);
    //     Console.Write($"{i} \b\b");
    // }

    //Console.WriteLine(" bye");

    // string[] animation={"-"," "};
    // for(int i =1; i<= 10; i++){
    //     foreach(var character in animation){
    //          Thread.Sleep(1000);
    //          Console.Write($"{character} \b\b");
    //     }
    // }
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(15);
    string[] animation={"-","\\","|","/","-","\\","|","/"};
    int i = 0;

    while (DateTime.Now < endTime){
        
         Console.Write($"{animation[i]} ");
         Thread.Sleep(1000);
         Console.Write($"\b\b");
         i++;
        
        if(i >= animation.Count()){
            i=0;
        } 
    
    }

    }
}