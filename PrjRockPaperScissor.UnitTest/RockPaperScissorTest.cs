using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PrjRockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrjRockPaperScissor.UnitTest
{
    [TestClass]
    public class RockPaperScissorTest
    {
        private readonly IRockPaperScissorInterface rockpaperScissor;
        private readonly Mock<IRandomInterface> mockRandom;
        private readonly Mock<IGameWinnerCalculationInterface> mockGameWinner;
        private readonly Mock<ITournamentWinnerCalculationInterface> mockTournamentWinner;
        public RockPaperScissorTest()
        {
            mockRandom = new Mock<IRandomInterface>();
            mockGameWinner = new Mock<IGameWinnerCalculationInterface>();
            mockTournamentWinner = new Mock<ITournamentWinnerCalculationInterface>();
            rockpaperScissor = new RockPaperScissors(mockRandom.Object, mockGameWinner.Object, mockTournamentWinner.Object);
        }

        [TestMethod]
        public void Gametest()
        {
            var input = new StringReader("ROCK");
            Console.SetIn(input);
            mockTournamentWinner.Setup(r => r.GetTournamentWinner(2, 1)).Returns("User Wins");
            mockGameWinner.Setup(r => r.CalculateGameWinner("ROCK", "PAPER", 2, 1)).Returns(Tuple.Create("User Wins", 2, 1));
            mockRandom.Setup(r => r.GetRandomChoice()).Returns("PAPER");
            var result = this.rockpaperScissor.Game(1);
            Assert.IsTrue(result);
        }
    }
}
