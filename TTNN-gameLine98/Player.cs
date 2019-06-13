﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTNN_gameLine98
{
    [Serializable()]
    class Player
    {
        public string name;
        public int scores;
        public int hours;
        public int minutes;
        public int seconds;

        public Player(string name, int scores, int hours, int minutes, int seconds)
        {
            this.name = name;
            this.scores = scores;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public int getTotalSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public static bool less(Player p1, Player p2)
        {
            if (p1.scores != p2.scores)
                return p1.scores < p2.scores;
            return p1.getTotalSeconds() > p2.getTotalSeconds();
        }

        public string[] convert(int index)
        {
            string[] s = new string[4];
            s[0] = index.ToString();

            s[1] = name;

            s[2] = scores.ToString();

            s[3] = hours.ToString() + ":";

            if (minutes < 10) s[3] += "0";
            s[3] += minutes.ToString() + ":";

            if (seconds < 10) s[3] += "0";
            s[3] += seconds.ToString();

            return s;
        }
    }
}
