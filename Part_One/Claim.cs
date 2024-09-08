using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_One
{
    public partial class Claim : Form
    {
        public Claim()
        {
            InitializeComponent();
        }

        private void Request_btn_Click(object sender, EventArgs e)
        {
            Homescreen homescreen = new Homescreen();
            homescreen.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Claim_Load(object sender, EventArgs e)
        {

        }
    }
}
