using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace mandelbrot_set
{
    public partial class AffineTransformation : Form
    {
        private MainWindow _mw;
        Bitmap bitmap;
        Graphics graphics;
        int xOrigem;
        int yOrigem;
        Point center;
        bool firstClick = true;
        int defaultSegmentSize = 15;
        int currentSegmentSize;
        int defaultOffset = 0;
        int currentOffset;
        System.Timers.Timer myTimer;
        PointF lt; PointF rt; PointF lb; PointF rb;
        int step = 5;
        float angle = (float)(Math.PI * 6 / 180.0);
        float[,] angleMatrix;
        int width;
        PointF rectCenter;


        public AffineTransformation(MainWindow mw)
        {
            InitializeComponent();

            _mw = mw;

            myTimer = new System.Timers.Timer(200);
            myTimer.Elapsed += MyTimerOnElapsed;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            angleMatrix = new float[,]
            {
                {(float)Math.Cos(angle), (float)-Math.Sin(angle), (float)0.0 },
                {(float)Math.Sin(angle), (float)Math.Cos(angle), (float)0.0 },
                {(float)0.0, (float)0.0, (float)1.0 }
            };

            currentSegmentSize = defaultSegmentSize;
            currentOffset = defaultOffset;
            xOrigem = pictureBox1.Width / 2;
            yOrigem = pictureBox1.Height / 2;
            center = new Point(xOrigem, yOrigem);

            DrawSegments(defaultSegmentSize);
        }

        private void MyTimerOnElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            graphics.Clear(Color.White);

            var matrixLT = new float[1, 3] { { lt.X, lt.Y, 1} };
            var matrixLB = new float[1, 3] { { lb.X, lb.Y, 1 } };
            var matrixRT = new float[1, 3] { { rt.X, rt.Y, 1 } };
            var matrixRB = new float[1, 3] { { rb.X, rb.Y, 1 } };

            var secondMatrix = new float[3, 3]
            {
                {1, 0, 0 },
                {0, 1, 0 },
                {-rectCenter.X, -rectCenter.Y, 1 }
            };

            var fourthMatrix = new float[3, 3]
            {
                {1, 0, 0 },
                {0, 1, 0 },
                {rectCenter.X, rectCenter.Y, 1 }
            };

            var flag = currentOffset > 0;

            var r = MatrixMultiplication(matrixLT, secondMatrix);
            r = MatrixMultiplication(r, angleMatrix);
            r = MatrixMultiplication(r, fourthMatrix);

            lt.X = r[0,0]; lt.Y = flag ? r[0, 1] + step : r[0, 1];

            r = MatrixMultiplication(matrixLB, secondMatrix);
            r = MatrixMultiplication(r, angleMatrix);
            r = MatrixMultiplication(r, fourthMatrix);
            lb.X = r[0, 0]; lb.Y = flag ? r[0, 1] + step : r[0, 1];

            r = MatrixMultiplication(matrixRT, secondMatrix);
            r = MatrixMultiplication(r, angleMatrix);
            r = MatrixMultiplication(r, fourthMatrix);
            rt.X = r[0, 0]; rt.Y = flag ? r[0, 1] + step : r[0, 1];

            r = MatrixMultiplication(matrixRB, secondMatrix);
            r = MatrixMultiplication(r, angleMatrix);
            r = MatrixMultiplication(r, fourthMatrix);
            rb.X = r[0, 0]; rb.Y = flag ? r[0, 1] + step : r[0, 1];

            PointF[] points = { lt, lb, rb, rt };
            if (flag)
            {
                float x = (float)(lb.X + (rt.X - lb.X) / 2.0);
                float y = (float)(rt.Y + (lb.Y - rt.Y) / 2.0);

                rectCenter = new PointF(x, y);
            }
            if (currentOffset - Math.Abs(step) < 0)
            {
                currentOffset = 0;
            }
            else
            {
                currentOffset -= Math.Abs(step);
            }

            DrawSegmentsWithoutClearing(currentSegmentSize);
            
            graphics.FillPolygon(new SolidBrush(Color.LawnGreen), points);
            graphics.DrawLines(Pens.Green, new PointF[]{lt, lb, rb, rt, lt });


            pictureBox1.Image = bitmap;

        }

        private void DrawSegments(int segmentSize)
        {
            graphics.Clear(Color.White);

            DrawSegmentsWithoutClearing(segmentSize);
            
            pictureBox1.Image = bitmap;

        }

        private void DrawSegmentsWithoutClearing(int segmentSize)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawLine(Pens.Black, new Point(xOrigem, 0), new Point(xOrigem, pictureBox1.Bottom));
            graphics.DrawLine(Pens.Black, new Point(0, yOrigem), new Point(pictureBox1.Right, yOrigem));
            graphics.FillEllipse(Brushes.Black, new Rectangle(new Point(xOrigem - 2, yOrigem - 2), new Size(4, 4)));

            int yTop = center.Y + 7;
            int yBottom = center.Y - 7;

            for (int i = center.X + segmentSize, m = 1; i <= pictureBox1.Width; i += segmentSize, ++m)
            {
                graphics.DrawLine(Pens.Black, i, yTop, i, yBottom);
                graphics.DrawString(m.ToString(), new Font("Arial", 6), new SolidBrush(Color.Black), new PointF(i - 4, yBottom + 16));
            }

            for (int i = center.X - segmentSize, m = -1; i >= 0; i -= segmentSize, --m)
            {
                graphics.DrawLine(Pens.Black, i, yTop, i, yBottom);
                graphics.DrawString(m.ToString(), new Font("Arial", 6), new SolidBrush(Color.Black), new PointF(i - 5, yBottom + 16));
            }

            int xTop = center.X + 7;
            int xBottom = center.X - 7;

            for (int i = center.Y + segmentSize, m = -1; i <= pictureBox1.Height; i += segmentSize, --m)
            {
                graphics.DrawLine(Pens.Black, xTop, i, xBottom, i);
                graphics.DrawString(m.ToString(), new Font("Arial", 6), new SolidBrush(Color.Black), new PointF(xBottom - 14, i - 6));
            }

            for (int i = center.Y - segmentSize, m = 1; i >= 0; i -= segmentSize, ++m)
            {
                graphics.DrawLine(Pens.Black, xTop, i, xBottom, i);
                graphics.DrawString(m.ToString(), new Font("Arial", 6), new SolidBrush(Color.Black), new PointF(xBottom - 14, i - 6));
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            int tb2;
            if (!int.TryParse(textBox9.Text, out tb2))
            {
                errorProvider1.SetError(textBox9, "Значення має бути числом.");
                textBox9.Focus();
                return;
            }
            else if (tb2 < 1)
            {
                errorProvider1.SetError(textBox9, "Значення має бути позитивним числом.");
                textBox9.Focus();
                return;
            }

            errorProvider1.SetError(textBox9, "");

            int newSegmentSize;
            try
            {
                newSegmentSize = int.Parse(textBox9.Text);

            }
            catch (Exception)
            {
                newSegmentSize = defaultSegmentSize;
            }

            currentSegmentSize = newSegmentSize;
            DrawSegments(newSegmentSize);
        }

        private void coordinatesButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstClick = true;

                graphics.Clear(Color.White);
                DrawSegmentsWithoutClearing(currentSegmentSize);

                var x = int.Parse(tbX.Text);
                var y = int.Parse(tbY.Text);

                x = center.X + x * currentSegmentSize;
                y = center.Y - y * currentSegmentSize;
                width = int.Parse(tbWidth.Text);
                var coefficient = width * currentSegmentSize;

                lt = new PointF(x, y);
                lb = new PointF(x, y - coefficient);
                rt = new PointF(x + coefficient, y);
                rb = new PointF(lb.X + coefficient, lb.Y);

                rectCenter = new PointF((float)(x + coefficient / 2.0), (float)(y - coefficient / 2.0));
                PointF[] points = { lt, lb, rb, rt };

                graphics.FillPolygon(new SolidBrush(Color.LawnGreen), points);
                graphics.DrawLines(Pens.Green, new PointF[] { lt, lb, rb, rt, lt });

                pictureBox1.Image = bitmap;
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть початкові значення для квадрата.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
            if (firstClick)
            {
                var offset = tbOffset.Text;
                try
                {
                    if (!String.IsNullOrWhiteSpace(offset))
                    {
                        currentOffset = Math.Abs(int.Parse(offset)) * currentSegmentSize;
                        if (int.Parse(offset) > 0) step = -step;
                    }
                }
                catch (Exception)
                {
                    currentOffset = defaultOffset;
                }
                firstClick = false;
            }

            myTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
        }

        private static float[,] MatrixMultiplication(float[,] matrixA, float[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Множення не можливе! Кількість стовпців першої матриці не рівно кількості рядків другої матриці.");
            }

            var matrixC = new float[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbY.Text = "";
            tbX.Text = "";
            tbWidth.Text = "";
            textBox9.Text = "";
            textBox9.Enabled = true;
            firstClick = true;
            tbOffset.Text = "";
            myTimer.Stop();
            DrawSegments(defaultSegmentSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mw.Show();
            Close();
        }

        private void textBox9_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
