using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using System.Windows.Media.Imaging;
using ColorModels.Code;
using MessageBox = System.Windows.Forms.MessageBox;
using mandelbrot_set;

namespace ColorModels
{
    public partial class ColorModelsForm : Form
    {
        private MainWindow _mw;
        private BitmapImage Image;
        private Bitmap original;
        private Bitmap cmykBitmap;

        private BitmapImage HSLImage;

        private int stride = 0;
        private int size = 0;

        byte[] pixels;
        private byte[] pixelsHSL;

        public ColorModelsForm(MainWindow mw)
        {
            InitializeComponent();
            trackBar1.Value = 50;
            tb_label.Text = trackBar1.Value.ToString();
            _mw = mw;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    original = new Bitmap(dialog.FileName);
                    int w = original.Width; int h = original.Height;
                    Bitmap cyan = new Bitmap(w, h);
                    Bitmap magenta = new Bitmap(w, h);
                    Bitmap yellow = new Bitmap(w, h);
                    Bitmap key = new Bitmap(w, h);
                    for (int i = 0; i < h; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            Color pixel = original.GetPixel(j, i);

                            double r = pixel.R / 255.0;
                            double g = pixel.G / 255.0;
                            double b = pixel.B / 255.0;

                            double kr = 1.0 - Math.Max(r, Math.Max(g, b));
                            double cr = (1.0 - r - kr) / (1.0 - kr + 0.000000001);
                            double mr = (1.0 - g - kr) / (1.0 - kr + 0.000000001);
                            double yr = (1.0 - b - kr) / (1.0 - kr + 0.000000001);

                            int c = Convert.ToInt32(cr * 255);
                            int m = Convert.ToInt32(mr * 255);
                            int y = Convert.ToInt32(yr * 255);
                            int k = Convert.ToInt32(kr * 255);

                            Color cPix = Color.FromArgb(c, Color.Cyan);
                            Color mPix = Color.FromArgb(m, Color.Magenta);
                            Color yPix = Color.FromArgb(y, Color.Yellow);
                            Color kPix = Color.FromArgb(k, Color.Black);

                            cyan.SetPixel(j, i, cPix);
                            magenta.SetPixel(j, i, mPix);
                            yellow.SetPixel(j, i, yPix);
                            key.SetPixel(j, i, kPix);
                        }
                    }
                    Bitmap bitmap = CombineBitmap(new List<Bitmap> { cyan, magenta, yellow, key }, w, h);
                    
                    Image = new BitmapImage(new Uri(dialog.FileName));
                    stride = Image.PixelWidth * 4;
                    size = Image.PixelHeight * stride;
                    pixels = new byte[size];

                    pictureBox1.Image = original;
                    pictureBox2.Image = original;

                    cmykBitmap = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "  " +  ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private  Bitmap CombineBitmap(IEnumerable<Bitmap> bitmaps, int  w, int h)
        {
            Bitmap finalImage = null;
            try
            {
                finalImage = new Bitmap(w, h);
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Transparent);

                    foreach (Bitmap image in bitmaps)
                    {
                        g.DrawImage(image, new Rectangle(0, 0, w, h));
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null) finalImage.Dispose();
                throw;
            }
        }

