namespace Develop03
{
    class Word
    {

       private string _Word;
       private bool _Invisible;

        public Word(string word)
        {
            _Word = word;
            _Invisible = false;
        }
        public void SetWord(string word)
        {
            _Word = word;
        }
        public string GetWord()
        {
            return _Word;
        }
        public void SetInvisible(bool invisible)
        {
            _Invisible = invisible;
        }
        public bool GetInvisible()
        {

            return _Invisible;

        }
    }






}