using System.Drawing;
using System.Windows.Forms;

namespace mandelbrot_set
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fractalbtn_Click_1(object sender, System.EventArgs e)
        {
            var fractalWdw = new FractalWindow(this);
            fractalWdw.Show();
            Hide();
        }

        private void cmbtn_Click_1(object sender, System.EventArgs e)
        {
            var colorWdw = new ColorModels.ColorModelsForm(this);
            colorWdw.Show();
            Hide();
        }

        private void sqbtn_Click_1(object sender, System.EventArgs e)
        {
            var tr = new AffineTransformation(this);
            tr.Show();
            Hide();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var info = new InfoForm();
            info.ShowDialog();
        }
    }
}
