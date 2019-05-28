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
    public partial class bettorOverview : Form
    {
        private bettorStorage storage;
        public bettorOverview()
        {
            InitializeComponent();
            this.storage = new bettorStorage();
        }

        private void bettorOverview_Load(object sender, EventArgs e)
        {
            bettorsbox();
        }
        public void bettorsbox()
        {
            foreach (bettor collection in this.storage.bettors)
            {
                bettorListBox.Items.Add(collection);
            }
        }

        private void betOverviewToFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
