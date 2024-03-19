using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class GuessEvent : GameEvent
    {
        public GuessEvent(GameData gameData, char letter) {
            Events = new List<GameEvent>();

            Events.Add(new GuessedLetterEvent(gameData, letter));

            bool foundOneLetter = false;
            
            for (int i = 0; i < gameData.RevealedWord.Length; i++)
            {
                if(gameData.HasUnrevealedLetterAtIndex(letter, i))
                {
                    foundOneLetter = true;
                    Events.Add(new RevealLetterEvent(gameData, letter, i));
                }
            }
            if(!foundOneLetter)
            {
                Events.Add(new LoseLifeEvent(gameData));
            }
        }
    }
}
