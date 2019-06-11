using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectFifa
{
    public partial class FIFA : Form
    {
        private bettorStorage storage;
        public FIFA()
        {
            InitializeComponent();
            this.storage = new bettorStorage();
    }
        public void matches()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string matchjson;

            matchjson = downloader.DownloadString("http://localhost/fifa/matchAPI.php?key=frikandelebakker");
            Debug.WriteLine(matchjson);
     
            match[] match = JsonConvert.DeserializeObject<match[]>(matchjson);

            for (int i = 0; i < match.Length; i++)
            {
                matchListBox.Items.Add(match[i].teamA + " - " + match[i].teamB);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matches();
        }

        private void teamOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teamoverview teamview = new Teamoverview();
            teamview.ShowDialog();
        }

        private void weddenschapAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            betForm betform = new betForm();
            betform.ShowDialog();
        }

        private void gokkerAanmakenToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            bettorAdd bettorAdd = new bettorAdd();
            bettorAdd.ShowDialog();

            if (bettorAdd.Result == null)
            {
                return;
            }
            this.storage.addBettor(bettorAdd.Result);

            this.storage.save();

            MessageBox.Show("Gokker Aangemaakt!.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gokkerOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bettorOverview bettorview = new bettorOverview();
            bettorview.ShowDialog();
        }
    }
}
