namespace CFGShare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select original config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Config Path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Backup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Restore";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.InitialDirectory = "C:\\temp\\CFGShare\\";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "Select new config";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(412, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bundle-Ready Config Path";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(274, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "Replace Old Config";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "Update Configs From Web";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(60, 292);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "Select Bundle Config";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(412, 22);
            this.textBox3.TabIndex = 11;
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(277, 345);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name of game";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(522, 345);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "New Config Path";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(60, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(171, 51);
            this.button8.TabIndex = 17;
            this.button8.Text = "Select Save Location And Create File";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Config Share";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

