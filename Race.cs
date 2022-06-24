using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndAssignment
{
    public class Race
    {

        private int Distance;
        private string Time;
        private Player Players;

        public int distance
        {
            get { return Distance; }
            set { Distance = value; }
        }

        public Player player
        { 
            get { return Players; } 
            set { Players = value; } 
        }

        public string time
        {
            get { return Time; }
            set { Time = value; }
        }

        public Race(Player Players, string Time, int Distance)
        {
            this.Players = Players;
            this.Time = Time;
            this.Distance = Distance;
        }

        public double getPoints()
        {
            double points = 0;
            string[] timeParts = dateTimePicker1.Text.Split(":");
            int minutes = Convert.ToInt32(timeParts[0]);
            int seconds = Convert.ToInt32(timeParts[1]);
            int mili = Convert.ToInt32(timeParts[2]);

            points = minutes * 60 + seconds + mili/100;
            return points;
        }
    }
}
