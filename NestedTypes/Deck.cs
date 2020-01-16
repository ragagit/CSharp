using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpS4_7
{
    class Deck
    {
        Card[] cards;
        string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
        int place = 0;
        public Deck()
        {
            cards = new Card[52];
            int i = 0;
            foreach (string s in suits)
            {
                for (int j = 1; j < 14; j++)
                {
                    cards[i] = new Card(j, s);
                    i++;
                }
            }
        }

        class Card
        {
            int value;
            string suit;

            public Card(int v, string s)
            {
                value = v;
                suit = s;
            }

            public override string ToString()
            {
                return (value + " of " + suit);
            }
        }

        public void dealCard()
        {
            if (place < 52)
            {
                Console.WriteLine(cards[place]);
                place++;
            }
        }
    }
}
