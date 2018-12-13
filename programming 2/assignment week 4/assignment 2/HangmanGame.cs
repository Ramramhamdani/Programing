namespace Assignment_2
{
    class HangmanGame
    {
        public string secretWord = "";
        public string guessedWord = "";
        public void Init(string secretword)
        {
            secretWord = secretword;
            foreach (char letter in secretword)
            {
                guessedWord = guessedWord + ". ";
            }
        }
        public bool GuessLetter(char letter)
        {
            guessedWord = "";
    
            foreach (char item in secretWord)
            {
                if (item == letter)
                {
                    
                    guessedWord = guessedWord + letter;
                }
                else
                {
                    guessedWord = guessedWord + ". ";
                }
            }
            
            return true;
        }
        public bool isGuessed()
        {
            if (guessedWord==secretWord)
            {
                return true;
            }
            return false;
        }
    }
}
