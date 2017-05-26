using System;

namespace PlayingCards
{

    public enum CardSuit
    {
        Diamond,
        Club,
        Heart,
        Spade
    }

    public enum CardRank
    {
        AceLow,
        Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Jack,
        Queen,
        King,
        AceHigh
    }

    public class PlayingCard : IComparable<PlayingCard>
    {
        public CardSuit Suit { get; }
        public CardRank Rank { get; }

        public PlayingCard(int suit, int rank)
        {
            Suit = (CardSuit)suit;
            Rank = (CardRank)rank;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PlayingCard Other = obj as PlayingCard;
            if (Other == null)
                return false;

            return Suit == Other.Suit && Rank == Other.Rank;
        
        }

        /* Jeff K. 5/17/2017. Last Code Revision 5/17/2017.
         * Chose not fully implement GetHashCode while overriding the Equals method
         * because the properties of the card will not be changing once they are set.
         * Only needed to be able to compare that Suit and the Rank.
         */
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(PlayingCard other)
        {
            if (Suit != other.Suit)
                return Suit.CompareTo(other.Suit);

            return Rank.CompareTo(other.Rank);
        }
    }
}
