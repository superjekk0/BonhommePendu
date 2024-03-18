using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class GuessEvent : GameEvent
    {
        public GuessEvent(GameData gameData, char letter) {
            bool foundOneLetter = false;
            for(int i = 0; i < gameData.NbLetters; i++)
            {
                if(gameData.HasLetterAtIndex(letter, i))
                {
                    foundOneLetter = true;
                    Events.Add(new RevealLetter(letter, i));
                }
            }
            if(!foundOneLetter)
            {
                Events.Add(new LoseLifeEvent());
            }
        }
    }
}
