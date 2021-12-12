
namespace mandelbrot_set
{
    partial class AffineTransformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffineTransformation));
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOffset = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coordinatesButton = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.BackColor = System.Drawing.Color.Bisque;
            this.tbX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbX.Location = new System.Drawing.Point(1157, 102);
            this.tbX.Multiline = true;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(53, 35);
            this.tbX.TabIndex = 0;
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.Color.Bisque;
            this.tbY.Location = new System.Drawing.Point(1235, 102);
            this.tbY.Multiline = true;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(53, 35);
            this.tbY.TabIndex = 1;
            // 
            // tbWidth
            // 
            this.tbWidth.BackColor = System.Drawing.Color.Bisque;
            this.tbWidth.Location = new System.Drawing.Point(1176, 210);
            this.tbWidth.Multiline = true;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(112, 35);
            this.tbWidth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1173, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1255, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1174, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1101, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "введіть значення одиничного \r\nвідрізка:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Bisque;
            this.textBox9.Location = new System.Drawing.Point(1177, 410);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(53, 35);
            this.textBox9.TabIndex = 14;
            this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
            this.textBox9.Validating += new System.ComponentModel.CancelEventHandler(this.textBox9_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1101, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "введіть зміщення по \r\nвертикалі:";
            // 
            // tbOffset
            // 
            this.tbOffset.BackColor = System.Drawing.Color.Bisque;
            this.tbOffset.Location = new System.Drawing.Point(1176, 524);
            this.tbOffset.Multiline = true;
            this.tbOffset.Name = "tbOffset";
            this.tbOffset.Size = new System.Drawing.Size(53, 35);
            this.tbOffset.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1104, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 66);
            this.button1.TabIndex = 18;
            this.button1.Text = "Рух";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1235, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 66);
            this.button2.TabIndex = 19;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 765);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // coordinatesButton
            // 
            this.coordinatesButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.coordinatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coordinatesButton.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinatesButton.Location = new System.Drawing.Point(1160, 277);
            this.coordinatesButton.Name = "coordinatesButton";
            this.coordinatesButton.Size = new System.Drawing.Size(138, 73);
            this.coordinatesButton.TabIndex = 21;
            this.coordinatesButton.Text = "побудувати квадрат";
            this.coordinatesButton.UseVisualStyleBackColor = false;
            this.coordinatesButton.Click += new System.EventHandler(this.coordinatesButton_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearAll.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(1109, 684);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(101, 66);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "Скинути все";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1101, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "введіть координати для лівого \r\nнижнього кута квадрата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1099, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "введіть ширину/довжину \r\nквадрата:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1235, 684);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 66);
            this.button3.TabIndex = 25;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AffineTransformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1367, 762);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.coordinatesButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOffset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffineTransformation";
            this.Text = "AffineTransformation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOffset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button coordinatesButton;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}