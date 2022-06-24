using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePlayer.Classes
{

    internal class Team
    {
        private List<string> qb = new List<string>();
        private List<string> wr = new List<string>();
        private List<string> te = new List<string>();
        private List<string> rb = new List<string>();
        private List<string> fb = new List<string>();
        private List<string> k = new List<string>();
        public List<string> Quarter_backs { get { return qb; } set { qb = value; } }
        public List<string> Wide_Receivers { get { return wr; } set { wr = value; } }
        public List<string> Tight_Ends { get { return te; } set { te = value; } }
        public List<string> Running_Backs { get { return rb; } set { rb = value; } }
        public List<string> Full_Backs { get { return fb; } set { fb = value; } }
        public List<string> Kickers { get { return k; } set { k = value; } }

        /*
        public string this[int index, int index2]
        {
            get
            {
                if (index == 0)
                    return QB[index2];
                else if (index == 1)
                    return WR[index2];
                else if (index == 2)
                    return TE[index2];
                else if (index == 3)
                    return RB[index2];
                else if (index == 4)
                    return FB[index2];
                else if (index == 5)
                    return K[index2];
            }
            set
            {
                if (index == 0)
                    QB[index2] = value;
                else if (index == 1)
                    WR[index2] = value;
                else if (index == 2)
                    TE[index2] = value;
                else if (index == 3)
                    RB[index2] = value;
                else if (index == 4)
                    FB[index2] = value;
                else if (index == 5)
                    K[index2] = value;

            }
        }
        */
    }
}
