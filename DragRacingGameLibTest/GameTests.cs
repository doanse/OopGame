using DragRacingGameLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRacingGameLibTest
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void Sum10and20returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int sum = 30;

            //act
            int actual = Game.Sum(x, y);

            //assert
            Assert.AreEqual(sum, actual);


        }
    }
}
