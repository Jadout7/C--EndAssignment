using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndAssignment
{
    public class Championship
    {
        private List<Race> races = new List<Race>();
        private List<Player> players = new List<Player>();
        public Championship()
        {

        }
        public List<Race> Races 
        { 
            get { return races; } 
        }

        public List<Player> Players 
        { 
            get { return players; } 
        }

        public void addRace(Race race)
        {
            races.Add(race);
        }

        public void addPlayer(Player player)
        {
            players.Add(player);
        }

        public string getWinner()
        {
            Race raceWinner = null;
            foreach (Race race in races)
            {
                if (raceWinner == null)
                {
                    raceWinner = race;
                }
                if (raceWinner.getPoints() < race.getPoints())
                {
                    raceWinner = race;
                }
            }
            return raceWinner.player.Name;
        }

        public double getWinnerPoints()
        {
            Race raceWinner = null;
            foreach (Race race in races)
            {
                if (raceWinner == null)
                {
                    raceWinner = race;
                }
                if (raceWinner.getPoints() < race.getPoints())
                {
                    raceWinner = race;
                }
            }
            return raceWinner.getPoints();
        }
    }
}
