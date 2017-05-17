using System;


namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck myDeck = new CardDeck();

            int input = 0;
            while (input != 9)
            {
                Console.WriteLine("1 - Shuffle, 2 - Sort, 3 - Print, 9 - Quit");
                input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        myDeck.ShuffleDeck();
                        break;
                    case 2:
                        myDeck.SortDeck();
                        break;
                    case 3:
                        myDeck.PrintDeck();
                        break;
                    case 9:
                        break;
                }
            }
        }
    }
}
