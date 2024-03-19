using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class LoseEvent : GameEvent
    {
        public string Word;

        public LoseEvent(GameData gameData) {
            gameData.Lost = true;
            Word = gameData.Word;
        }
    }
}
