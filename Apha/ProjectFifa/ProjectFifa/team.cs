using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjectFifa
{
    public class team
    {
        public int teamId { get; set; }

        public string teamName { get; set; }

        public int teamUserId { get; set; }

        public int teamGoals { get; set; }

        public int teamScore { get; set; }

        public int teamPool { get; set; }
    }
}
