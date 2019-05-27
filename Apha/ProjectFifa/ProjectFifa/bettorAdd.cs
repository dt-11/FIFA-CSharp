using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFifa
{
    public partial class bettorAdd : Form
    { 
        public bettor Result { get; set; }

        public bettorAdd()
        {
            InitializeComponent();

        }

        private void gokkerAddButton_Click(object sender, EventArgs e)
        {
            if (gokkerNameTextBox.Text == "")
            {
                MessageBox.Show("Vul Aub een naam in.");
            }
            else
            {
                bettor newbettor = new bettor();
                newbettor.name = gokkerNameTextBox.Text;
                newbettor.balance = 100;

                this.Result = newbettor;
                this.Close();
            }
            
        }
    }
}
