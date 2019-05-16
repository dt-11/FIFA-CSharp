using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectFifa
{
    public partial class Teamoverview : Form
    {
        public Teamoverview()
        {
            InitializeComponent();
        }
        private void overviewForm_Load(object sender, EventArgs e)
        {
            teams();
        }
        public void teams()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamjson;

            teamjson = downloader.DownloadString("http://localhost/fifa/API.php");

            team[] team = JsonConvert.DeserializeObject<team[]>(teamjson);

            for (int i = 0; i < team.Length; i++)
            {
                teamListBox.Items.Add(team[i].teamName);
            }
        }

        private void overviewToFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
