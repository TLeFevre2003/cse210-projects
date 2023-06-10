using System;
namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment newAssignment = new Assignment("Samuel Bennett","Multiplication");
            Console.WriteLine(newAssignment.GetSummary());

            MathAssignment newMath = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
            Console.WriteLine(newMath.GetSummary());
            Console.WriteLine(newMath.GetHomeworkList());
            
            WritingAssignment newWriting = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
            Console.WriteLine(newWriting.GetSummary());
            Console.WriteLine(newWriting.GetWritingInformation());
        }
    }
}