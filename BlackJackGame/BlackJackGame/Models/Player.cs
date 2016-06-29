using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class Player
    {
        private int playerID;
        private string playerName;
        private int handValue;
        /// <summary>
        /// Default constructor to initialize a new player
        /// </summary>
        public Player()
        {

        }
        //Initialize a new player with ID and Name
        public Player(int playerID, string playerName)
        {
            this.playerID = playerID;
            this.playerName = playerName;
        }

        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public int CardValue
        {
            get
            {
                return handValue;
            }

            set
            {
                handValue = value;
            }
        }

        public int ID
        {
            get
            {
                return playerID;
            }

            set
            {
                playerID = value;
            }
        }
    }
}

    }
}
