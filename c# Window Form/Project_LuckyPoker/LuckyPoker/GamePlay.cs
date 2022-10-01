using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyPoker
{
    public static class GamePlay
    {
        public static void setEnableDisable(this Control control, bool value) //Extension
        {
            control.Enabled = value;
        }

        public static void setVisibility(this Control control, bool value) //Extension
        {
            control.Visible = value;
        }

        public static bool verifyBetAmount(decimal plyrOneBal,decimal BetAmount,decimal plyrTwoBal)
        {
            if (plyrOneBal < BetAmount && plyrTwoBal < BetAmount)
            {
                return false;
            }
            else if (plyrOneBal < BetAmount)
            {
                return false;
            }
            else if (plyrTwoBal < BetAmount)
            {
                return false;
            }
            return true;
        }
    }
}
