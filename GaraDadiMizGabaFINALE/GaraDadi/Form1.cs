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
using System.Reflection.Emit;
using GaraDadi.Properties;

namespace GaraDadi
{
    public partial class Form1 : Form
    {
        Gara gara;

        public Form1()
        {
            InitializeComponent();
            IncreaseFormGradually();

            label9.Visible = false;
            label8.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//INSERTION PLAYER 1

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//INSERTION PLAYER 2

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {//current PLAYER 1

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {//current PLAYER 2

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {//REMAINING MATCHES

        }

        private async void button1_Click(object sender, EventArgs e)
        {//ROLL DICE
            gara.Round();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            button4.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            //LOOP FOR SCROLLING THE IMAGES IN THE PICTUREBOXES
            pictureBox1.Image = Properties.Resources._1;
            pictureBox2.Image = Properties.Resources._6;
            await Task.Delay(250);

            pictureBox1.Image = Properties.Resources._2;
            pictureBox2.Image = Properties.Resources._5;
            await Task.Delay(250);

            pictureBox1.Image = Properties.Resources._3;
            pictureBox2.Image = Properties.Resources._4;
            await Task.Delay(250);

            pictureBox1.Image = Properties.Resources._4;
            pictureBox2.Image = Properties.Resources._3;
            await Task.Delay(250);

            pictureBox1.Image = Properties.Resources._5;
            pictureBox2.Image = Properties.Resources._2;
            await Task.Delay(250);

            pictureBox1.Image = Properties.Resources._6;
            pictureBox2.Image = Properties.Resources._1;
            await Task.Delay(250);

            switch (gara.G1GetNum())
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
            }

            switch (gara.G2GetNum())
            {
                case 1:
                    pictureBox2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources._6;
                    break;
            }

            //CURRENT PLAYERS' POINTS
            textBox4.Text = Convert.ToString(gara.G1GetPoints());
            textBox5.Text = Convert.ToString(gara.G2GetPoints());

            if (gara.FineGara())
            {
                await Task.Delay(1000);
                label8.Visible = true;

                if (gara.GameWin() == "pareggio")
                {
                    label8.Text = "TIE";
                }
                else
                {
                    label8.Text = ($"THE WINNER IS {gara.GameWin()}!");
                }

                button1.Visible = false;
                button4.Visible = false;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }

            textBox6.Text = Convert.ToString(gara.GetPartiteRimanenti);
            button4.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {//START GAME
            textBox4.Text = Convert.ToString(0);
            textBox5.Text = Convert.ToString(0);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox6.Text == "")
            {
                //VISUALIZE ERROR MESSAGE FOR 2 SECONDS
                label9.Text = "All fields must be filled before you can play!";
                label9.Visible = true;
                await Task.Delay(2000);
                label9.Visible = false;
            }
            else
            {
                if (textBox6.Text.Any(char.IsDigit) == true)
                {
                    IncreaseFormGradually();

                    pictureBox4.Visible = false;
                    button2.Visible = false;
                    label1.Text = "PLAYER 1";
                    label2.Text = "PLAYER 2";
                    label3.Text = "REMAINING MATCHES";

                    gara = new Gara(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox6.Text));
                }
                else if (textBox1.Text == textBox2.Text)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";

                    //VISUALIZE ERROR MESSAGE FOR 2 SECONDS
                    label9.Text = "Player's names must be different";
                    label9.Visible = true;
                    await Task.Delay(2000);
                    label9.Visible = false;
                }
                else
                {
                    textBox6.Text = "";

                    //VISUALIZE ERROR MESSAGE FOR 2 SECONDS
                    label9.Text = "Invalid value entered!";
                    label9.Visible = true;
                    await Task.Delay(2000);
                    label9.Visible = false;
                }
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
        {

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
        {

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
        {

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
        {//CLICK TO PLAY
            pictureBox3.Visible = false;
            button3.Visible = false;

            IncreaseFormGradually();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {//RESET GAME
            gara.ResetGame();

            textBox6.Text = Convert.ToString(gara.GetPartiteRimanenti);//Reset the remaining games to the ones the user specified they wanted to play previously

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            textBox4.Text = Convert.ToString(0);
            textBox5.Text = Convert.ToString(0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private async void IncreaseFormGradually()
        {
            this.Opacity = 0;

            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                this.Refresh();
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
