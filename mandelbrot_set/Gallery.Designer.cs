
namespace mandelbrot_set
{
    partial class Gallery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb5 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb5);
            this.panel1.Controls.Add(this.cb4);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb3);
            this.panel1.Location = new System.Drawing.Point(567, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 37);
            this.panel1.TabIndex = 3;
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.BorderThickness = 0;
            this.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.Parent = this.cb1;
            this.cb1.Location = new System.Drawing.Point(6, 12);
            this.cb1.Name = "cb1";
            this.cb1.ShadowDecoration.Parent = this.cb1;
            this.cb1.Size = new System.Drawing.Size(15, 15);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "guna2CustomRadioButton1";
            this.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb1.UncheckedState.BorderThickness = 2;
            this.cb1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb1.UncheckedState.Parent = this.cb1;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.BorderThickness = 0;
            this.cb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.Parent = this.cb2;
            this.cb2.Location = new System.Drawing.Point(27, 12);
            this.cb2.Name = "cb2";
            this.cb2.ShadowDecoration.Parent = this.cb2;
            this.cb2.Size = new System.Drawing.Size(15, 15);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "guna2CustomRadioButton1";
            this.cb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb2.UncheckedState.BorderThickness = 2;
            this.cb2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb2.UncheckedState.Parent = this.cb2;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.BackColor = System.Drawing.Color.Transparent;
            this.cb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.BorderThickness = 0;
            this.cb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.Parent = this.cb3;
            this.cb3.Location = new System.Drawing.Point(48, 12);
            this.cb3.Name = "cb3";
            this.cb3.ShadowDecoration.Parent = this.cb3;
            this.cb3.Size = new System.Drawing.Size(15, 15);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "guna2CustomRadioButton1";
            this.cb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb3.UncheckedState.BorderThickness = 2;
            this.cb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb3.UncheckedState.Parent = this.cb3;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.BackColor = System.Drawing.Color.Transparent;
            this.cb4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.BorderThickness = 0;
            this.cb4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.Parent = this.cb4;
            this.cb4.Location = new System.Drawing.Point(69, 12);
            this.cb4.Name = "cb4";
            this.cb4.ShadowDecoration.Parent = this.cb4;
            this.cb4.Size = new System.Drawing.Size(15, 15);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "guna2CustomRadioButton1";
            this.cb4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb4.UncheckedState.BorderThickness = 2;
            this.cb4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb4.UncheckedState.Parent = this.cb4;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.BackColor = System.Drawing.Color.Transparent;
            this.cb5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.BorderThickness = 0;
            this.cb5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.Parent = this.cb5;
            this.cb5.Location = new System.Drawing.Point(90, 12);
            this.cb5.Name = "cb5";
            this.cb5.ShadowDecoration.Parent = this.cb5;
            this.cb5.Size = new System.Drawing.Size(15, 15);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "guna2CustomRadioButton1";
            this.cb5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb5.UncheckedState.BorderThickness = 2;
            this.cb5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb5.UncheckedState.Parent = this.cb5;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::mandelbrot_set.Properties.Resources._4115230_cancel_close_cross_delete_114048__1_;
            this.button1.Location = new System.Drawing.Point(1153, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.CheckedState.Parent = this.btnRight;
            this.btnRight.CustomImages.Parent = this.btnRight;
            this.btnRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRight.DisabledState.Parent = this.btnRight;
            this.btnRight.FillColor = System.Drawing.Color.Transparent;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRight.ForeColor = System.Drawing.Color.Transparent;
            this.btnRight.HoverState.Parent = this.btnRight;
            this.btnRight.Image = global::mandelbrot_set.Properties.Resources._1486348525_music_forward_front_next_arrow_80457;
            this.btnRight.ImageSize = new System.Drawing.Size(90, 90);
            this.btnRight.Location = new System.Drawing.Point(1158, 268);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(98, 93);
            this.btnRight.TabIndex = 2;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.CheckedState.Parent = this.btnLeft;
            this.btnLeft.CustomImages.Parent = this.btnLeft;
            this.btnLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeft.DisabledState.Parent = this.btnLeft;
            this.btnLeft.FillColor = System.Drawing.Color.Transparent;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeft.HoverState.Parent = this.btnLeft;
            this.btnLeft.Image = global::mandelbrot_set.Properties.Resources._1486348526_arrow_back_backwards_repeat_previous_80453;
            this.btnLeft.ImageSize = new System.Drawing.Size(90, 90);
            this.btnLeft.Location = new System.Drawing.Point(-15, 268);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(98, 93);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.Gallery_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLeft;
        private Guna.UI2.WinForms.Guna2Button btnRight;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button button1;
    }
}