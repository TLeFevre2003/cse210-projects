using System;
using System.Threading;
namespace Develop04
{
    class Breathing : Activity
    {
      
        public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {




        }
        public void BreathingActivity()
        {
            base.DisplayStart();
            base.AskTimer();

            Console.Clear();

            Console.WriteLine("Get Ready...");

            base.WaitAnimation();
            Console.WriteLine("");
            Console.WriteLine("");
            base.StartTimer();
            
            while (base.CheckTimer())
            {
                BreathingAnimation();
            }

            base.DisplayEnd();

    


        }
        public void BreathingAnimation()
        {
            Console.Write("Breathe in...4");
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
            Console.WriteLine("\b \b");

            Console.Write("Now breathe out...6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
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
            Console.WriteLine("\b \b");
            Console.WriteLine("");




        }



    }






}