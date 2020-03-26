using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CAR_01
{
    public partial class Form3 : Form
    {
        int panelWidth;
        bool Hidden;
        public Form3()
        {
            InitializeComponent();
            panelWidth = gunaPanel1.Width;
            Hidden = false;
        }
        int counter = 0;
        int len = 0;
        string txt;

        private void Form3_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void gunaPictureBox8_Click(object sender, EventArgs e)
        {
            var a1 = new ProcessStartInfo("chrome.exe");
            a1.Arguments = "https://www.audi.com/en.html";
            Process.Start(a1);
        }

        private void gunaPictureBox12_Click(object sender, EventArgs e)
        {
            var b1 = new ProcessStartInfo("chrome.exe");
            b1.Arguments = "https://www.lamborghini.com/en-en";
            Process.Start(b1);
        }

        private void gunaPictureBox15_Click(object sender, EventArgs e)
        {
            var c1 = new ProcessStartInfo("chrome.exe");
            c1.Arguments = "https://www.ferrari.com/en-EN";
            Process.Start(c1);
        }

        private void gunaPictureBox18_Click(object sender, EventArgs e)
        {
            var d1 = new ProcessStartInfo("chrome.exe");
            d1.Arguments = "https://www.bugatti.com/";
            Process.Start(d1);
        }

        private void gunaPictureBox21_Click(object sender, EventArgs e)
        {
            var e1 = new ProcessStartInfo("chrome.exe");
            e1.Arguments = "https://www.rolls-roycemotorcars.com/en_GB/home.html";
            Process.Start(e1);
        }

        private void gunaPictureBox24_Click(object sender, EventArgs e)
        {
            var f1 = new ProcessStartInfo("chrome.exe");
            f1.Arguments = "https://www.tesla.com/";
            Process.Start(f1);
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            var a2 = new ProcessStartInfo("chrome.exe");
            a2.Arguments = "https://www.youtube.com/channel/UCO5ujNeWRIwP4DbCZqZWcLw";
            Process.Start(a2);
        }

        private void gunaPictureBox11_Click(object sender, EventArgs e)
        {
            var b2 = new ProcessStartInfo("chrome.exe");
            b2.Arguments = "https://www.youtube.com/user/Lamborghini";
            Process.Start(b2);
        }

        private void gunaPictureBox14_Click(object sender, EventArgs e)
        {
            var c2 = new ProcessStartInfo("chrome.exe");
            c2.Arguments = "https://www.youtube.com/user/ferrariworld";
            Process.Start(c2);
        }

        private void gunaPictureBox17_Click(object sender, EventArgs e)
        {
            var d2 = new ProcessStartInfo("chrome.exe");
            d2.Arguments = "https://www.youtube.com/user/BugattiSocial";
            Process.Start(d2);
        }

        private void gunaPictureBox20_Click(object sender, EventArgs e)
        {
            var e2 = new ProcessStartInfo("chrome.exe");
            e2.Arguments = "https://www.youtube.com/user/RollsRoyceMotorCars";
            Process.Start(e2);
        }

        private void gunaPictureBox23_Click(object sender, EventArgs e)
        {
            var f2 = new ProcessStartInfo("chrome.exe");
            f2.Arguments = "https://www.youtube.com/user/TeslaMotors";
            Process.Start(f2);
        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            var a3 = new ProcessStartInfo("chrome.exe");
            a3.Arguments = "https://www.facebook.com/Audi.AG/";
            Process.Start(a3);
        }

        private void gunaPictureBox10_Click(object sender, EventArgs e)
        {
            var b3 = new ProcessStartInfo("chrome.exe");
            b3.Arguments = "https://www.facebook.com/Lamborghini/";
            Process.Start(b3);
        }

        private void gunaPictureBox13_Click(object sender, EventArgs e)
        {
            var c3 = new ProcessStartInfo("chrome.exe");
            c3.Arguments = "https://www.facebook.com/Ferrari/";
            Process.Start(c3);
        }

        private void gunaPictureBox16_Click(object sender, EventArgs e)
        {
            var d3 = new ProcessStartInfo("chrome.exe");
            d3.Arguments = "https://www.facebook.com/bugatti/";
            Process.Start(d3);
        }

        private void gunaPictureBox19_Click(object sender, EventArgs e)
        {
            var e3 = new ProcessStartInfo("chrome.exe");
            e3.Arguments = "https://www.facebook.com/rollsroycemotorcars/";
            Process.Start(e3);
        }

        private void gunaPictureBox22_Click(object sender, EventArgs e)
        {
            var f3 = new ProcessStartInfo("chrome.exe");
            f3.Arguments = "https://www.facebook.com/TeslaMoto/";
            Process.Start(f3);
        }

        private void gunaPictureBox26_Click(object sender, EventArgs e)
        {
            var tui= new ProcessStartInfo("chrome.exe");
            tui.Arguments = "https://www.facebook.com/phuong.lethanh.3158";
            Process.Start(tui);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if(counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
                if (label1.ForeColor == Color.Black)
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;
            } 
            
        }

        private void gunaPictureBox27_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                gunaPanel1.Width = gunaPanel1.Width + 10; 
                if (gunaPanel1.Width >= panelWidth)
                {
                    timer2.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                gunaPanel1.Width = gunaPanel1.Width - 10;
                if (gunaPanel1.Width <= 0)
                {
                    timer2.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
