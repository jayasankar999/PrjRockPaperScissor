using PrjRockPaperScissor.Interfaces;
using System;

namespace PrjRockPaperScissor
{
    public class GameWinnerCalculation : IGameWinnerCalculationInterface
    {
        public Tuple<string, int, int> CalculateGameWinner(string userChoice, string computerChoice, int userWinCount, int computerWincount)
        {
            switch (userChoice)
            {
                case "ROCK":
                    switch (computerChoice)
                    {
                        case "ROCK":
                            return Tuple.Create("Both user and computer choose the same.So the game ends in draw", userWinCount, computerWincount);
                        case "PAPER":
                            computerWincount += 1;
                            return Tuple.Create("Computer wins", userWinCount, computerWincount);
                        case "SCISSOR":
                            userWinCount += 1;
                            return Tuple.Create("User wins", userWinCount, computerWincount);
                    }
                    break;
                case "PAPER":
                    switch (computerChoice)
                    {
                        case "ROCK":
                            userWinCount += 1;
                            return  Tuple.Create("User wins", userWinCount, computerWincount);
                        case "PAPER":
                            return  Tuple.Create("Both user and computer choose the same.So the game ends in draw", userWinCount, computerWincount);
                        case "SCISSOR":
                            computerWincount += 1;
                            return Tuple.Create("Computer wins", userWinCount, computerWincount);
                    }
                    break;
                case "SCISSOR":
                    switch (computerChoice)
                    {
                        case "ROCK":
                            computerWincount += 1;
                            return  Tuple.Create("Computer wins", userWinCount, computerWincount);
                        case "PAPER":
                            userWinCount += 1;
                            return  Tuple.Create("User wins", userWinCount, computerWincount);
                        case "SCISSOR":
                            return  Tuple.Create("Both user and computer choose the same.So the game ends in draw", userWinCount, computerWincount);
                    }
                    break;
            }
            return  Tuple.Create("Not a valid choice.", userWinCount, computerWincount);
        }
    }
}
