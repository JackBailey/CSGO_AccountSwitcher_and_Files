using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSChanger_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = Properties.Resources.file_white_bg;
            checkBox2.Checked = Properties.Settings.Default.darkVal;
            SignInAltTextBox.Text = Properties.Settings.Default.AltAccount;
            SignInMainAccountTextBox.Text = Properties.Settings.Default.MainAccount;
            steamDirTextBox.Text = Properties.Settings.Default.SteamDirVal;
            csgoDirTextBox.Text = Properties.Settings.Default.csgoDir;
            loadBeforeTextBox1.Text = Properties.Settings.Default.fileBefore1;
            loadBeforeTextBox2.Text = Properties.Settings.Default.fileBefore2;
            loadAfterTextBox.Text = Properties.Settings.Default.fileAfter;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Input and Save Data

            
            LogIn(SignInAltTextBox.Text, Properties.Settings.Default.SteamDirVal);

        }

        static void LogIn(string Account, string SteamDirString)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM steam.exe /T");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam", true);
                key.SetValue("AutoLoginUser", Account, RegistryValueKind.String);
                System.Threading.Thread.Sleep(5000);
                System.Diagnostics.Process.Start(SteamDirString);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.Forms.MessageBox.Show("Check Steam Directory, No file found");
            }
            

        }
        public void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string data = SignInAltTextBox.Text;
            Properties.Settings.Default.AltAccount = data;
            Properties.Settings.Default.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainSignIn_Click(object sender, EventArgs e)
        {
            //Input and Save Data
            
            LogIn(SignInMainAccountTextBox.Text, Properties.Settings.Default.SteamDirVal);
        }

        private void SteamDirTextBox_TextChanged(object sender, EventArgs e)
        {
            string data = steamDirTextBox.Text;
            Properties.Settings.Default.SteamDirVal = data;
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool dark = checkBox2.Checked;
            Properties.Settings.Default.darkVal = dark;
            Properties.Settings.Default.Save();
            if (checkBox2.Checked) //if Dark mode on
            {
                label1.ForeColor = label2.ForeColor = label4.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = label9.ForeColor = checkBox2.ForeColor = githubLink.ForeColor =  System.Drawing.Color.White;
                this.BackColor = this.BackColor = Color.FromArgb(19,19,19); // dark grey

            }
            else
            {
                label1.ForeColor = label2.ForeColor = label4.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = label9.ForeColor = checkBox2.ForeColor = githubLink.ForeColor = this.BackColor = Color.FromArgb(19, 19, 19);
                this.BackColor = System.Drawing.Color.White; // white
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // RUN FINAL
        {
            try
            {
                if(!String.IsNullOrEmpty((loadAfterTextBox.Text)))
            {
                    System.Diagnostics.Process.Start(loadAfterTextBox.Text);
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.Forms.MessageBox.Show("Check Run after Directory, No file found");
            }
        }

        private void csgoDirTextBox_TextChanged(object sender, EventArgs e)
        {
            string csDir = csgoDirTextBox.Text;
            Properties.Settings.Default.csgoDir = csDir;
            Properties.Settings.Default.Save();
        }

        private void loadBeforeTextBox1_TextChanged(object sender, EventArgs e)
        {
            string fb1Dir = loadBeforeTextBox1.Text; //file before 1 dir
            Properties.Settings.Default.fileBefore1 = fb1Dir;
            Properties.Settings.Default.Save();
        }

        private void loadBeforeTextBox2_TextChanged(object sender, EventArgs e)
        {
            string fb2Dir = loadBeforeTextBox2.Text; //file before 2 dir
            Properties.Settings.Default.fileBefore2 = fb2Dir;
            Properties.Settings.Default.Save();
        }

        private void loadAfterTextBox_TextChanged(object sender, EventArgs e)
        {
            string faDir = loadAfterTextBox.Text; //file after dir
            Properties.Settings.Default.fileAfter = faDir;
            Properties.Settings.Default.Save();
        }

        private void button2_Click_1(object sender, EventArgs e) // run files
        {
            try //if run before on
            {
                if (!String.IsNullOrEmpty((loadBeforeTextBox1.Text)))
                {
                    System.Diagnostics.Process.Start(loadBeforeTextBox1.Text);
                }
                if (!String.IsNullOrEmpty((loadBeforeTextBox2.Text)))
                {
                    System.Diagnostics.Process.Start(loadBeforeTextBox2.Text);
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.Forms.MessageBox.Show("Check Run before Directories, No file(s) found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty((loadAfterTextBox.Text)))
                {
                    System.Diagnostics.Process.Start(loadAfterTextBox.Text);
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Windows.Forms.MessageBox.Show("Check Steam Directory, No file found");
            }
            
        }
        OpenFileDialog ofdSteam = new OpenFileDialog();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofdSteam.ShowDialog() == DialogResult.OK)
            {
                steamDirTextBox.Text = ofdSteam.FileName;
            }
            

        }
        OpenFileDialog ofdCsgo = new OpenFileDialog();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ofdCsgo.ShowDialog() == DialogResult.OK)
            {
                csgoDirTextBox.Text = ofdCsgo.FileName;
            }
        }
        OpenFileDialog ofdBefore1 = new OpenFileDialog();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ofdBefore1.ShowDialog() == DialogResult.OK)
            {
                loadBeforeTextBox1.Text = ofdBefore1.FileName;
            }
        }
        OpenFileDialog ofdBefore2 = new OpenFileDialog();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (ofdBefore2.ShowDialog() == DialogResult.OK)
            {
                loadBeforeTextBox2.Text = ofdBefore2.FileName;
            }
        }
        OpenFileDialog ofdAfter = new OpenFileDialog();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ofdAfter.ShowDialog() == DialogResult.OK)
            {
                loadAfterTextBox.Text = ofdAfter.FileName;
            }
        }

        private void SignInMainAccountTextBox_TextChanged(object sender, EventArgs e)
        {
            string data = SignInMainAccountTextBox.Text;
            Properties.Settings.Default.MainAccount = data;
            Properties.Settings.Default.Save();
        }
    }

}
