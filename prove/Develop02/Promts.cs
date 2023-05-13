
using System.Collections.Generic;
using System;
namespace Develop02
{
    public class Prompts
    {
        
        public List<string> prompts;
        public Random random = new Random();

        public Prompts ()
        {

            prompts = new List<string>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("What did I learn today that I didn't know yesterday?");
            prompts.Add("Who did I help today? How did it feel?");
            prompts.Add("What is something I accomplished today that I'm proud of?");
            prompts.Add("What is something I wish I could have done differently today?");
            prompts.Add("What is something that made me laugh today?");
            prompts.Add("What is something I'm grateful for today?");
            prompts.Add("What did I do today to take care of my physical health?");
            prompts.Add("What did I do today to take care of my mental health?");
            prompts.Add("What is something I'm looking forward to tomorrow?");
            prompts.Add("What is a challenge I faced today, and how did I overcome it?");
            prompts.Add("What is a new habit I want to start, and how can I begin?");
            prompts.Add("What is a goal I'm working towards, and what steps did I take today to get closer to it?");
            prompts.Add("What is something that inspired me today?");
            prompts.Add("What is something I did today that pushed me out of my comfort zone?");
            prompts.Add("What is something I can do to improve my relationships with others?");
            prompts.Add("What is something I'm currently struggling with, and how can I work through it?");
            prompts.Add("What is something I'm looking forward to in the future?");
            prompts.Add("What is something I wish someone had told me earlier in life?");
            prompts.Add("What is something I'm curious about right now?");
            prompts.Add("What is something I've been procrastinating on, and how can I start taking action on it?");

        }



        public string GetRandomPrompts()
        {
           int randomNumber = random.Next(0, prompts.Count);

            string prompt = prompts[randomNumber];



            return prompt;

        }


    }












}