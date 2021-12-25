using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace SoundTrackerBox
{
    public partial class Form1 : Form
    {
        SoundTrackerBox _trackbox = new SoundTrackerBox();
        Thread rhead2;
        Thread rhead1;
        public Form1()
        {
            InitializeComponent();
        }

        private void PatternA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/tankarmee/SoundTrackerBox");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatternA.MaxLength = Convert.ToInt32(PatternLength.Text);

            PatternB.MaxLength = Convert.ToInt32(PatternLength.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                rhead2 = new Thread(() =>
                _trackbox.PlayWheepMachine(Convert.ToInt32(PatternLength.Text), Convert.ToInt32(LetterDelay.Text), PatternA.Text));
                rhead2.Start();
            }
            if (checkBox2.Checked == true)
            {
                rhead1 = new Thread(() => _trackbox.PlayBassMachine(Convert.ToInt32(PatternLength.Text), Convert.ToInt32(LetterDelay.Text), PatternB.Text));/*
                _trackbox.PlayBassMachine(Convert.ToInt32(PatternLength.Text), Convert.ToInt32(LetterDelay.Text), PatternB.Text);*/
                rhead1.Start();
            }
            /*if()
            {
                MessageBox.Show("No active patterns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatternA.Text = null;
            PatternB.Text = null;
            var rand = new Random();
            for(int i = 0; i < Convert.ToInt32(PatternLength.Text); i++)
            {
                int w = rand.Next(1, 5);
                PatternA.Text += w.ToString();
                int b = rand.Next(1, 5);
                PatternB.Text += b.ToString();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            rhead2.Abort();
            rhead1.Abort();
        }
    }
}
