using System.Text;

namespace BonhommePendu.Models
{
    public class GameData
    {
        public const char DEFAULT_LETTER = '*';
        public const int NB_TRIES = 6;

        private string Word { get; set; }
        private int NbRevealedLetters { get; set; }
        private int NbLetters { get; set; }

        public List<char> GuessedLetters { get; set; }

        public int NbTries { get; set; }
        public bool Won { get; set; }
        public bool Lost { get; set; }
        public string RevealedWord { get; set; }

        public bool HasGuessedTheWord { get { return NbRevealedLetters >= NbLetters; } }

        public GameData(string word)
        {
            Word = word;
            NbLetters = word.Length;
            NbRevealedLetters = 0;
            NbTries = 0;
            RevealedWord = "";
            GuessedLetters = new List<char>();
            for(int i = 0; i < NbLetters; i++)
            {
                RevealedWord += DEFAULT_LETTER;
            }
        }

        public bool HasUnrevealedLetterAtIndex(char letter, int index)
        {
            // Si la lettre n'est pas encore découverte
            return Word[index] == letter && RevealedWord[index] == DEFAULT_LETTER;
        }

        public void RevealLetter(char letter, int index)
        {
            StringBuilder sb = new StringBuilder(RevealedWord);
            sb[index] = letter;
            RevealedWord = sb.ToString();
            NbRevealedLetters++;
        }
    }
}
