using System;
/*Final version*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the grade (0-100): ");
        string finalGrade = Console.ReadLine();
        int numFinalGrade = int.Parse(finalGrade);
        string letterGrade;

        if (numFinalGrade < 60)
        {
            letterGrade = "F";
        }

        else if (numFinalGrade < 70)
        {
            letterGrade =  "D";
        }

        else if (numFinalGrade < 80)
        {
            letterGrade = "C";
        }

        else if (numFinalGrade < 90)
        {
            letterGrade = "B";
        }

        else
        {
            letterGrade = "A";
        }

        Console.WriteLine($"Your final grade is {letterGrade}");
        
        if (numFinalGrade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed this course");
        }

        else
        {
            Console.WriteLine("We are sorry, but you have failed the course. Keep trying and good luck next time!");
        }
        
    }
}