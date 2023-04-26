using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int favorite_number = PromptUserNumber();
        int squared = SquareNumber(favorite_number);
        DisplayResult(squared,username);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(int number, string person)
    {
        Console.WriteLine($"{person}, the square of your number is {number}");
    }


}   

