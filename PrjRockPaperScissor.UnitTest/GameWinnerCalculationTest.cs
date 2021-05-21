using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrjRockPaperScissor.Interfaces;
using Xunit.Sdk;

namespace PrjRockPaperScissor.UnitTest
{
    [TestClass]
    public class GameWinnerCalculationTest
    {
        private readonly IGameWinnerCalculationInterface gameWinner;
            public GameWinnerCalculationTest()
        {
            gameWinner = new GameWinnerCalculation();
        }
        [TestMethod]
        public void GameWinnerCalculation_Rock_Paper_Test()
        {
            var result = gameWinner.CalculateGameWinner("ROCK", "PAPER", 1, 2);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GameWinnerCalculation_Rock_Scissor_Test()
        {
            var result = gameWinner.CalculateGameWinner("ROCK", "SCISSOR", 2, 1);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GameWinnerCalculation_Paper_Scissor_Test()
        {
            var result = gameWinner.CalculateGameWinner("PAPER", "SCISSOR", 1, 2);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GameWinnerCalculation_Paper_Paper_Test()
        {
            var result = gameWinner.CalculateGameWinner("PAPER", "PAPER", 1, 2);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GameWinnerCalculation_Paper_Rocks_Test()
        {
            var result = gameWinner.CalculateGameWinner("PAPER", "ROCKS", 1, 2);
            Assert.IsNotNull(result);
        }
    }
}
