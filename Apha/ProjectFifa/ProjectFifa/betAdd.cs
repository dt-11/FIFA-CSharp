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
    public partial class betForm : Form
    {
        private bettorStorage storage;

        public betForm()
        {
            InitializeComponent();
            inputs();
            this.storage = new bettorStorage();
        }

        private void matchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            match selectedmatch = (match)matchComboBox.SelectedItem;
            teamComboBox.Items.Clear();
            teamComboBox.Items.Add(selectedmatch.teamA);
            teamComboBox.Items.Add(selectedmatch.teamB);
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (matchComboBox.Text == "")
            {
                MessageBox.Show("Selecteer een Match.");
            }
            else if (teamComboBox.Text == "")
            {
                MessageBox.Show("Selecteer een Team.");
            }
            else if (inzetNumbericUpDown.Value < 0)
            {
                MessageBox.Show("Zet een hoeveelheid in.");
            }
            else
            {
                bet newbet = new bet();
                newbet.betMatch = matchComboBox.Text;
                newbet.winningteam = teamComboBox.Text;
                newbet.betAmount = Convert.ToInt32(inzetNumbericUpDown.Value);
                newbet.bettor = (bettor)bettorComboBox.SelectedItem;
                MessageBox.Show("Weddenschap aangemaakt.");
            }
        }
        public void inputs()
        {
            inzetNumbericUpDown.Maximum = 6000;
            inzetNumbericUpDown.Minimum = 0;

            System.Net.WebClient downloader = new System.Net.WebClient();
            string matchjson;

            matchjson = downloader.DownloadString("http://localhost/fifa/matchAPI.php?key=frikandelebakker");

            match[] matchs = JsonConvert.DeserializeObject<match[]>(matchjson);

            for (int i = 0; i < matchs.Length; i++)
            {
                matchComboBox.Items.Add(matchs[i].teamA + " - " + matchs[i].teamB);
            }

            foreach (bettor collection in this.storage.bettors)
            {
                bettorComboBox.Items.Add(collection.name);
            }
        }

        public void outputs()
        {
            foreach (bettor collection in this.storage.bettors)
            {
                bettorComboBox.Items.Add(collection.name);
            }
        }
    }
}
