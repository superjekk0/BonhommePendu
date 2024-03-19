using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class LoseEvent : GameEvent
    {
        public LoseEvent(GameData gameData) {
            gameData.Lost = true;
        }
    }
}
