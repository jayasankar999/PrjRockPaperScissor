using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjRockPaperScissor
{
    public class RandomGenerator : IRandomInterface
    {
        public string GetRandomChoice()
        {
            string[] compOptions = { "ROCK", "PAPER", "SCISSOR" };
            Random rnd = new Random();
            var randonNumber = rnd.Next(0, 3);
            var computerChoice = compOptions[randonNumber];
            return computerChoice;
        }
    }
}
