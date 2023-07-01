using System;
using System.Collections.Generic;
using System.IO;
namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string description;
            int pointsReward;
            int completions;
            int bonus;

            Checklist mySimple = new Checklist("name","description",100,10,10,100);
            Console.WriteLine(mySimple.GetRepresentation());
            string userInput;
            List<Goal> goals = new List<Goal>();
            bool Running = true;
            int points = 0;

            while (Running)
            {

                DisplayMainMenu(points);
                userInput = Console.ReadLine();


                if (userInput == "1")
                {
                    DisplayGoalCreationMenu();

                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        pointsReward = Int32.Parse(Console.ReadLine());
                        goals.Add(new Simple(name,description,pointsReward,false));

                    }
                    else if (userInput == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        pointsReward = Int32.Parse(Console.ReadLine());
                        goals.Add(new Eternal(name,description,pointsReward));
                    }
                    else if (userInput == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        pointsReward = Int32.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        completions = Int32.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        bonus = Int32.Parse(Console.ReadLine());
                        
                        goals.Add(new Checklist(name,description,pointsReward,0,completions,bonus));
                    }
                }
                else if (userInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    int goalNumber = 1;
                    foreach (Goal goal in goals)
                    {
                        
                        Console.WriteLine($"{goalNumber}. {goal.Display()}");
                        
                        goalNumber++;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else if (userInput == "3")
                {
                    Console.Clear();
                    Console.Write("What file would you like to save to? ");
                    userInput = Console.ReadLine();

                    string fileText = $"{points}\n";
                    foreach (Goal goal in goals)
                    {
                        fileText += $"{goal.GetRepresentation()}\n";
                    }
                    File.WriteAllText(userInput, fileText);

                }
                else if (userInput =="4")
                {
                    Console.Clear();
                    Console.Write("What file do you want to load from? ");
                    string file = Console.ReadLine();


                    if (File.Exists(file)) 
                    {
                        // Store each line in array of strings
                        string[] lines = File.ReadAllLines(file);
                        int numberOfLines = lines.Length;
                        points = Int32.Parse(lines[0]);
                        for (int x=1; x<numberOfLines; x+=1)
                        {
                            string[] data = lines[x].Split('-');
                            string goalType = data[0];
                            if (goalType == "Simple")
                            {
                                goals.Add(new Simple(data[1],data[2],Int32.Parse(data[3]),bool.Parse(data[4])));
                            }
                            else if (goalType == "Eternal")
                            {
                                goals.Add(new Eternal(data[1],data[2],Int32.Parse(data[3])));
                            }
                            else if (goalType == "Checklist")
                            {
                                goals.Add(new Checklist(data[1],data[2],Int32.Parse(data[3]),Int32.Parse(data[4]),Int32.Parse(data[5]),Int32.Parse(data[6])));
                            }
                        }
                    }


                }
                else if (userInput == "5")
                {
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    int goalNumber = 1;
                    foreach (Goal goal in goals)
                    {
                        
                        Console.WriteLine($"{goalNumber}. {goal.Display()}");
                        
                        goalNumber++;
                    }
                    Console.WriteLine("");
                    Console.Write("Which goal did you accomplish? ");
                    int index = Int32.Parse(Console.ReadLine())-1;
                    
                    points += goals[index].GetPoints();


                }
                else if (userInput == "6")
                {
                    Running = false;
                }



            }

        }
        static void DisplayMainMenu(int points)
        {
                Console.Clear();
                Console.WriteLine($"You have {points} points.");
                Console.WriteLine("");
                Console.WriteLine("Menu options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
        }
        static void DisplayGoalCreationMenu()
        {
            Console.Clear();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of Goal would you like to create? ");
        }
    }
}