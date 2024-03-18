using BonhommePendu.Events;
using BonhommePendu.Models;

namespace BonhommePendu.Services
{
    public class PenduService
    {
        private GameData _gameData { get; set; }

        public GameData JoinGame()
        {
            if(_gameData == null)
                _gameData = new GameData("premier");
            return _gameData;
        }

        public GameEvent GuessLetter(char letter)
        {
            return new GuessEvent(_gameData, letter);
        }
    }
}
