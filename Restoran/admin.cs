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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        static DateTime datum;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datumlocal;
            datumlocal = monthCalendar1.SelectionRange.Start;
            label2.Text = "Novi datum je: " + datumlocal.ToString("dd.MM.yyyy.");
            datum = datumlocal;
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            label3.Text = datum.ToString();
        }
    }
}
