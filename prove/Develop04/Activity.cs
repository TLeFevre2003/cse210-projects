using System;
using System.Threading;
namespace Develop04
{
    class Activity
    {
        private string _startingMessage;
        private string _description;
        private string _endMessage;
        private int _seconds;
        private DateTime _startTime;
        private DateTime _futureTime;
        private string _activity;

        public Activity (string activity_type,string description)
        {
   
            _startingMessage = $"Welcome to {activity_type} Activity";
            _endMessage = "Well done!!";
            _description = description;
            _activity = activity_type;


        }
        public void DisplayStart()
        {
            Console.WriteLine(_startingMessage);
            Console.WriteLine("");
            Console.WriteLine(_description);
            Console.WriteLine("");
        }
        public void DisplayEnd()
        {
            Console.WriteLine(_endMessage);
            WaitAnimation();
            Console.WriteLine("");
            Console.WriteLine($"You have completed another {_seconds} seconds of {_activity} Activity.");
            WaitAnimation();
        }
        public void AskTimer ()
        {
            Console.Write("How long, in seconds, would you like your session? ");
            _seconds = int.Parse(Console.ReadLine());
        }
        public void StartTimer ()
        {
            
            _startTime = DateTime.Now;
            _futureTime = _startTime.AddSeconds(_seconds);

        }
        public bool CheckTimer ()
        {
            DateTime currentTime = DateTime.Now;
            return (currentTime < _futureTime);
        }
        public void WaitAnimation()
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");

            
        }


    }












}