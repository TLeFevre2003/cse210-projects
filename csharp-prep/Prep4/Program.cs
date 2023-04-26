using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int entered = -1;
        string answer;
        List<int> numbers = new List<int>();
        int total = 0;
        int max = 0;
        float average = 0;
        int min_positive_number = 1000;
        while (entered != 0)
        {
            Console.Write("Enter number: ");



            answer = Console.ReadLine();
            entered = int.Parse(answer);

            if (entered != 0)
            {
                numbers.Add(entered);
            }
        }


        foreach (int number in numbers)
        {
            total += number;
            if (number > max)
            {
                max = number;
            }
            if (0 - number < number)
            {
                if (number < min_positive_number)
                {
                    min_positive_number = number;
                }
            }
        }
        average = (float)total / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min_positive_number}");
        numbers.Sort();
        Console.WriteLine("Here is the sorted list");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}