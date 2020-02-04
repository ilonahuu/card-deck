using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13T02
{
    class Program
    {

        struct Card
        {
            public string Suit;
            public string Value;

            public override string ToString()
            {
                return Suit + ", " + Value;
            }

        }

        static void Main(string[] args)
        {
            string[] cardValue = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8",
                "9", "10", "Jack", "Queen", "King" };
            string[] cardSuit = new string[] { "Spade", "Club", "Heart", "Diamond" };

            List<Card> Deck = new List<Card>();

            for (int i = 0; i < 4; i++) // i = suit
            {
                for (int j = 0; j < 13; j++) // j = value
                {
                    Card addCard;
                    addCard.Suit = cardSuit[i];
                    addCard.Value = cardValue[j];
                    Deck.Add(addCard);
                }
            }

            Deck = Shuffle(Deck); // sends Deck and returns Shuffled Deck

            for (int i = 0; i < Deck.Count; i++)
            {
                Console.WriteLine(Deck[i].ToString());
            }

            Console.ReadKey();
        }

        private static List<Card> Shuffle(List<Card> Deck)
        {
            List<Card> shuffleList = new List<Card>();

            Random rand = new Random();
            int whichOne = 0;

            while (Deck.Count > 0)
            {
                whichOne = rand.Next(0, Deck.Count);
                shuffleList.Add(Deck[whichOne]);
                Deck.RemoveAt(whichOne);
            }

            return shuffleList;
        }

    }
}
