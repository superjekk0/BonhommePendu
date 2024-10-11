using BonhommePendu.Models;

namespace BonhommePendu.Events
{
    // Un événement à créer chaque fois qu'un utilisateur essai une "nouvelle" lettre
    public class GuessEvent : GameEvent
    {
        // TODO: Compléter
        public char Letter { get; set; }
        public GuessEvent(GameData gameData, char letter) :base() {
            // TODO: Commencez par ICI
            Events.Add(new GuessedLetterEvent(gameData, letter));
            Letter = letter;
        }
    }
}
