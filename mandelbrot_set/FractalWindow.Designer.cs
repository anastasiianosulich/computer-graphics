
namespace mandelbrot_set
{
    partial class FractalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tooltipforcomplexnumber = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipforiterations = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 741);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФРАКТАЛ МАНДЕЛЬБРОТА\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "f(z) = z ^ 2 + c";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(1018, 676);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 69);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(1018, 569);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(141, 69);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Зберегти як файл";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generate_button.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_button.Location = new System.Drawing.Point(1018, 461);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(141, 69);
            this.generate_button.TabIndex = 5;
            this.generate_button.Text = "Згенерувати фрактал";
            this.generate_button.UseVisualStyleBackColor = false;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(939, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "c = ";
            this.tooltipforcomplexnumber.SetToolTip(this.label3, "Параметр є комплексним числом. Задайте, будь ласка, дійсну й уявну частини");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Location = new System.Drawing.Point(1003, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1061, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "+  i * ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.Location = new System.Drawing.Point(1134, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 30);
            this.textBox2.TabIndex = 9;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGreen;
            this.textBox3.Location = new System.Drawing.Point(1134, 237);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 31);
            this.textBox3.TabIndex = 10;
            this.tooltipforiterations.SetToolTip(this.textBox3, "Задайте необхідну кількість ітерацій для функції.");
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(939, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "кількість ітерацій - ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(930, 382);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(284, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(46, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 744);
            this.panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "чорно-біла",
            "симфонія лісу",
            "чарівний ранок",
            "невимовна радість"});
            this.comboBox1.Location = new System.Drawing.Point(944, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 36);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "чорно-біла";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(939, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "оберіть колірну схему - ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(979, 761);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "Переглянути галерею кольорів фракталу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = global::mandelbrot_set.Properties.Resources.Знімок_екрана_2021_12_11_132146;
            this.button4.Location = new System.Drawing.Point(1173, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 41);
            this.button4.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button4, "Дізнатися більше");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FractalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1231, 845);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FractalWindow";
            this.Text = "Робота з фракталом";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip tooltipforcomplexnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip tooltipforiterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

