using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        string inputNumber;
        int sum = 0;
        int i = 0;
        float average;

        do
        {
            Console.Write("enter number: ");
            inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);
            sum = sum + number;
            i = i + 1;
            
        } while (number != 0);
        
        average = sum/(i-1);

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");

    }
}