using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        string inputNumber;
        double sum = 0;
        double average;        
        double largest = 0;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("enter number: ");
            inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);
            numbers.Add(number);
            
                       
        } while (number != 0);
        
        foreach (int value in numbers)
        {
                sum += value;
        }

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (largest < numbers[i])
            {
                largest = numbers[i];
            }
            
        }
        average = sum/(numbers.Count - 1);
        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}