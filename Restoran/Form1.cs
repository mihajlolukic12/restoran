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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Exit";
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;

            Random r = new Random();
            int randomSto;
            randomSto = r.Next(1, 12);

            switch (randomSto)
            {
                case 1:
                    pictureBox1.BackColor = Color.Red;
                    pictureBox1.Enabled = true;
                    break;
                case 2:
                    pictureBox2.BackColor = Color.Red;
                    pictureBox2.Enabled = true;
                    break;
                case 3:
                    pictureBox3.BackColor = Color.Red;
                    pictureBox3.Enabled = true;
                    break;
                case 4:
                    pictureBox4.BackColor = Color.Red;
                    pictureBox4.Enabled = true;
                    break;
                case 5:
                    pictureBox5.BackColor = Color.Red;
                    pictureBox5.Enabled = true;
                    break;
                case 6:
                    pictureBox6.BackColor = Color.Red;
                    pictureBox6.Enabled = true;
                    break;
                case 7:
                    pictureBox7.BackColor = Color.Red;
                    pictureBox7.Enabled = true;
                    break;
                case 8:
                    pictureBox8.BackColor = Color.Red;
                    pictureBox8.Enabled = true;
                    break;
                case 9:
                    pictureBox9.BackColor = Color.Red;
                    pictureBox9.Enabled = true;
                    break;
                case 10:
                    pictureBox10.BackColor = Color.Red;
                    pictureBox10.Enabled = true;
                    break;
                case 11:
                    pictureBox11.BackColor = Color.Red;
                    pictureBox11.Enabled = true;
                    break;
                case 12:
                    pictureBox12.BackColor = Color.Red;
                    pictureBox12.Enabled = true;
                    break;

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = "jes";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PictureBox7_DragOver(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
