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
using System.Threading;
using System.Xml.Serialization;

namespace GaraDadi
{
    public partial class Form1 : Form
    {
        Gara gara;

        public Form1()
        {
            InitializeComponent();

            AumentaFormGradualmente();

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            button1.Visible = false;
            button4.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
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

        private async void button1_Click(object sender, EventArgs e)
        {//LANCIA DADI
            gara.Round();

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 1; i<7; i++)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, $"{i}.jpg")); //imageList1.Images[n] sfuoca le immagini
                pictureBox2.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, $"{7 - i}.jpg")); //imageList1.Images[n] sfuoca le immagini
 
                await Task.Delay(500);
            }

            pictureBox1.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, $"{gara.G1GetNum()}.jpg")); //imageList1.Images[n] sfuoca le immagini
            pictureBox2.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, $"{gara.G2GetNum()}.jpg")); //imageList1.Images[n] sfuoca le immagini
        
            textBox7.Text = Convert.ToString(gara.G1GetNum());
            textBox8.Text = Convert.ToString(gara.G2GetNum());

            textBox4.Text = Convert.ToString(gara.G1GetPoints());
            textBox5.Text = Convert.ToString(gara.G2GetPoints());

            if (gara.FineGara())
            {
                textBox3.Visible = true;

                if (gara.GameWin() == "pareggio")
                {
                    textBox3.Text = "PAREGGIO";
                }
                else
                {
                    textBox3.Text = ($"VINCITORE: {gara.GameWin()}");
                }

                button1.Visible = false;
                button4.Visible = false;
            }

            textBox6.Text = Convert.ToString(gara.GetPartiteRimanenti);
        }

        private async void button2_Click(object sender, EventArgs e)
        {//START GAME
            if (textBox1.Text == "" || textBox2.Text == "" || textBox6.Text == "")
            {
                label9.Visible = true;
                await Task.Delay(2000);
                label9.Visible = false;
            }
            else
            {
                AumentaFormGradualmente();
                pictureBox4.Visible = false;

                gara = new Gara(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox6.Text));

                label1.Visible = false;
                label2.Visible = false;
                label3.Text = "PARTITE RIMANENTI";

                button2.Visible = false;
                button1.Visible = true;
                button4.Visible = true;

                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {//FARE CLICK PER INIZIARE
            pictureBox3.Visible = false;
            button3.Visible = false;

            AumentaFormGradualmente();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {//RESET GAME
            gara.ResetGame();

            textBox6.Text = Convert.ToString(gara.GetPartiteRimanenti);
            textBox7.Text = "";
            textBox8.Text = "";

            textBox4.Text = Convert.ToString(0);
            textBox5.Text = Convert.ToString(0);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private async void AumentaFormGradualmente()
        {
            this.Opacity = 0;

            // Gradualmente aumenta l'opacità del form
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                this.Refresh();
                await Task.Delay(50); 
            }
        }

        private async void DiminuisciFormGradualmente()
        {
            this.Opacity = 1;

            // Gradualmente diminuisce l'opacità del form
            for (double opacity = 1; opacity >= 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(50);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
