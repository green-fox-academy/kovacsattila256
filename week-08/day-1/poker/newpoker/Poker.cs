using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsApp
{
    public class Poker
    {
        public string GetValue(string input)
        {
            return input.ToString();
        }
        
        public bool CheckInputLength12(string input)
        {
            string[] temp = input.Split(' ');
            return temp.Length == 12;
        }

        public string GetHands (string input)
        {
            string[] raw = input.Split(' ');
            List<string> blackHandRaw = new List<string> { raw[1], raw[2], raw[3], raw[4], raw[5], };
            List<string> whiteHandRaw = new List<string> { raw[7], raw[8], raw[9], raw[10], raw[11], };
             /*
              * High Card: Hands which do not fit any higher category are ranked by the value of 
              * their highest card. If the highest cards have the same value, the hands are ranked by the 
              * next highest, and so on.
              */

            for (int i = 0; i < raw.Length; i++)
            {

            }

            return "White wins";
        }
    }
}
