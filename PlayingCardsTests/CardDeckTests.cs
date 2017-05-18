using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PlayingCards.Tests
{
    [TestClass()]
    public class CardDeckTests
    {
        [TestMethod()]
        public void ShuffleDeckTest()
        {
            CardDeck sortedDeck = new CardDeck();
            CardDeck shuffledDeck = new CardDeck();
            shuffledDeck.ShuffleDeck();
            CollectionAssert.AreNotEqual(sortedDeck.GetDeck(), shuffledDeck.GetDeck());
        }

        [TestMethod()]
        public void SortDeckTest()
        {
            CardDeck sortedDeck = new CardDeck();
            CardDeck shuffledDeck = new CardDeck();
            shuffledDeck.ShuffleDeck();
            CollectionAssert.AreNotEqual(sortedDeck.GetDeck(), shuffledDeck.GetDeck());

            shuffledDeck.SortDeck();

            CollectionAssert.AreEqual(sortedDeck.GetDeck(), shuffledDeck.GetDeck());
        }

        [TestMethod()]
        public void HasCorrectNumberOfCards()
        {
            CardDeck cardDeck = new CardDeck();
            Assert.AreEqual(52, cardDeck.GetDeck().Length);
        }

        [TestMethod()]
        public void HasCorrectDeck()
        {
            PlayingCard[] controlDeck = new PlayingCard[52] {
            new PlayingCard(0, 0), new PlayingCard(0,1), new PlayingCard(0, 2),
            new PlayingCard(0, 3), new PlayingCard(0,4), new PlayingCard(0, 5), new PlayingCard(0, 6), new PlayingCard(0,7),
            new PlayingCard(0, 8), new PlayingCard(0,9), new PlayingCard(0, 10), new PlayingCard(0,11), new PlayingCard(0, 12),
            new PlayingCard(1, 0), new PlayingCard(1,1), new PlayingCard(1, 2),
            new PlayingCard(1, 3), new PlayingCard(1,4), new PlayingCard(1, 5), new PlayingCard(1, 6), new PlayingCard(1,7),
            new PlayingCard(1, 8), new PlayingCard(1,9), new PlayingCard(1, 10), new PlayingCard(1,11), new PlayingCard(1, 12),
            new PlayingCard(2, 0), new PlayingCard(2,1), new PlayingCard(2, 2),
            new PlayingCard(2, 3), new PlayingCard(2,4), new PlayingCard(2, 5), new PlayingCard(2, 6), new PlayingCard(2,7),
            new PlayingCard(2, 8), new PlayingCard(2,9), new PlayingCard(2, 10), new PlayingCard(2,11), new PlayingCard(2, 12),
            new PlayingCard(3, 0), new PlayingCard(3,1), new PlayingCard(3, 2),
            new PlayingCard(3, 3), new PlayingCard(3,4), new PlayingCard(3, 5), new PlayingCard(3, 6), new PlayingCard(3,7),
            new PlayingCard(3, 8), new PlayingCard(3,9), new PlayingCard(3, 10), new PlayingCard(3,11), new PlayingCard(3, 12)
            };

            PlayingCard[] actualDeck = new CardDeck().GetDeck();

            CollectionAssert.AreEqual(controlDeck, actualDeck);

        }
    }
}