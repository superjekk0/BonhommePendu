namespace BonhommePendu.Models
{
    public class GameData
    {
        public GameData(string word)
        {
            Word = word;
            NbLetters = word.Length;
            nbLives = 5;
        }

        public bool HasLetterAtIndex(char letter, int index)
        {
            return Word[index] == letter;
        }

        private string Word;
        public int NbLetters;
        public int nbLives;
    }
}
