using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectFifa
{
    public class match
    {
        public int matchId { get; set; }

        public int matchPool { get; set; }

        public int teamCreated { get; set; }

        public string teamA { get; set; }

        public int teamAscore { get; set; }

        public string teamB { get; set; }

        public int teamBscore { get; set; }

        public override string ToString()
        {
            return teamA + " - " + teamB;
        }
    }
}
