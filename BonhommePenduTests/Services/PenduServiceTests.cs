using Microsoft.VisualStudio.TestTools.UnitTesting;
using BonhommePendu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonhommePendu.Models;
using BonhommePendu.Events;

namespace BonhommePendu.Services.Tests
{
    [TestClass()]
    public class PenduServiceTests
    {
        [TestMethod()]
        public void GuessLetterTest()
        {
            PenduService pendu = new PenduService();

            GameData gameData = pendu.StartGame("test");

            GameEvent gameEvent = pendu.GuessLetter('n');

            Assert.IsNotNull(gameEvent);
            Assert.AreEqual(1, gameEvent.Events.Count);
        }
    }
}