using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        int squareNumber;
        
        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        squareNumber = PromptSquareNumber(userNumber);
        DisplayResult(userName, squareNumber);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the program!");
    }

    static string PromptUserName()
    {
        string name;
        Console.Write($"Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        int numUserNumber;
        string strUserNumber;
        
        Console.Write($"Please enter your favourite number: ");
        strUserNumber = Console.ReadLine();
        numUserNumber = int.Parse(strUserNumber);
        return numUserNumber;
    }
    static int PromptSquareNumber(int sqrNum)
    {
        int square;
        square = sqrNum * sqrNum;
        return square;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is: {squareNumber}");
    }
}