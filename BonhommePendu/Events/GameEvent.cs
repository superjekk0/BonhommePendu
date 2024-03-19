using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    [JsonDerivedType(typeof(GuessEvent), typeDiscriminator: "Guess")]
    [JsonDerivedType(typeof(WrongGuessEvent), typeDiscriminator: "WrongGuess")]
    [JsonDerivedType(typeof(RevealLetterEvent), typeDiscriminator: "RevealLetter")]
    [JsonDerivedType(typeof(WinEvent), typeDiscriminator: "Win")]
    [JsonDerivedType(typeof(LoseEvent), typeDiscriminator: "Lose")]
    [JsonDerivedType(typeof(GuessedLetterEvent), typeDiscriminator: "GuessedLetter")]
    public class GameEvent
    {
        public List<GameEvent>? Events { get; set; }
    }
}
