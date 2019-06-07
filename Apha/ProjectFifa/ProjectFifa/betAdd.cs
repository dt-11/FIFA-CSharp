using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                int bettorBalance = Convert.ToInt32(betterBalLabel.Text);
                if (matchComboBox.Text == "")
                {
                    MessageBox.Show("Selecteer een Match.");
                }
                else if (teamComboBox.Text == "")
                {
                    MessageBox.Show("Selecteer een Team.");
                }
                else if (inzetNumbericUpDown.Value <= 0)
                {
                    MessageBox.Show("Zet een hoeveelheid in.");
                }
                else if (teamAScore.Value < 1 || teamBScore.Value < 1)
                {
                    MessageBox.Show("Vul de eindscore in.");
                }
                else if (inzetNumbericUpDown.Value > bettorBalance)
                {
                    MessageBox.Show("U heeft niet genoeg geld.");
                }
                else
                {
                    bet newbet = new bet();
                    newbet.betMatch = (match)matchComboBox.SelectedItem;
                    newbet.winningTeam = teamComboBox.Text;
                    newbet.aScore = Convert.ToInt32(teamAScore.Value);
                    newbet.bScore = Convert.ToInt32(teamAScore.Value);
                    newbet.betAmount = Convert.ToInt32(inzetNumbericUpDown.Value);
                    newbet.bettor = (bettor)bettorComboBox.SelectedItem;
                    MessageBox.Show("Weddenschap aangemaakt.");

                    File.WriteAllText("./bets/", JsonConvert.SerializeObject(newbet));

                    // serialize JSON directly to a file
                    using (StreamWriter file = File.CreateText("./bets/"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, newbet);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Selecteer een gokker");
            }
            
        }
        public void inputs()
        {
            inzetNumbericUpDown.Maximum = 2147483646;
            inzetNumbericUpDown.Minimum = 0;

            teamAScore.Maximum = 2147483646;
            teamAScore.Minimum = 0;

            teamBScore.Maximum = 2147483646;
            teamBScore.Minimum = 0;

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

        private void bettorComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bettor selectedbettor = (bettor)bettorComboBox.SelectedItem;
            int balance = selectedbettor.balance;
            betterBalLabel.Text = Convert.ToString(balance);
        }
    }
}
