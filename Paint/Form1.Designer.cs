namespace Paint
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Purple = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Navy = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Grey = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.Medium);
            this.groupBox2.Controls.Add(this.Large);
            this.groupBox2.Controls.Add(this.Small);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1350, 62);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush Size";
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(93, 22);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(78, 21);
            this.Medium.TabIndex = 22;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Location = new System.Drawing.Point(197, 22);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(66, 21);
            this.Large.TabIndex = 23;
            this.Large.TabStop = true;
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(7, 22);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(63, 21);
            this.Small.TabIndex = 0;
            this.Small.TabStop = true;
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.ForestGreen;
            this.Green.Location = new System.Drawing.Point(300, 21);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(33, 23);
            this.Green.TabIndex = 22;
            this.Green.Text = "\r\n";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.Purple);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.White);
            this.groupBox1.Controls.Add(this.Navy);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.Grey);
            this.groupBox1.Controls.Add(this.Yellow);
            this.groupBox1.Controls.Add(this.Orange);
            this.groupBox1.Controls.Add(this.Brown);
            this.groupBox1.Controls.Add(this.Black);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1350, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Indigo;
            this.Purple.Location = new System.Drawing.Point(417, 21);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(33, 23);
            this.Purple.TabIndex = 33;
            this.Purple.Text = "\r\n";
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Button_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(183, 21);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(33, 23);
            this.Red.TabIndex = 32;
            this.Red.Text = "\r\n";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Button_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(105, 21);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(33, 23);
            this.White.TabIndex = 31;
            this.White.Text = "\r\n";
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.Button_Click);
            // 
            // Navy
            // 
            this.Navy.BackColor = System.Drawing.Color.MediumBlue;
            this.Navy.Location = new System.Drawing.Point(378, 21);
            this.Navy.Name = "Navy";
            this.Navy.Size = new System.Drawing.Size(33, 23);
            this.Navy.TabIndex = 30;
            this.Navy.Text = "\r\n";
            this.Navy.UseVisualStyleBackColor = false;
            this.Navy.Click += new System.EventHandler(this.Button_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.SteelBlue;
            this.Blue.Location = new System.Drawing.Point(339, 21);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(33, 23);
            this.Blue.TabIndex = 29;
            this.Blue.Text = "\r\n";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Button_Click);
            // 
            // Grey
            // 
            this.Grey.BackColor = System.Drawing.Color.Gray;
            this.Grey.Location = new System.Drawing.Point(144, 21);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(33, 23);
            this.Grey.TabIndex = 28;
            this.Grey.Text = "\r\n";
            this.Grey.UseVisualStyleBackColor = false;
            this.Grey.Click += new System.EventHandler(this.Button_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(261, 21);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(33, 23);
            this.Yellow.TabIndex = 26;
            this.Yellow.Text = "\r\n";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Button_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(222, 21);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(33, 23);
            this.Orange.TabIndex = 25;
            this.Orange.Text = "\r\n";
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Button_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.SaddleBrown;
            this.Brown.Location = new System.Drawing.Point(66, 21);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(33, 23);
            this.Brown.TabIndex = 24;
            this.Brown.Text = "\r\n";
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.Button_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(27, 21);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(33, 23);
            this.Black.TabIndex = 23;
            this.Black.Text = "\r\n";
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Button_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clear.Location = new System.Drawing.Point(0, 654);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(1350, 30);
            this.clear.TabIndex = 25;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 684);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Navy;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Grey;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button clear;
    }
}

