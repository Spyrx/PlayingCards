using System;

namespace PlayingCards
{
    public class CardDeck
    {
        private static Random random = new Random();

        private PlayingCard[] Deck = new PlayingCard[52];

        public CardDeck()
        {
            CreateDeck();
        }

        public PlayingCard[] GetDeck()
        {
            return Deck;
        }

        /* Jeff K. 5/17/2017. Last Code Revision 5/17/2017.
        *Pick a random number between 0 and the array length.
        *swap the element at random index and swap it with the end of the array.
        *Place end item at the random index.
        *Provides an inplace shuffle withou having to create a second array.
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

        public void SortDeck(bool isAceHigh)
        {
            if (!isAceHigh)
                Array.Sort(Deck);
            else
            {
                for (int i = 0; i < 52; i++)
                {
                    if (Deck[i].Rank == CardRank.AceLow)
                    {
                        Deck[i] = new PlayingCard((int)Deck[i].Suit, (int)CardRank.AceHigh);
                    }
                }
                Array.Sort(Deck);
            }
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
            /* Jeff K. 5/17/2017. Last code Revision 5/17/2017.
             * Went with a double loop to make the code easier to read.
             * Simply creates 13 cards in each suit and adds them to the array of Playing Cards.
             * Chose an array because the extra over head to add and remove in the middle of a list
             * during the shuffle method didn't seem necessary.
             */
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
