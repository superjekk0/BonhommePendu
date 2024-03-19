using BonhommePendu.Events;
using BonhommePendu.Models;
using System.Net;

namespace BonhommePendu.Services
{
    public class PenduService
    {
        private GameData _gameData { get; set; }

        public GameData JoinGame()
        {
            if (_gameData != null && !_gameData.Won && !_gameData.Lost)
                return _gameData;
            return null;
        }

        public GameData? StartGame()
        {
            if (_gameData == null || _gameData.Won || _gameData.Lost)
            {
                _gameData = new GameData(GetRandomWord());
                return _gameData;
            }
            return null;
        }

        public GameEvent GuessLetter(char letter)
        {
            return new GuessEvent(_gameData, letter);
        }

        private string GetRandomWord()
        {
            WebClient client = new WebClient();
            string randomWord = client.DownloadString("https://random-word-api.herokuapp.com/word?lang=en&length=10");
            // On se débarasse des charactères au début et à la fin
            return randomWord.Substring(2, 10);
        }
    }
}
