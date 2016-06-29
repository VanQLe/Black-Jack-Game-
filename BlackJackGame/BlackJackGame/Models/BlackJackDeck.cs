using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    

    public class BlackJackDeck
    {
        private List<Card> deck;//game deck
        /// <summary>
        /// Initialize a new instance of Black Jack Deck
        /// </summary>
        public BlackJackDeck()
        {
            Deck = new List<Card>();
            createDeck();
        }

        public  List<Card> Deck
        {
            get
            {
                return deck;
            }

            set
            {
                deck = value;
            }
        }


        private void createDeck()
        {
            foreach (var suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds", })
            {
                for (var rank = 0; rank <= 13; rank++)
                {
                    Deck.Add(new Card(rank, suit));
                }
            }
        }
    }
}
