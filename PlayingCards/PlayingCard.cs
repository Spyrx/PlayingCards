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
        Ace,
        Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Jack,
        Queen,
        King
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

        // Included because of Equals Override. No plans on using HashCode.
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
