using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace PrjRockPaperScissor.UnitTest
{
    [TestClass]
    public class RandomGenerator_Test
    {
        private readonly IRandomInterface randomGenerator;
        public RandomGenerator_Test()
        {
            randomGenerator = new RandomGenerator();
        }


        [TestMethod]
        public void RandomGenerator_Test_Success()
        {
            var result = randomGenerator.GetRandomChoice();
            Assert.IsNotNull(result);
        }
    }
}
