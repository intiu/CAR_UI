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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cpt = 1;
        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Add(6);

            gunaDataGridView1.Rows[0].Cells[0].Value = Image.FromFile("img_car\\1.png");
            gunaDataGridView1.Rows[1].Cells[0].Value = Image.FromFile("img_car\\2.png");
            gunaDataGridView1.Rows[2].Cells[0].Value = Image.FromFile("img_car\\3.png");
            gunaDataGridView1.Rows[3].Cells[0].Value = Image.FromFile("img_car\\4.png");
            gunaDataGridView1.Rows[4].Cells[0].Value = Image.FromFile("img_car\\5.png");
            gunaDataGridView1.Rows[5].Cells[0].Value = Image.FromFile("img_car\\6.png");


            gunaDataGridView1.Rows[0].Cells[1].Value = "Audi";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Lamborghini";          
            gunaDataGridView1.Rows[2].Cells[1].Value = "Ferrari";
            gunaDataGridView1.Rows[3].Cells[1].Value = "Bugatti";
            gunaDataGridView1.Rows[4].Cells[1].Value = "Roll Royce";
            gunaDataGridView1.Rows[5].Cells[1].Value = "Tesla";

            gunaDataGridView1.Rows[0].Cells[2].Value = "59.000 USD";
            gunaDataGridView1.Rows[1].Cells[2].Value = "362.000 USD";
            gunaDataGridView1.Rows[2].Cells[2].Value = "215.000 USD";
            gunaDataGridView1.Rows[3].Cells[2].Value = "600.000 USD";
            gunaDataGridView1.Rows[4].Cells[2].Value = "600.000 USD";
            gunaDataGridView1.Rows[5].Cells[2].Value = "78.000 USD";

            gunaDataGridView1.Rows[0].Cells[3].Value = "305 KM/H";
            gunaDataGridView1.Rows[1].Cells[3].Value = "413 KM/H";
            gunaDataGridView1.Rows[2].Cells[3].Value = "340 KM/H";
            gunaDataGridView1.Rows[3].Cells[3].Value = "490 KM/H";
            gunaDataGridView1.Rows[4].Cells[3].Value = "300 KM/H";
            gunaDataGridView1.Rows[5].Cells[3].Value = "100 KM/H";

            gunaDataGridView1.Rows[0].Cells[4].Value = "Là công ty nước Đức\n " +
                "Người sáng lập là August Horch\n" +
                "Thành lập năm 1909\n" +
                "Website: Audi.com";
            gunaDataGridView1.Rows[1].Cells[4].Value = "Là nhà sản xuất siêu xe thể thao cao cấp của Italy\n" +
                "Thành lập năm 1963 bởi Ferruccio Lamborghini\n" +
                "Công ty mẹ: Audi\n" +
                "Website: www.lamborghini.com";
            gunaDataGridView1.Rows[2].Cells[4].Value = "Là một công ty sản xuất siêu xe thể thao của Ý\n" +
                "do Enzo Ferrari sáng lập năm 1929\n" +
                "Công ty mẹ: Fiat S.p.A\n" +
                "Website: www.ferrari.com";
            gunaDataGridView1.Rows[3].Cells[4].Value = "Là nhà sản xuất ô tô hiệu suất cao của Pháp\n" +
                "Thành lập năm 1909\n" +
                "Người sáng lập là Ettore Bugatti\n" +
                "Website: bugatti.com";
            gunaDataGridView1.Rows[4].Cells[4].Value = "Là một thương hiệu của Anh, " +
                "Thành lập tháng 3/1998\n" +
                "Người sáng lập: Henry Royce và Charles Stewart Rolls\n" +
                "Chi nhánh của BMW\n" +
                "Website: www.rolls-roycemotorcars.com";
            gunaDataGridView1.Rows[5].Cells[4].Value = "Là một công ty của Mỹ chuyên thiết kế\n" +
                "sản xuất và phân phối sản phẩm ô tô điện\n" +
                "Thành lập năm 2003\n" +
                "Người sáng lập Elon Musk\n" +
                "Website: Tesla.com";

            gunaDataGridView1.Rows[0].Cells[5].Value = "60";
            gunaDataGridView1.Rows[1].Cells[5].Value = "85";
            gunaDataGridView1.Rows[2].Cells[5].Value = "77";
            gunaDataGridView1.Rows[3].Cells[5].Value = "80";
            gunaDataGridView1.Rows[4].Cells[5].Value = "50";
            gunaDataGridView1.Rows[5].Cells[5].Value = "43";

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < gunaDataGridView1.Rows.Count)
            {
                cpt++;
                gunaPictureBox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabel1.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                gunaLabel8.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                gunaLabel6.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                gunaLabel5.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                gunaLabel4.Text = gunaDataGridView1.Rows[cpt - 1].Cells[5].Value.ToString();
                gunaPictureBox1.Load("img_car\\"   + cpt.ToString() + "b.png");
                gunaPictureBox2.Load("img_car\\"   + cpt.ToString() + "c.png");
                gunaPictureBox3.Load("img_car\\" + cpt.ToString() + "d.png");
                gunaPictureBox4.Load("img_car\\" + cpt.ToString() + "a.png");
            }
            else cpt = 1;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt >1)
            {
                cpt--;
                gunaPictureBox.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabel1.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                gunaLabel8.Text = gunaDataGridView1.Rows[cpt - 1].Cells[2].Value.ToString();
                gunaLabel6.Text = gunaDataGridView1.Rows[cpt - 1].Cells[3].Value.ToString();
                gunaLabel5.Text = gunaDataGridView1.Rows[cpt - 1].Cells[4].Value.ToString();
                gunaLabel4.Text = gunaDataGridView1.Rows[cpt - 1].Cells[5].Value.ToString();
                gunaPictureBox1.Load("img_car\\"  + cpt.ToString() + "b.png");
                gunaPictureBox2.Load("img_car\\"  + cpt.ToString() + "c.png");                
                gunaPictureBox3.Load("img_car\\" + cpt.ToString() + "d.png");
                gunaPictureBox4.Load("img_car\\" + cpt.ToString() + "a.png");
            }
            else cpt = 1;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = gunaPictureBox1.Image;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = gunaPictureBox2.Image;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = gunaPictureBox3.Image;
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            /*var prs = new ProcessStartInfo("msedge.exe");
            prs.Arguments = "http://bing.com";
            Process.Start(prs);*/
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();           
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }
    }
}
