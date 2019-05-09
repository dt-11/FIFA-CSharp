﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }
        public void teams()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamjson;

            teamjson = downloader.DownloadString("http://localhost/test/FIFA-PHP/test.php");

            team[] team = JsonConvert.DeserializeObject<team[]>(teamjson);

           // matchLabel1.Text = team[0].teamName;
           // matchLabel2.Text = team[1].teamName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teams();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {
            overviewForm form2 = new overviewForm();
            form2.ShowDialog();
        }
    }
}