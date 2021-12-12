
namespace mandelbrot_set
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.sqbtn = new System.Windows.Forms.Button();
            this.cmbtn = new System.Windows.Forms.Button();
            this.fractalbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Image = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_132146;
            this.button4.Location = new System.Drawing.Point(606, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 35);
            this.button4.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button4, "Дізнатися більше");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sqbtn
            // 
            this.sqbtn.Image = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_131858;
            this.sqbtn.Location = new System.Drawing.Point(468, 594);
            this.sqbtn.Name = "sqbtn";
            this.sqbtn.Size = new System.Drawing.Size(136, 92);
            this.sqbtn.TabIndex = 4;
            this.sqbtn.UseVisualStyleBackColor = true;
            this.sqbtn.Click += new System.EventHandler(this.sqbtn_Click_1);
            // 
            // cmbtn
            // 
            this.cmbtn.Image = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_131848;
            this.cmbtn.Location = new System.Drawing.Point(284, 594);
            this.cmbtn.Name = "cmbtn";
            this.cmbtn.Size = new System.Drawing.Size(133, 93);
            this.cmbtn.TabIndex = 3;
            this.cmbtn.UseVisualStyleBackColor = true;
            this.cmbtn.Click += new System.EventHandler(this.cmbtn_Click_1);
            // 
            // fractalbtn
            // 
            this.fractalbtn.BackgroundImage = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_132106;
            this.fractalbtn.Location = new System.Drawing.Point(97, 593);
            this.fractalbtn.Name = "fractalbtn";
            this.fractalbtn.Size = new System.Drawing.Size(133, 93);
            this.fractalbtn.TabIndex = 2;
            this.fractalbtn.UseVisualStyleBackColor = true;
            this.fractalbtn.Click += new System.EventHandler(this.fractalbtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox2.Image = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_1232511;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(684, 978);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(680, 699);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sqbtn);
            this.Controls.Add(this.cmbtn);
            this.Controls.Add(this.fractalbtn);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button fractalbtn;
        private System.Windows.Forms.Button cmbtn;
        private System.Windows.Forms.Button sqbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}