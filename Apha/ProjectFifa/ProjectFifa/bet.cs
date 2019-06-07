using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFifa
{
    public class bet
    {
        public match betMatch { get; set; }
        public string winningTeam { get; set; }
        public int aScore { get; set; }
        public int bScore { get; set; }
        public int betAmount { get; set; }
        public bettor bettor { get; set; }
    }
}
