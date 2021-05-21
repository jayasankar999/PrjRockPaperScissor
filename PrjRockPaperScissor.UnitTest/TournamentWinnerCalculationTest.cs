using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrjRockPaperScissor.Interfaces;
using Xunit.Sdk;

namespace PrjRockPaperScissor.UnitTest
{
    [TestClass]
    public class TournamentWinnerCalculationTest
    {
        public readonly ITournamentWinnerCalculationInterface tournamentWinnerCalculation;

        public TournamentWinnerCalculationTest()
        {
            tournamentWinnerCalculation = new TournamentWinnerCalculation();
        }
        [TestMethod]
        public void TournamentWinnerCalculation_User_Winner_Test()
        {
            var result = tournamentWinnerCalculation.GetTournamentWinner(2, 1);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TournamentWinnerCalculation_Computer_Winner_Test()
        {
            var result = tournamentWinnerCalculation.GetTournamentWinner(1, 2);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TournamentWinnerCalculation_Winning_Count_Same_Test()
        {
            var result = tournamentWinnerCalculation.GetTournamentWinner(1, 1);
            Assert.IsNotNull(result);
        }
    }
}
