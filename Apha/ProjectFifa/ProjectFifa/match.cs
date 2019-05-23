using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectFifa
{
    class match
    {
        public int matchId { get; set; }
        public string teamAId { get; set; }
        public string teamBId { get; set; }
        public int matchScore { get; set; }
        public int matchPool { get; set; }
        public Label myLabel { get; set; }

        public string updatelabel()
        {
            return this.teamAId + "  -  " + this.teamBId;
        }
    }
   
}
