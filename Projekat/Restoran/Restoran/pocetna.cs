using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class pocetna : Form
    {
        public pocetna()
        {
            InitializeComponent();
        }

        private void pocetna_Load(object sender, EventArgs e)
        {
            button1.Text = "admin";
            button2.Text = "gost";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new login();

            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form gost = new Form1();
            this.Hide();
            gost.Show();
        }
    }
}
