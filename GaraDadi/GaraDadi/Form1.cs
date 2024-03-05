using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraDadi
{
    public partial class Form1 : Form
    {
        Gara gara;

        public Form1()
        {
            InitializeComponent();
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            button1.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Inserimento giocatore1

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//Inserimento giocatore2

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {//current giocatore1

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {//current giocatore2

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {//partite che rimangono al termine della gara

        }

        private void button1_Click(object sender, EventArgs e)
        {//AVVIA MATCH
            gara.Round();

            textBox7.Text = Convert.ToString(gara.G1GetNum());
            textBox8.Text = Convert.ToString(gara.G2GetNum());

            textBox4.Text = Convert.ToString(gara.G1GetPoints());
            textBox5.Text = Convert.ToString(gara.G2GetPoints());
        }

        private void button2_Click(object sender, EventArgs e)
        {//START GAME
            this.BackgroundImage = Image.FromFile("C:\\Users\\aless\\OneDrive\\Desktop\\GiocoDadiCsharp\\GaraDadi\\unnamed1.jpg");
            gara = new Gara(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox6.Text));

            label1.Visible = false;
            label2.Visible = false;
            label3.Text = "PARTITE RIMANENTI";

            button2.Visible = false; //bottone START GAMEE
            button1.Visible = true;

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {//numero generato da giocatore 2

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//lancio dado giocatore2

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {//numero generato da giocatore 1

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
