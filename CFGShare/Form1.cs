﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFGShare
{
    public partial class Form1 : Form
    {
        string ogfilename = String.Empty;
        string replacefilename = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //filename();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            filename();
        }
        private void filename()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ogfilename = openFileDialog1.FileName;
                
                
            }
        }
        private void replacer()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\temp\CFGShare\Configs";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                replacefilename = openFileDialog2.FileName;
                textBox2.Text = replacefilename;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string destinationFilebaseog = @"C:\temp\CFGShare\";
            string resultog;

            resultog = Path.GetFileName(ogfilename);
            try
            {
                File.Copy(ogfilename, destinationFilebaseog + resultog, true);
            }
            catch (IOException iox) { };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string destinationFilebaseog = @"C:\temp\CFGShare\Backup\";
            string resultog;

            resultog = Path.GetFileName(ogfilename);
            try
            {
                File.Copy(destinationFilebaseog + resultog,ogfilename, true);
            }
            catch (IOException iox) { };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            replacer();
        }
    }
}
