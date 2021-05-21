using PrjRockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrjRockPaperScissor
{
    public class RockPaperScissors : IRockPaperScissorInterface
    {
        private readonly IRandomInterface _randomService;
        private readonly IGameWinnerCalculationInterface _gameWinnerCalculationService;
        private readonly ITournamentWinnerCalculationInterface _tournamentWinnerCalculationService;
        public RockPaperScissors(IRandomInterface randomService,
            IGameWinnerCalculationInterface gameWinnerCalculationService,
            ITournamentWinnerCalculationInterface tournamentWinnerCalculationService
            )
        {
            _randomService = randomService;
            _gameWinnerCalculationService = gameWinnerCalculationService;
            _tournamentWinnerCalculationService = tournamentWinnerCalculationService;
        }
        public bool Game(int gameCount)
        {
            int totalGames = 0;
            int userWinCount = 0;
            int computerWincount = 0;

            Console.WriteLine("Welcome to Rock Paper Scissor game");
            Console.WriteLine("\nTournament has got 3 matches.");
            Console.WriteLine("\nAfter that winner will be announced.");
            while (totalGames != gameCount)
            {
                Console.WriteLine("\nSelect any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");

                var computerChoice = _randomService.GetRandomChoice();
                Console.WriteLine("Enter your choice:");
                string userChoice = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + computerChoice);

                var winner = _gameWinnerCalculationService.CalculateGameWinner(userChoice, computerChoice, userWinCount, computerWincount);
                if (winner != null)
                {
                    userWinCount = winner.Item2;
                    computerWincount = winner.Item3;
                    Console.WriteLine("" + winner.Item1 + "");
                }
                totalGames = totalGames + 1;
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("User wins " + userWinCount + " times");
            Console.WriteLine("Computer wins " + computerWincount + " times");
            var tournamentWinner = _tournamentWinnerCalculationService.GetTournamentWinner(userWinCount, computerWincount);
            Console.WriteLine("" + tournamentWinner + "");
            Console.ReadLine();
            return true;
        }
    }
}
