using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class Card
    {
        private int cardValue;
        private string suit;
        /// <summary>
        /// Initialize a new instance of card with card value and suit
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(int value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public int Value
        {
            get
            {
                return cardValue;
            }

            set
            {
                this.cardValue = value;
            }
        }

        public string Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

      
    }
}
