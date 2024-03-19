using System.Text.Json.Serialization;

namespace BonhommePendu.Events
{
    [JsonDerivedType(typeof(GuessEvent), typeDiscriminator: "Guess")]
    [JsonDerivedType(typeof(LoseLifeEvent), typeDiscriminator: "LoseLife")]
    [JsonDerivedType(typeof(RevealLetterEvent), typeDiscriminator: "RevealLetter")]
    [JsonDerivedType(typeof(WinEvent), typeDiscriminator: "Win")]
    [JsonDerivedType(typeof(LoseEvent), typeDiscriminator: "Lose")]
    public class GameEvent
    {
        public List<GameEvent> Events { get; set; }
    }
}
