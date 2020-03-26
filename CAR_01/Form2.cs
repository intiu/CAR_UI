using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text);
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=GGRi85kK4n4");
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=fKNdoxRld34&t=1s");
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=iRsV6YpLsKA&t=1s");
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=FBXyErMqQgw&t=34s");
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=Q0_sNuA9VUk&t=2s");
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com/watch?v=i8horkJjxco&t=45s");
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch
            {

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBox1.Text = webBrowser1.Url.ToString();
        }

        private void gunaPictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void gunaPictureBox10_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
