using System;
using Microsoft.Extensions.DependencyInjection;
using PrjRockPaperScissor.Interfaces;

namespace PrjRockPaperScissor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IRandomInterface, RandomGenerator>()
                .AddTransient<IGameWinnerCalculationInterface, GameWinnerCalculation>()
                 .AddTransient<ITournamentWinnerCalculationInterface, TournamentWinnerCalculation>()
                 .AddTransient<IRockPaperScissorInterface, RockPaperScissors>()
                .BuildServiceProvider();

            var rockPaperScissor = serviceProvider.GetService<IRockPaperScissorInterface>();
            rockPaperScissor.Game(3);
        }
    }
}
