using BonhommePendu.Events;
using BonhommePendu.Models;
using BonhommePendu.Services;
using Microsoft.AspNetCore.Mvc;

namespace BonhommePendu.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PenduController : ControllerBase
    {
        private static readonly string[] Words = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        GameData? GameData { get; set; }

        private PenduService _penduService;

        public PenduController(PenduService penduService)
        {
            _penduService = penduService;
        }

        public GameData JoinGame()
        {
            return _penduService.JoinGame();
        }

        public GameEvent GuessLetter(string letter)
        {
            return _penduService.GuessLetter(letter);
        }
    }
}