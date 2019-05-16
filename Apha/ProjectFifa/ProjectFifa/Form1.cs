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
    public partial class Form1 : Form
    {
        private bettorStorage storage;
        public Form1()
        {
            InitializeComponent();
            this.storage = new bettorStorage();
    }
        public void teams()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamjson;

            teamjson = downloader.DownloadString("http://localhost/fifa/API.php");

            team[] team = JsonConvert.DeserializeObject<team[]>(teamjson);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teams();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {
            Teamoverview form2 = new Teamoverview();
            form2.ShowDialog();
        }

        private void gokkerAanmakenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bettorAdd bettorAdd = new bettorAdd();
            bettorAdd.ShowDialog();

            if(bettorAdd.Result == null)
            {
                return;
            }
            this.storage.addBettor(bettorAdd.Result);

            this.storage.save();

            MessageBox.Show("Gokker Aangemaakt!.");
        }
    }
}
