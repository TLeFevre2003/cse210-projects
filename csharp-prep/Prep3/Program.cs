using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? "); 
        //string answer = Console.ReadLine();

        //int magic_number = int.Parse(answer);
        int guess;
        Random randomGenerator = new Random();
        //int magic_number = randomGenerator.Next(1, 100);
        string answer;
        int total_guesses = 0;
        bool play_again = true;
        
        while (play_again == true)
            


        {
            total_guesses = 0;
            int magic_number = randomGenerator.Next(1, 100);
            do
            {
            Console.Write("What is your guess? "); 
            answer = Console.ReadLine();
            guess = int.Parse(answer);
            total_guesses +=1;

            if (guess>magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess< magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic_number)
            {
                Console.WriteLine($"You got it in {total_guesses} guesses");
            }
            
            } while (magic_number != guess);
        Console.Write("Do you want to play again? (y/n)");
        answer = Console.ReadLine();
        if (answer == "n")
        {
            play_again = false;
        }
        }

    }
}