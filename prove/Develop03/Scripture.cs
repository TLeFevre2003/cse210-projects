using System;
using System.Collections;
namespace Develop03
{
    class Scripture
    {
        Random randomGenerator = new Random();
        private string _displayString;
        private Verse _verse;
        private int _wordsInvisable = 0;

        public Scripture(string reference, string scripture)
        {

            _verse = new Verse(reference,scripture);




        }
        public bool MakeInvisible()
        {
            if (_wordsInvisable != _verse.GetWords().Count)
            {
                bool MakeInvis = true;
            
                while (MakeInvis)
                {
                
                
                    int randomRumber = randomGenerator.Next(0, _verse.GetWords().Count);
                    
                    Word word = _verse.GetWords()[randomRumber];
                    if (word.GetInvisible() == false)
                    {
                        _wordsInvisable +=1;
                        word.SetInvisible(true);
                        MakeInvis = false;
                        if (_wordsInvisable != _verse.GetWords().Count)
                        {
                            return true;
                        }
                    }
                
                }
            }
            
            
            return false;
            
        



        }
        public bool MakeVisible()
        {
            if (_wordsInvisable > 0)
            {
                bool makeVisible = true;

                while (makeVisible)
                {
                    int randomIndex = randomGenerator.Next(0, _verse.GetWords().Count);

                    Word word = _verse.GetWords()[randomIndex];
                    if (word.GetInvisible())
                    {
                        word.SetInvisible(false);
                        _wordsInvisable --;
                        makeVisible = false;
                        return true;
                    }
                }
        }

    return false;
}

        public void DisplayScripture()
        {
            _displayString = "";
            foreach (Word word in _verse.GetWords())
            {
                if (!word.GetInvisible())
                {
                    _displayString += word.GetWord();
                    
                    
                }
                else
                {
                    foreach (char Char in word.GetWord())
                    {
                        _displayString += "_";

                    }
                                     
                }
                _displayString += " ";
            }
            Console.WriteLine($"{_verse.GetReferenceString()} {_displayString}");
        }



    }
}