using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTNN_gameLine98
{
    [Serializable()]
    class PlayerList
    {
        public Player[] list;

        public PlayerList(Player[] list)
        {
            this.list = list;
        }
    }
}
