using System;

namespace PlayingCards
{
    public class CardDeck
    {
        private Random random = new Random();

        private PlayingCard[] Deck = new PlayingCard[52];

        public CardDeck()
        {
            CreateDeck();
        }

        public PlayingCard[] GetDeck()
        {
            return Deck;
        }

        /*
        * Pick a random number between 0 and the array length.
        * Select the element at random index and swap it with the end of the array.
        * Place end item at the random index.
        * Provides an inplace shuffle without having to create a second array.
        */
        public void ShuffleDeck()
        {

            int i = Deck.Length - 1;
            int randomIndex;

            while (i > 0)
            {
                randomIndex = random.Next(0, i);
                PlayingCard tempCard = Deck[randomIndex];
                Deck[randomIndex] = Deck[i];
                Deck[i] = tempCard;
                i--;
            }
        }

        public void SortDeck()
        {
            Array.Sort(Deck);
        }

        public void PrintDeck()
        {
            foreach(PlayingCard p in Deck)
            {
                Console.WriteLine(p.Suit.ToString() +  p.Rank.ToString());
            }
        }

        public void CreateDeck()
        {
            int arrayIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Deck[arrayIndex] = new PlayingCard(i, j);
                    arrayIndex++;
                }
            }
        }
    }
}
