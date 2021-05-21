using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjRockPaperScissor.Interfaces
{
    public interface IGameWinnerCalculationInterface
    {
        Tuple<string, int, int> CalculateGameWinner(string userChoice, string computerChoice, int userWinCount, int computerWincount);
    }
}
