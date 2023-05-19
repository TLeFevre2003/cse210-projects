
using System.Collections.Generic;

namespace Develop03

{
    class Verse
    {

        private List<Word> _words;
        private Reference _reference;

        public Verse (string reference, string scripture)
        {

            _words = new List<Word>();
            string[] wordArray = scripture.Split(' ');

            foreach (string word in wordArray)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
            }

            _reference = new Reference(reference);
            


        }
        public void AddWord(Word word)
        {
            _words.Add(word);


        }
        public List<Word> GetWords()
        {
            return _words;
        }
        public string GetReferenceString()
        {
            return _reference.GetReference();
        }
    }








}