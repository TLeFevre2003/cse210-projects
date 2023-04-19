using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string grade_percentage_string = Console.ReadLine();

        int grade_percentage_int = int.Parse(grade_percentage_string);

        string letter_grade = "";

        int remainder = grade_percentage_int % 10;

        if (grade_percentage_int >= 90)
        {
            letter_grade = "A";
        }
        else if (grade_percentage_int >= 80)
        {
            letter_grade = "B";
        }
        else if (grade_percentage_int >= 70)
        {
            letter_grade = "C";
        }
        else if (grade_percentage_int >= 60)
        {
            letter_grade = "D";
        }
        else if (grade_percentage_int < 60)
        {
            letter_grade = "F";
        }


        if (remainder >= 7 && letter_grade != "A" && letter_grade != "F")
        {
            letter_grade += "+";
        }
        else if (remainder<3 && letter_grade!= "F")
        {
            letter_grade += "-";
        }



        Console.WriteLine($"Your grade is: {letter_grade}");


        if (grade_percentage_int >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (grade_percentage_int < 70)
        {
            Console.WriteLine("You did not pass but you can do it next time!");
        }


    }   
}