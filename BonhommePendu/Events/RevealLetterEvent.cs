using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class RevealLetterEvent : GameEvent
    {
        public char Letter { get; set; }
        public int Index { get; set; }

        public RevealLetterEvent(GameData gameData, char letter, int index)
        {
            Letter = letter;
            Index = index;
            gameData.RevealLetter(letter, index);
            if(gameData.HasGuessedTheWord)
            {
                Events = new List<GameEvent>
                {
                    new WinEvent(gameData)
                };
            }
        }
    }
}
