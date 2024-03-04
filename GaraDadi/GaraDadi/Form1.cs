using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Inserimento giocatore1
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//Inserimento giocatore2
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {//Visualizza numero ottenuto dal lancio 

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
        {
            gara.Round();

            textBox3.Text = Convert.ToString(gara.GetNumeroGenerato());
            textBox4.Text = Convert.ToString(gara.G1GetPoints());
            textBox5.Text = Convert.ToString(gara.G2GetPoints());
        }

        private void button2_Click(object sender, EventArgs e)
        {//Start Game...
            gara = new Gara(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox6.Text));
            label1.Visible= false;
            label2.Visible = false;
            label3.Text = "PARTITE RIMANENTI";

            button2.Visible= false;

            textBox3.Visible = true;
            textBox3.Text = "";

            textBox4.Visible = true;
            textBox4.Text = Convert.ToString(gara.G1GetPoints());

            textBox5.Visible = true;
            textBox5.Text = Convert.ToString(gara.G2GetPoints());

            button1.Visible = true;

            label4.Visible= true;
            label5.Visible= true;
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
        {

        }
    }
}
