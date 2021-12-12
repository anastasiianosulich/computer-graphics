
namespace mandelbrot_set
{
    partial class InfoForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Про програму");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Що таке фрактал Мандельброта?");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Які колірні перетворення моделей є у програмі?");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Колірні моделі", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Які перетворення реалізовані програмою?");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Афінні перетворення", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Зміст", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Wheat;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(-1, -1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "program";
            treeNode1.Text = "Про програму";
            treeNode2.Name = "mand";
            treeNode2.Text = "Що таке фрактал Мандельброта?";
            treeNode3.Name = "whatmodels";
            treeNode3.Text = "Які колірні перетворення моделей є у програмі?";
            treeNode4.Name = "cmodels";
            treeNode4.Text = "Колірні моделі";
            treeNode5.Name = "whattr";
            treeNode5.Text = "Які перетворення реалізовані програмою?";
            treeNode6.Name = "tr";
            treeNode6.Text = "Афінні перетворення";
            treeNode7.Checked = true;
            treeNode7.Name = "content";
            treeNode7.Text = "Зміст";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(1009, 148);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 22);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(996, 443);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(577, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Шукати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(681, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 666);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}