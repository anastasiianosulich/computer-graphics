using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot_set
{
    public partial class FractalWindow : Form
    {
        private MainWindow _mw;
        private int iterationNumber;
        private Bitmap bitmap;
        private double tb1 = 0;
        private double tb2 = 0;

        public FractalWindow(MainWindow mw)
        {
            InitializeComponent();
            _mw = mw;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            iterationNumber = 100;

            if (!string.IsNullOrEmpty(textBox3.Text)){
                iterationNumber = Convert.ToInt32(textBox3.Text);
            }

            if(!string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Всі частини комплексного числа с мають бути заповнені або порожні.");
                return;
            }
            if (!string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Всі частини комплексного числа с мають бути заповнені або порожні.");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                tb1 = tb2 = 0;
            }
            else
            {
                tb1 = double.Parse(textBox1.Text);
                tb2 = double.Parse(textBox2.Text);
            }

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var u = (i - (pictureBox1.Width / 2.0)) / (pictureBox1.Width / 4.0);
                    double a = (i - (pictureBox1.Width / 2.0)) / (pictureBox1.Width / 4.0) ;
                    double b = (y - (pictureBox1.Height / 2.0)) / (pictureBox1.Height / 4.0) ;
                    var c = new Complex(a, b);
                    var z = new Complex(0, 0);
                    var iterations = 0;
                    do
                    {
                        iterations++;
                        z.Square();
                        z.Add(c);
                        if (z.Magnitude() > 2) break;
                    } while (iterations < iterationNumber);
                    try
                    {
                        if (tb1 != 0 && tb2 != 0)
                        {
                            var m = i + Convert.ToInt32(textBox1.Text);
                            var n = y - Convert.ToInt32(textBox2.Text);
                            if (m >= 0 && n >= 0 && m < bitmap.Width && n < bitmap.Height)
                            {
                                bitmap.SetPixel(m, n, GetColor(iterations));
                            }
                        }
                        else
                        {
                            bitmap.SetPixel(i, y, GetColor(iterations));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Для цієї колірної схеми вказана занадто велика кількість ітерацій. Будь ласка, понизьте к-сть ітерацій.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Будь ласка, згенеруйте спочатку зображення фракталу.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "JPG(*.JPG)|*.jpg";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(fileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 115;
            trackBar1.SmallChange = 5;
            trackBar1.LargeChange = 7;
            trackBar1.UseWaitCursor = false;
            DoubleBuffered = true;

        }

        private Bitmap Zoom(Size size)
        {
            Bitmap bm = new Bitmap(bitmap, bitmap.Width + (bitmap.Width * size.Width / 100), bitmap.Height + (bitmap.Height * size.Height / 100));
            Graphics graphics = Graphics.FromImage(bm);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value > 0)
            {
                pictureBox1.Image = Zoom(new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        private Color GetColor(int iterations)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return iterations < iterationNumber ? Color.Black : Color.White;
                    break;
                case 1:
                    return Color.FromArgb(iterations % 126, iterations % 50 * 5, iterations % 10);
                    break;
                case 2:
                    return iterations < iterationNumber ? Color.FromArgb(iterations % 2 * 28, iterations % 4 * 3, iterations % 2 + 66) : Color.FromArgb(iterations, iterations, iterations);
                    break;
                case 3:
                    return iterations < iterationNumber ? Color.FromArgb(iterations % 15 * 120, iterations % 2, iterations % 2 + 46) : Color.FromArgb(iterations  + 5, iterations % 2, iterations - 9);
                    break;
                default:
                    return iterations < iterationNumber ? Color.Black : Color.White;
                    break;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, null);
                return;
            }
            
            if (double.TryParse(textBox1.Text, out tb1))
            {
                errorProvider1.SetError(textBox1, null);
                pictureBox1.Focus();
            }
            else 
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Введення значення має бути числом.");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, null);
                return;
            }
            if (double.TryParse(textBox2.Text, out tb2))
            {
                errorProvider1.SetError(textBox2, "Значення має бути числом.");
                pictureBox1.Focus();
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, null);
            }
            if (int.TryParse(textBox3.Text, out iterationNumber) && iterationNumber < 1)
            {
                errorProvider1.SetError(textBox3, "Значення має бути додатним числом.");
                textBox3.Focus();
                return;
            }
            if (!int.TryParse(textBox3.Text, out iterationNumber))
            {
                errorProvider1.SetError(textBox3, "Значення має бути числом.");
            }
            else
            {
                errorProvider1.SetError(textBox3, "");

            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            _mw.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gallery = new Gallery(this);
            gallery.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У разі натискання кнопки 'Згенерувати фрактал' без задання параметрів комплексного числа та кількості ітерацій будуть використані дефолтні значення програми. Опісля ви можете здійснити зміну цих параметрів.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
