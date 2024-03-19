using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class GuessedLetterEvent : GameEvent
    {
        public char Letter { get; set; }

        public GuessedLetterEvent(GameData gameData, char letter)
        {
            Letter = letter;
            gameData.GuessedLetters.Add(Letter);
        }
    }
}
