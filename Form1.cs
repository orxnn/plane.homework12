using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace plane.homework12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        SoundPlayer soundEnis = new SoundPlayer(@"C:\Users\USER\Downloads\enis.wav");
        SoundPlayer soundTurbulans = new SoundPlayer(@"C:\Users\USER\Downloads\turbulans.wav");
        SoundPlayer soundKemerler = new SoundPlayer(@"C:\Users\USER\Downloads\kemerler.wav");
        SoundPlayer soundTesekkurler = new SoundPlayer(@"C:\Users\USER\Downloads\tesekkurler.wav");
        SoundPlayer soundBeep = new SoundPlayer(@"C:\Users\USER\Downloads\beep.wav");

        SoundPlayer soundGas = new SoundPlayer(@"C:\Users\USER\Downloads\tikla.wav");
        SoundPlayer soundBreak = new SoundPlayer(@"C:\Users\USER\Downloads\tikla.wav");
        SoundPlayer soundOnOff = new SoundPlayer(@"C:\Users\USER\Downloads\tikla.wav");

        bool Gas = false;
        bool Rev = false;
        bool isEngineOn = false;


        private void button1_Click(object sender, EventArgs e)
        {
            soundEnis.Play();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            soundTurbulans.Play();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            soundKemerler.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            soundTesekkurler.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soundBeep.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            soundGas.Play();
            if (isEngineOn)
            {
                Gas = true;
                Rev = false;
                timer1.Start();
                timer2.Stop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            soundBreak.Play();
            if (isEngineOn)
            {
                Rev = true;
                Gas = false;
                timer2.Start();
                timer1.Stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            soundOnOff.Play();
            if (isEngineOn == false)
            {
                isEngineOn = true;
                button8.Text = "OFF";
            }
            else
            {
                isEngineOn = false;
                button8.Text = "ON";
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Gas == true && pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
            }
            else
            {
                timer1.Stop();
                Gas = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Rev == true && pictureBox1.Location.Y < panel1.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
            }
            else
            {
                timer2.Stop();
                Rev = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
