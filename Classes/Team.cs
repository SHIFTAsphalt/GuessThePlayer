using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePlayer.Classes
{
    internal class Team
    {
        public string QB { get; set; }
        public string WR { get; set; }
        public string RB { get; set; }

        public string this[int index]
        {
            get
            {
                if (index == 0)
                    return QB;
                else if (index == 1)
                    return WR;
                else
                    return RB;
            }
            set
            {
                if (index == 0)
                    QB = value;
                else if (index == 1)
                    WR = value;
                else
                    RB = value;
            }
        }
    }
}
