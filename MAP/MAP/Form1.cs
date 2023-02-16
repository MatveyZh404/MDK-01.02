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
            namePlace.Visible = true;
            namePlace.Text="МЦК Лужники";
            pictureBox2.Visible= true;pictureBox3.Visible= true;
            pictureBox4.Visible = false;pictureBox5.Visible=false;pictureBox6.Visible= false;
            label2.Visible= true;label3.Visible= true;
            label4.Visible = false; label5.Visible= false; label6.Visible= false;
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Новодевичей монастырь";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Метро Киевская";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; 
            pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true;label4.Visible = true; 
            label5.Visible = false; label6.Visible = false;
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "МИД";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox6.Visible = true;
            pictureBox5.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;  label6.Visible = true;
            label5.Visible = false;
            pictureBox6.Location = new Point(402,303);
            label6.Location = new Point(552,312);
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Парк Горького";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; 
            pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; 
            label6.Visible = false;
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Здания РАН";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true;
            pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Метро Воробевы горы";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            pictureBox6.Location = new Point(402,378);
            label6.Location = new Point(552, 402);
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            namePlace.Visible = true;
            namePlace.Text = "Стадион Лужники";
            pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            pictureBox6.Location = new Point(402, 378);
            label6.Location = new Point(552, 402);
            startName.Visible = false;
            label8.Visible = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            startName.Visible = true;
            startName.Text = "Старт гонки";
            label8.Visible = true;
            label8.Text = "Полный забег - 40 киллометров";
            namePlace.Visible = false;
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            startName.Visible = true;
            startName.Text = "Промежуточный старт гонки";
            label8.Visible = true;
            label8.Text = "Полузабег - 20 километов";
            namePlace.Visible = false;
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            startName.Visible = true;
            startName.Text = "Промежуточный старт гонки";
            label8.Visible = true;
            label8.Text = "Короткий забег - 5 километров";
            namePlace.Visible = false;
            pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }
    }
}
