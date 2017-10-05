namespace ParticleNetwork1
{
    partial class Data
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
            this.Maximum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.Dots = new System.Windows.Forms.NumericUpDown();
            this.Size = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.G = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(208, 85);
            this.Maximum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(64, 20);
            this.Maximum.TabIndex = 2;
            this.Maximum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Maximum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maximum";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(105, 220);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // Dots
            // 
            this.Dots.Location = new System.Drawing.Point(56, 178);
            this.Dots.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Dots.Name = "Dots";
            this.Dots.Size = new System.Drawing.Size(83, 20);
            this.Dots.TabIndex = 6;
            this.Dots.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Dots.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(189, 178);
            this.Size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(83, 20);
            this.Size.TabIndex = 7;
            this.Size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(189, 12);
            this.Height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(83, 20);
            this.Height.TabIndex = 1;
            this.Height.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.Height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resolution";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(75, 12);
            this.Width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(83, 20);
            this.Width.TabIndex = 0;
            this.Width.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "_______________Lines___________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "_______________Dots____________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Size";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(171, 115);
            this.B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(42, 20);
            this.B.TabIndex = 5;
            this.B.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(75, 115);
            this.R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(42, 20);
            this.R.TabIndex = 3;
            this.R.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(123, 115);
            this.G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(42, 20);
            this.G.TabIndex = 4;
            this.G.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "RGB";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Minimum";
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(66, 85);
            this.Minimum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(64, 20);
            this.Minimum.TabIndex = 26;
            this.Minimum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Minimum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Width_KeyDown);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Dots);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maximum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        internal System.Windows.Forms.NumericUpDown Maximum;
        internal System.Windows.Forms.NumericUpDown Dots;
        internal System.Windows.Forms.NumericUpDown Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.NumericUpDown B;
        internal System.Windows.Forms.NumericUpDown R;
        internal System.Windows.Forms.NumericUpDown G;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.NumericUpDown Minimum;
    }
}