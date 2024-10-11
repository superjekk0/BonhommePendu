using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer peu importe si la lettre est dans le mot ou pas!
    public class GuessedLetterEvent : GameEvent
    {
        // TODO: Compléter
        public GuessedLetterEvent(GameData gameData, char letter)
        {
            if (!gameData.GuessedLetters.Contains(letter))
            {
                gameData.GuessedLetters.Add(letter);
            }
        }
    }
}
