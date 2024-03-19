using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class LoseEvent : GameEvent
    {
        public string Word { get; set; }

        public LoseEvent(GameData gameData) {
            gameData.Lost = true;
            Word = gameData.Word;
        }
    }
}
