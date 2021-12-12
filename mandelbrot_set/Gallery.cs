using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot_set
{
    public partial class Gallery : Form
    {
        private FractalWindow _fw;
        private int imgNumber = 1;

        public Gallery(FractalWindow fw)
        {
            InitializeComponent();
            _fw = fw;
        }

        private void LoadNext()
        {
            timer1.Start();
            imgNumber++;
            if (imgNumber > 5)
            {
                imgNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\lichn\source\repos\mandelbrot_set\mandelbrot_set\Images\" + imgNumber + ".png");
            LoadCheched();
        }

        private void LoadPrevious()
        {
            timer1.Start();
            imgNumber--;
            if (imgNumber < 1)
            {
                imgNumber = 5;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\lichn\source\repos\mandelbrot_set\mandelbrot_set\Images\" + imgNumber + ".png");
            LoadCheched();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNext();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPrevious();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNext();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            cb1.Checked = true;
            pictureBox1.ImageLocation = string.Format(@"C:\Users\lichn\source\repos\mandelbrot_set\mandelbrot_set\Images\" + imgNumber + ".png");

        }

        private void LoadCheched()
        {
            if (imgNumber == 1) cb1.Checked = true;
            else if (imgNumber == 2) cb2.Checked = true;
            else if (imgNumber == 3) cb3.Checked = true;
            else if (imgNumber == 4) cb4.Checked = true;
            else if (imgNumber == 5) cb5.Checked = true;
        }

        private void ChangedCheck()
        {
            timer1.Start();
            if(cb1.Checked == true) { imgNumber = 1; }
            else if (cb2.Checked == true) { imgNumber = 2; }
            else if (cb3.Checked == true) { imgNumber = 3; }
            else if (cb4.Checked == true) { imgNumber = 4; }
            else if (cb5.Checked == true) { imgNumber = 5; }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\lichn\source\repos\mandelbrot_set\mandelbrot_set\Images\" + imgNumber + ".png");
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangedCheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fw.Show();
            Close();
        }
    }
}
