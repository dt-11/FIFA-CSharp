using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFifa
{
    public class bettor
    {
        public string name { get; set; }

        public int balance { get; set; }

        public bet[] mybets { get; set; }

        public override string ToString()
        {
            return name;
        }

        
    }
}
