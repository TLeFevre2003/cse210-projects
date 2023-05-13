using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryption = new Dictionary<char,char>()
            {
                {'A','B'},
                {'B','C'},
                {'C','D'},
                {'D','E'},
                {'E','F'},
                {'F','G'},
                {'G','H'},
                {'H','I'},
                {'I','J'},
                {'J','K'},
                {'K','L'},
                {'L','M'},
                {'M','N'},
                {'N','O'},
                {'O','P'},
                {'P','Q'},
                {'Q','R'},
                {'R','S'},
                {'S','T'},
                {'T','U'},
                {'U','V'},
                {'V','W'},
                {'W','X'},
                {'X','Y'},
                {'Y','Z'},
                {'Z','A'},
                {'a','b'},
                {'b','c'},
                {'c','d'},
                {'d','e'},
                {'e','f'},
                {'f','g'},
                {'g','h'},
                {'h','i'},
                {'i','j'},
                {'j','k'},
                {'k','l'},
                {'l','m'},
                {'m','n'},
                {'n','o'},
                {'o','p'},
                {'p','q'},
                {'q','r'},
                {'r','s'},
                {'s','t'},
                {'t','u'},
                {'u','v'},
                {'v','w'},
                {'w','x'},
                {'x','y'},
                {'y','z'},
                {'z','a'},
                {'0','1'},
                {'1','2'},
                {'2','3'},
                {'3','4'},
                {'4','5'},
                {'5','6'},
                {'6','7'},
                {'7','8'},
                {'8','9'},
                {'9','0'},
                {'/','.'},
                {'.','!'},
                {'!','?'},
                {'?',':'},
                {':',';'},
                {';','/'}
            };

            var decryption = new Dictionary<char,char>()
            {
                {'A','Z'},
                {'B','A'},
                {'C','B'},
                {'D','C'},
                {'E','D'},
                {'F','E'},
                {'G','F'},
                {'H','G'},
                {'I','H'},
                {'J','I'},
                {'K','J'},
                {'L','K'},
                {'M','L'},
                {'N','M'},
                {'O','N'},
                {'P','O'},
                {'Q','P'},
                {'R','Q'},
                {'S','R'},
                {'T','S'},
                {'U','T'},
                {'V','U'},
                {'W','V'},
                {'X','W'},
                {'Y','X'},
                {'Z','Y'},
                {'a','z'},
                {'b','a'},
                {'c','b'},
                {'d','c'},
                {'e','d'},
                {'f','e'},
                {'g','f'},
                {'h','g'},
                {'i','h'},
                {'j','i'},
                {'k','j'},
                {'l','k'},
                {'m','l'},
                {'n','m'},
                {'o','n'},
                {'p','o'},
                {'q','p'},
                {'r','q'},
                {'s','r'},
                {'t','s'},
                {'u','t'},
                {'v','u'},
                {'w','v'},
                {'x','w'},
                {'y','x'},
                {'z','y'},
                {'1','0'},
                {'2','1'},
                {'3','2'},
                {'4','3'},
                {'5','4'},
                {'6','5'},
                {'7','6'},
                {'8','7'},
                {'9','8'},
                {'0','9'},
                {'.','/'},
                {'!','.'},
                {'?','!'},
                {':','?'},
                {';',':'},
                {'/',';'}
            };

            Console.WriteLine("Welcome to the Journal Program!");
            Prompts myPrompts = new Prompts();
            bool running = true;
            string input;
            string prompt;
            Journal journal = new Journal();



            while (running==true)
            {

            Console.WriteLine($"Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            input = Console.ReadLine();

            if (input == "1")
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                prompt = myPrompts.GetRandomPrompts();
                Console.WriteLine(prompt);
                Console.Write("> ");
                input = Console.ReadLine();
                Entry myEntry = new Entry();
                myEntry.Hold(prompt,input,date);
                journal.AddEntry(myEntry);
            } else if (input == "5")
            {
                running = false;
            } else if (input == "2")
            {
                List<Entry> entries = journal.GetAllEntries();

                foreach (Entry entry in entries)
                {
                    string message = entry.ConvertToString();
                    Console.WriteLine(message);
                } 
            } else if (input == "3")
            {
                Console.WriteLine("What file would you like to read from?");
                input = Console.ReadLine();

                if (File.Exists(input)) {
                    // Store each line in array of strings
                    string[] lines = File.ReadAllLines(input);
                    int numberOfLines = lines.Length;

                    for (int x=0; x<numberOfLines; x+=3)
                    {
                        Entry newEntry = new Entry();
                        newEntry.Hold(EncryptString(lines[x+1],decryption),EncryptString(lines[x+2],decryption),EncryptString(lines[x],decryption));
                        journal.AddEntry(newEntry);
                    }
                    }
            } else if (input == "4")
            {
                string message = "";
                
                List<Entry> entries = journal.GetAllEntries();

                foreach (Entry entry in entries)
                {
 
                    
                    message += EncryptString(entry.ConvertToString(),encryption);
                    
                    
                    //Console.WriteLine(message);
                } 
                Console.WriteLine("What file would you like to write to?");
                input = Console.ReadLine();

                //string all_entries = journal.GetAllEntries();
                
                File.WriteAllText(input, message);
            }




            }

        }
        static public char ConvertChar(char c, Dictionary<char,char> encript)
        {


            if (encript.ContainsKey(c))
            {
                return encript[c];
            } else
            {
                return c;
            }



            
        }
        static public string EncryptString(string encriptMe, Dictionary<char,char> dict)
        {
            string encrypted = "";
            char character = ' ';
            foreach (char a in encriptMe)
            {
                character = ConvertChar(a,dict);
                encrypted += character;
            }

            return encrypted;
        }
    }
}