        private void ConvertToRgbFromHsl()
        {
            pixelsHSL = new byte[size];

            Image.CopyPixels(pixelsHSL, stride, 0);
            for (int i = 0; i < size; i += 4)
            {
                if (i + 4 < pixels.Length)
                {
                    Color color = Color.FromArgb(pixelsHSL[i + 2], pixelsHSL[i + 1], pixelsHSL[i]);
                    double[] hsl = ColorConverter.RgbToHsl(pixelsHSL[i + 2], pixelsHSL[i + 1], pixelsHSL[i], trackBar1.Value.ToString());
                    byte[] RGB = ColorConverter.HslToRgb(hsl[0], hsl[1], hsl[2]);
                    pixelsHSL[i] = RGB[2];
                    pixelsHSL[i + 1] = RGB[1];
                    pixelsHSL[i + 2] = RGB[0];
                }
            }
            WriteableBitmap newImage = new WriteableBitmap(Image.PixelWidth, Image.PixelHeight, Image.DpiX, Image.DpiY, System.Windows.Media.PixelFormats.Bgr32, Image.Palette);
            newImage.WritePixels(new Int32Rect(0, 0, Image.PixelWidth, Image.PixelHeight), pixelsHSL, stride, 0);
            BitmapImage hslImg;
            using (MemoryStream stream = new MemoryStream())
            {
                hslImg = new BitmapImage();
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(newImage));
                encoder.Save(stream);
                hslImg.BeginInit();
                hslImg.CacheOption = BitmapCacheOption.OnLoad;
                hslImg.StreamSource = stream;
                hslImg.EndInit();
                hslImg.Freeze();
            }
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(hslImg));
                enc.Save(outStream);
                if (comboBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = new Bitmap(outStream);
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    pictureBox2.Image = new Bitmap(outStream);
                    HSLImage = hslImg;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = original;
                    break;
                case 1:
                    pictureBox1.Image = cmykBitmap;
                    break;
                case 2:
                    ConvertToRgbFromHsl();
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image = original;
                    break;
                case 1:
                    pictureBox2.Image = cmykBitmap;
                    break;
                case 2:
                    ConvertToRgbFromHsl();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Image == null)
            {
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (comboBox2.SelectedIndex == 2)
            {
                saveFileDialog.Filter = "Image file (*.png) | *.png";
            }
            else
            {
                saveFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (comboBox2.SelectedIndex == 2)
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        PngBitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(HSLImage));
                        encoder.Save(stream);
                    }
                }
                else
                {
                    pictureBox2.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try { 
            var bitmap = new Bitmap(pictureBox1.Image);
            int x = e.X;
            int y = e.Y;
            Color c = bitmap.GetPixel(x, y);
            pictureBox3.BackColor = c;
            var originalColor = original.GetPixel(x, y);

            int r = originalColor.R; int g = originalColor.G; int b = originalColor.B; int a = originalColor.A;

            string rgb = $"R: {r}   G: {g}   B: {b}   A:{a}";

            var cmykColors = RGBtoCMYK(r, g, b);

            var cmyk = String.Format("C: {0:d}   M: {1:d}   Y: {2:d}   K: {3:d}", (int)(cmykColors.Cyan * 100), (int)(cmykColors.Magenta * 100), (int)(cmykColors.Yellow * 100), (int)(cmykColors.Black * 100));
            var hsl = String.Format("H: {0:f2}   S: {1:f2}   L: {2:f2}", originalColor.GetHue(), originalColor.GetSaturation(), originalColor.GetBrightness());

            label2.Text = rgb;
            label3.Text = cmyk;
            label4.Text = hsl;
            }
            catch
            {

            }
        }

        public static CMYK RGBtoCMYK(int red, int green, int blue)
        {
            // normalizes red, green, blue values
            float c = (float)(255 - red) / 255;
            float m = (float)(255 - green) / 255;
            float y = (float)(255 - blue) / 255;

            float k = (float)Math.Min(c, Math.Min(m, y));

            if (k == 1.0)
            {
                return new CMYK(0, 0, 0, 1);
            }
            else
            {
                return new CMYK((c - k) / (1 - k), (m - k) / (1 - k), (y - k) / (1 - k), k);
            }
        }

        public static HSL RGBtoHSL(int red, int green, int blue)
        {
            double h = 0, s = 0, l = 0;

            // normalize red, green, blue values
            double r = (double)red / 255.0;
            double g = (double)green / 255.0;
            double b = (double)blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // hue
            if (max == min)
            {
                h = 0; // undefined
            }
            else if (max == r && g >= b)
            {
                h = 60.0 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                h = 60.0 * (g - b) / (max - min) + 360.0;
            }
            else if (max == g)
            {
                h = 60.0 * (b - r) / (max - min) + 120.0;
            }
            else if (max == b)
            {
                h = 60.0 * (r - g) / (max - min) + 240.0;
            }

            // luminance
            l = (max + min) / 2.0;

            // saturation
            if (l == 0 || max == min)
            {
                s = 0;
            }
            else if (0 < l && l <= 0.5)
            {
                s = (max - min) / (max + min);
            }
            else if (l > 0.5)
            {
                s = (max - min) / (2 - (max + min)); //(max-min > 0)?
            }

            return new HSL(
                Double.Parse(String.Format("{0:0.##}", h)),
                Double.Parse(String.Format("{0:0.##}", s)),
                Double.Parse(String.Format("{0:0.##}", l))
                );
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            pictureBox3.BackColor = Color.Empty;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            pictureBox3.BackColor = Color.Empty;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            try { 
            var bitmap = new Bitmap(pictureBox2.Image);
            int x = e.X;
            int y = e.Y;
            Color c = bitmap.GetPixel(x, y);
            pictureBox3.BackColor = c;
            var originalColor = original.GetPixel(x, y);

            int r = originalColor.R; int g = originalColor.G; int b = originalColor.B; int a = originalColor.A;

            string rgb = $"R: {r}   G: {g}   B: {b}   A:{a}";
            var cmykColors = RGBtoCMYK(r, g, b);
            var cmyk = String.Format("C: {0:d}   M: {1:d}   Y: {2:d}   K: {3:d}", (int)(cmykColors.Cyan * 100), (int)(cmykColors.Magenta*100), (int)(cmykColors.Yellow * 100), (int)(cmykColors.Black * 100));
            var hsl = String.Format("H: {0:f2}   S: {1:f2}   L: {2:f2}", originalColor.GetHue(), originalColor.GetSaturation(), originalColor.GetBrightness());

            label2.Text = rgb;
            label3.Text = cmyk;
            label4.Text = hsl;
            }
            catch(Exception ex)
            {
                var b = ex.Message;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_label.Text = trackBar1.Value.ToString();

            if (pictureBox1.Image == null || pictureBox2.Image==null || Image == null)
            {
                return;
            }

            pixelsHSL = new byte[size];

            Image.CopyPixels(pixelsHSL, stride, 0);
            for (int i = 0; i < size; i += 4)
            {
                if (i + 4 < pixels.Length)
                {
                    Color color = Color.FromArgb(pixelsHSL[i + 2], pixelsHSL[i + 1], pixelsHSL[i]);
                    double[] hsl = ColorConverter.RgbToHsl(pixelsHSL[i + 2], pixelsHSL[i + 1], pixelsHSL[i], trackBar1.Value.ToString());
                    byte[] RGB = ColorConverter.HslToRgb(hsl[0], hsl[1], hsl[2]);
                    pixelsHSL[i] = RGB[2];
                    pixelsHSL[i + 1] = RGB[1];
                    pixelsHSL[i + 2] = RGB[0];
                }
            }
            WriteableBitmap newImage = new WriteableBitmap(Image.PixelWidth, Image.PixelHeight, Image.DpiX, Image.DpiY, System.Windows.Media.PixelFormats.Bgr32, Image.Palette);
            newImage.WritePixels(new Int32Rect(0, 0, Image.PixelWidth, Image.PixelHeight), pixelsHSL, stride, 0);
            BitmapImage hslImg;
            using (MemoryStream stream = new MemoryStream())
            {
                hslImg = new BitmapImage();
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(newImage));
                encoder.Save(stream);
                hslImg.BeginInit();
                hslImg.CacheOption = BitmapCacheOption.OnLoad;
                hslImg.StreamSource = stream;
                hslImg.EndInit();
                hslImg.Freeze();
            }

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(hslImg));
                enc.Save(outStream);
                if(comboBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = new Bitmap(outStream);
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    HSLImage = hslImg;
                    pictureBox2.Image = new Bitmap(outStream);
                }
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            _mw.Show();
            Close();
        }
    }
}
