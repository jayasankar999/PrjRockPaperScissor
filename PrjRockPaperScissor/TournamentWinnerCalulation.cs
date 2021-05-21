using PrjRockPaperScissor.Interfaces;

namespace PrjRockPaperScissor
{
    public class TournamentWinnerCalculation : ITournamentWinnerCalculationInterface
    {
        public string GetTournamentWinner(int userWinCount, int computerWinCount)
        {
            var tournamentWinner = default(string);
            if (userWinCount > computerWinCount)
            {
                tournamentWinner = "Tournament winner is User.";
            }
            else if (userWinCount < computerWinCount)
            {
                tournamentWinner = "Tournament winner is Computer.";
            }
            else if (userWinCount == computerWinCount)
            {
                tournamentWinner = "Both User and Computer has equal no of wins. So tournament is draw ";
            }
            return tournamentWinner;
        }
    }
}
