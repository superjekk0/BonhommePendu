using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    public class LoseLifeEvent : GameEvent
    {
        public LoseLifeEvent(GameData gameData) {
            gameData.NbTries++;
            if(gameData.NbTries >= GameData.NB_TRIES)
            {
                this.Events = new List<GameEvent>
                {
                    new LoseEvent(gameData)
                };
            }
        }
    }
}
