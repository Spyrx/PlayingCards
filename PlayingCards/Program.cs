using System;


namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Jeff K. 5/17/2017. Last Code Revision 5/17/2017.
             * Added a small user interface for manual testing in addition to the unit tests, just to be sure it was working as expected.
             */
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
