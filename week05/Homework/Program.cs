using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new("Pablo Neruda", "Poems");
        MathAssignment mathassignment1 = new("Horacio Velarde", "Integration", "4.5", "7-21");
        WritingAssignment writingassignment1 = new ("Raul Riquelme", "Interfaces", "Interface models");
        Console.WriteLine($"Assignment Information: \n{assignment1.GetSummary()}");
        Console.WriteLine($"Math Assignment Information: \n{mathassignment1.GetSummary()}");
        Console.WriteLine($"{mathassignment1.GetHomeworkList()}");
        Console.WriteLine($"Writing assigment information:\n{writingassignment1.GetWritingInformation()}");

    }
}