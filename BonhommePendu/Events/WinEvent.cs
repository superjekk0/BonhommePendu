using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class WinEvent : GameEvent
    {
        public WinEvent(GameData gameData) {
            gameData.Won = true;
        }
    }
}
