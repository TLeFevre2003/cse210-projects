using System;
using System.Threading;
using System.Collections.Generic;

namespace Develop04{

    class Listing : Activity
    {

        private List<string> _prompts;
        private Random random = new Random();
        private int _randomNumber;
        private int _items;

        public Listing () : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>();
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }
        public void ListingActivity()
        {
            _items = 0;
            base.DisplayStart();
            base.AskTimer();
            Console.Clear();
            Console.WriteLine("Get ready");
            base.WaitAnimation();
            Console.WriteLine("");
            Console.WriteLine("List as many responses you can to the following prompt: ");
            _randomNumber = random.Next(0, _prompts.Count);
            Console.WriteLine($"--- {_prompts[_randomNumber]} ---");
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
            base.StartTimer();
            Console.WriteLine("");

            while (base.CheckTimer())
            {
                WriteAnswers();

            }
            Console.WriteLine($"You listed {_items} items!");
            Console.WriteLine("");
            base.DisplayEnd();



        }
        public void WriteAnswers()
        {
            Console.Write("> ");
            Console.ReadLine();
            _items+=1;
        }


    }









}