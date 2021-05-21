using System;
using System.Collections.Generic;
using System.Text;

namespace PrjRockPaperScissor.Interfaces
{
    public interface ITournamentWinnerCalculationInterface
    {
        string GetTournamentWinner(int userWinCount, int computerWinCount);
    }
}
