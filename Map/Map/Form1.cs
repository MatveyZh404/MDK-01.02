using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true;
            pictureBox16.Visible = false; pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true;
            label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label7.Visible = true;
            label7.Text = "МЦК Лужники";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            label7.Visible = true;
            label7.Text = "Новодевичей монастырь";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true;
            pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Метро Киевская";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox18.Visible = true;
            pictureBox17.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label6.Visible = true;
            label5.Visible = false;
            label7.Visible = true;
            label7.Text = "МИД";
            pictureBox18.Location = new Point(417, 289);
            label6.Location = new Point(511, 305);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true;
            pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
            label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Парк Горького";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true;
            pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = true; label3.Visible = true; label4.Visible = true;
            label5.Visible = false; label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Здания РАН";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            label7.Visible = true;
            label7.Text = "Метро Воробевы горы";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true; pictureBox15.Visible = true; pictureBox16.Visible = true; pictureBox17.Visible = true; pictureBox18.Visible = true;
            label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true;
            label7.Visible = true;
            label7.Text = "Стадион Лужники";
            pictureBox18.Location = new Point(417, 368);
            label6.Location = new Point(511, 383);
            label8.Visible = false; label9.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false; pictureBox15.Visible = false; pictureBox16.Visible = false; pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label8.Visible = true; label9.Visible = true;
            label8.Text = "Старт марафона";
            label9.Text = "Полный маршрут:40 киллометров";
            label7.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false; pictureBox15.Visible = false; pictureBox16.Visible = false; pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label8.Visible = true; label9.Visible = true;
            label8.Text = "Старт марафона";
            label9.Text = "Часть маршрута:20 киллометров";
            label7.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false; pictureBox15.Visible = false; pictureBox16.Visible = false; pictureBox17.Visible = false; pictureBox18.Visible = false;
            label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
            label8.Visible = true; label9.Visible = true;
            label8.Text = "Старт марафона";
            label9.Text = "Часть маршрута:5 киллометров";
            label7.Visible = false;
        }
    }
}
