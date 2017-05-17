using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PlayingCards.Tests
{
    [TestClass()]
    public class PlayingCardTests
    {
        [TestMethod()]
        public void CompareToTest()
        {
            PlayingCard cardOne = new PlayingCard(0, 10);
            PlayingCard cardTwo = new PlayingCard(2, 10);
            Assert.AreNotEqual(cardOne, cardTwo);
        }

        [TestMethod()]
        public void AreEqualCards()
        {
            PlayingCard cardOne = new PlayingCard(0, 10);
            PlayingCard cardTwo = new PlayingCard(0, 10);

            Assert.AreEqual(cardOne, cardTwo);
        }
    }
}