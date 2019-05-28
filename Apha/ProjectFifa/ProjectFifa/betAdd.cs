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
            this.storage = new bettorStorage();
            inputs();
        }
        private void betButton_Click(object sender, EventArgs e)
        {
            int bettorBalance = Convert.ToInt32(betterBalLabel.Text);
            if (bettorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een gokker.");
            }
            else if (matchComboBox.Text == "")
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
            else if (bettorBalance < 1)
            {
                MessageBox.Show("U heeft niet genoeg geld.");
            }
            else
            {
                bet newbet = new bet();
                newbet.betMatch = matchComboBox.Text;
                newbet.winningTeam = teamComboBox.Text;
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
                matchComboBox.Items.Add(matchs[i]);
            }

            foreach (bettor collection in this.storage.bettors)
            {
                bettorComboBox.Items.Add(collection);
            }
        }

        public void outputs()
        {
            
        }

        private void matchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            match selectedmatch = (match)matchComboBox.SelectedItem;
            teamComboBox.Items.Clear();
            teamComboBox.Items.Add(selectedmatch.teamA);
            teamComboBox.Items.Add(selectedmatch.teamB);
        }

        private void bettorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bettor selectedbettor = (bettor)bettorComboBox.SelectedItem;
            int balance = selectedbettor.balance;
            betterBalLabel.Text = Convert.ToString(balance);
        }
    }
}
