namespace BonhommePendu.Events
{
    public class RevealLetter : GameEvent
    {
        public char Letter { get; set; }
        public int Index { get; set; }

        public RevealLetter(char letter, int index)
        {
            Letter = letter;
            Index = index;
        }
    }
}
