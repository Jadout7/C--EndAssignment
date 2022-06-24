using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndAssignment
{
    public class Player
    {
        private string playerName;
        private string playerNationality;
        private int playerAge;
        private int playerNumber;

        public Player(string playerName, string playerNationality, int playerAge, int playerNumber)
        {
            //Set property values
            this.playerName = playerName;
            this.playerNationality = playerNationality;
            this.playerAge = playerAge;
            this.playerNumber = playerNumber;
        }

        public string Name
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string Nationality
        {
            get { return playerNationality; }
            set { playerNationality = value; }
        }

        public int Age
        {
            get { return playerAge; }
            set { playerAge = value; }
        }

        public int Number
        {
            get { return playerNumber; }
            set { playerNumber = value; }
        }

    }
}
