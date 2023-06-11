using System;
using System.Threading;
using System.Collections.Generic;
namespace Develop04
{
    class Reflection : Activity
    {
        private List<string> _reflectionPrompts;
        private List<string> _reflectionQuestions;
        private Random random = new Random();
        private int _randomNumber;
        public Reflection () : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _reflectionPrompts = new List<string>();
            _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
            _reflectionPrompts.Add("Think of a time when you did something really difficult.");
            _reflectionPrompts.Add("Think of a time when you helped someone in need.");
            _reflectionPrompts.Add("Think of a time when you did something truly selfless.");

            _reflectionQuestions = new List<string>();
            _reflectionQuestions.Add("Why was this experience meaningful to you?");
            _reflectionQuestions.Add("Have you ever done anything like this before?");
            _reflectionQuestions.Add("How did you get started?");
            _reflectionQuestions.Add("How did you feel when it was complete?");
            _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
            _reflectionQuestions.Add("What is your favorite thing about this experience?");
            _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
            _reflectionQuestions.Add("What did you learn about yourself through this experience?");
            _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
            



        }
        public void ReflectionActivity()
        {
            base.DisplayStart();
            base.AskTimer();
            Console.Clear();
            Console.WriteLine("Get ready...");
            base.WaitAnimation();
            Console.WriteLine("");

            Console.WriteLine("Consider the Following Prompt: ");
            Console.WriteLine("");
            _randomNumber = random.Next(0, _reflectionPrompts.Count);
            Console.WriteLine($"--- {_reflectionPrompts[_randomNumber]} ---");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: 5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Clear();
            base.StartTimer();

            while (base.CheckTimer())
            {
                GetQuestion();
            }
            Console.WriteLine("");
            base.DisplayEnd();


        }
        public void GetQuestion()
        {
            _randomNumber = random.Next(0, _reflectionQuestions.Count);
            Console.Write($"> {_reflectionQuestions[_randomNumber]} ");
            WaitAnimation();
            Console.WriteLine();
        }


    }
   



    






}