using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFGShare
{
    public partial class Form1 : Form
    {
        string ogfilename = "";
        string replacefilename = "";
        string bundleready;
        bool fileok = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //filename();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filename();
        }
        private void filename()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ogfilename = openFileDialog1.FileName;
                textBox1.Text = ogfilename;

            }
        }
        private void replacer()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\temp\CFGShare\Configs\";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                replacefilename = openFileDialog2.FileName;
                textBox2.Text = replacefilename;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string destinationFilebaseog = @"C:\temp\CFGShare\Backup\";
            string resultog;

            resultog = Path.GetFileName(ogfilename);
            try
            {
                if (ogfilename != "")
                {
                    File.Copy(ogfilename, destinationFilebaseog + resultog, true);
                }

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
                if (ogfilename != "")
                {
                    File.Copy(destinationFilebaseog + resultog, ogfilename, true);
                }
                
            }
            catch (IOException iox) { };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            replacer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string resultog;

            resultog = Path.GetFileName(ogfilename);
            try
            {
                if (ogfilename != "")
                {
                    File.Copy(replacefilename, ogfilename, true);
                }
            }
            catch (IOException iox) { };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(@"C:\temp\CFGShare\Configs\Internet Configs\", true);
                Directory.Delete(@"C:\temp\CFGShare\Updated\master\", true);
                
            }
            catch (IOException iox) { };
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/gamingdoom/CfgShareConfigs/archive/master.zip", @"C:\temp\CFGShare\Updated\master.zip");
            Task.Delay(1000);
            try
            {
                ZipFile.ExtractToDirectory(@"C:\temp\CFGShare\Updated\master.zip", @"C:\temp\CFGShare\Updated\master\");
                File.Delete(@"C:\temp\CFGShare\Updated\master\CfgShareConfigs-master\README.md");
            }
            catch (IOException iox) { };
            CopyFolder(@"C:\temp\CFGShare\Updated\master\CfgShareConfigs-master\", @"C:\temp\CFGShare\Configs\Internet Configs\");
        }
        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                fileok = true;
                bundleready = openFileDialog3.FileName;
                textBox3.Text = bundleready;

            }
        }
        private void bundle()
        {
            string bundlesave;
            string user;
            string game;
            string bundlename;
            string bundleresultfile;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                bundlesave = folderBrowserDialog1.SelectedPath;
                if (fileok == false)
                {
                    MessageBox.Show("Please choose a config file to bundle!");
                }
                else
                {
                    fileok = false;
                    textBox3.Text = "";
                    user = textBox4.Text;
                    game = textBox5.Text;
                    string bundleresult = bundlesave + @"\" + user + " - " + game;
                    try
                    {
                        Directory.CreateDirectory(bundleresult);
                    }
                    catch (IOException iox) { };
                    bundlename = Path.GetFileName(bundleready);
                    bundleresultfile = bundleresult + @"\" + bundlename;
                    try
                    {
                        File.Copy(bundleready, bundleresultfile);
                        ZipFile.CreateFromDirectory(bundleresult, bundleresult + ".zip");
                        Directory.Delete(bundleresult, true);
                    }
                    catch (IOException iox) { };
                }
            }
        }
        public void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please input a username!");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Please input a game title!");
            }
            else
            {
                bundle();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gamingdoom/CfgShareConfigs");
        }
    }
}
