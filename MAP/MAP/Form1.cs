using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text="МЦК Лужники";
            pictureBox2.Visible= true;pictureBox3.Visible= true;
            pictureBox4.Visible = false;pictureBox5.Visible=false;pictureBox6.Visible= false;
            label2.Visible= true;label3.Visible= true;
            label4.Visible = false; label5.Visible= false; label6.Visible= false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Новодевичей монастырь";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Метро Киевская";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; 
            pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true;label4.Visible = true; 
            label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "МИД";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox6.Visible = true;
            pictureBox5.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;  label6.Visible = true;
            label5.Visible = false;
            pictureBox6.Location = new Point(402,303);
            label6.Location = new Point(552,312);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Парк Горького";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; 
            pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; 
            label6.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Здания РАН";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Метро Воробевы горы";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            pictureBox6.Location = new Point(402,378);
            label6.Location = new Point(552, 402);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            namePoint.Visible = true;
            namePoint.Text = "Стадион Лужники";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            pictureBox6.Location = new Point(402, 378);
            label6.Location = new Point(552, 402);
        }
    }
}
