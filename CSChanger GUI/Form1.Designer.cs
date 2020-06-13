namespace CSChanger_GUI
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
            this.AltSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInAltTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignInMainAccountTextBox = new System.Windows.Forms.TextBox();
            this.MainSignIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.steamDirTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.csgoDirTextBox = new System.Windows.Forms.TextBox();
            this.loadAfterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.loadBeforeTextBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadBeforeTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // AltSignIn
            // 
            this.AltSignIn.AccessibleName = "Sign in";
            this.AltSignIn.Location = new System.Drawing.Point(413, 13);
            this.AltSignIn.Name = "AltSignIn";
            this.AltSignIn.Size = new System.Drawing.Size(75, 23);
            this.AltSignIn.TabIndex = 1;
            this.AltSignIn.Text = "Sign in";
            this.AltSignIn.UseVisualStyleBackColor = true;
            this.AltSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alternate Account Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignInAltTextBox
            // 
            this.SignInAltTextBox.AccessibleName = "AltName";
            this.SignInAltTextBox.Location = new System.Drawing.Point(164, 14);
            this.SignInAltTextBox.Name = "SignInAltTextBox";
            this.SignInAltTextBox.Size = new System.Drawing.Size(243, 20);
            this.SignInAltTextBox.TabIndex = 0;
            this.SignInAltTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Main Account Username:";
            // 
            // SignInMainAccountTextBox
            // 
            this.SignInMainAccountTextBox.AccessibleName = "MainName";
            this.SignInMainAccountTextBox.Location = new System.Drawing.Point(164, 44);
            this.SignInMainAccountTextBox.Name = "SignInMainAccountTextBox";
            this.SignInMainAccountTextBox.Size = new System.Drawing.Size(243, 20);
            this.SignInMainAccountTextBox.TabIndex = 2;
            this.SignInMainAccountTextBox.TextChanged += new System.EventHandler(this.SignInMainAccountTextBox_TextChanged);
            // 
            // MainSignIn
            // 
            this.MainSignIn.AccessibleName = "Sign in";
            this.MainSignIn.Location = new System.Drawing.Point(413, 43);
            this.MainSignIn.Name = "MainSignIn";
            this.MainSignIn.Size = new System.Drawing.Size(75, 23);
            this.MainSignIn.TabIndex = 3;
            this.MainSignIn.Text = "Sign in";
            this.MainSignIn.UseVisualStyleBackColor = true;
            this.MainSignIn.Click += new System.EventHandler(this.MainSignIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Steam.exe directory:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steamDirTextBox
            // 
            this.steamDirTextBox.AccessibleName = "SteamDir";
            this.steamDirTextBox.Location = new System.Drawing.Point(15, 103);
            this.steamDirTextBox.Name = "steamDirTextBox";
            this.steamDirTextBox.Size = new System.Drawing.Size(243, 20);
            this.steamDirTextBox.TabIndex = 6;
            this.steamDirTextBox.TextChanged += new System.EventHandler(this.SteamDirTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CS:GO directory:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // csgoDirTextBox
            // 
            this.csgoDirTextBox.AccessibleName = "SteamDir";
            this.csgoDirTextBox.Location = new System.Drawing.Point(15, 142);
            this.csgoDirTextBox.Name = "csgoDirTextBox";
            this.csgoDirTextBox.Size = new System.Drawing.Size(243, 20);
            this.csgoDirTextBox.TabIndex = 7;
            this.csgoDirTextBox.TextChanged += new System.EventHandler(this.csgoDirTextBox_TextChanged);
            // 
            // loadAfterTextBox
            // 
            this.loadAfterTextBox.AccessibleName = "SteamDir";
            this.loadAfterTextBox.Location = new System.Drawing.Point(15, 265);
            this.loadAfterTextBox.Name = "loadAfterTextBox";
            this.loadAfterTextBox.Size = new System.Drawing.Size(243, 20);
            this.loadAfterTextBox.TabIndex = 10;
            this.loadAfterTextBox.TextChanged += new System.EventHandler(this.loadAfterTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "File to load after:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loadBeforeTextBox1
            // 
            this.loadBeforeTextBox1.AccessibleName = "SteamDir";
            this.loadBeforeTextBox1.Location = new System.Drawing.Point(15, 183);
            this.loadBeforeTextBox1.Name = "loadBeforeTextBox1";
            this.loadBeforeTextBox1.Size = new System.Drawing.Size(243, 20);
            this.loadBeforeTextBox1.TabIndex = 8;
            this.loadBeforeTextBox1.TextChanged += new System.EventHandler(this.loadBeforeTextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "File to load before";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(403, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Dark Theme";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 19);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load CSGO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loadBeforeTextBox2
            // 
            this.loadBeforeTextBox2.AccessibleName = "SteamDir";
            this.loadBeforeTextBox2.Location = new System.Drawing.Point(15, 224);
            this.loadBeforeTextBox2.Name = "loadBeforeTextBox2";
            this.loadBeforeTextBox2.Size = new System.Drawing.Size(243, 20);
            this.loadBeforeTextBox2.TabIndex = 9;
            this.loadBeforeTextBox2.TextChanged += new System.EventHandler(this.loadBeforeTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "2nd File to load before";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(351, 211);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(137, 13);
            this.githubLink.TabIndex = 26;
            this.githubLink.Text = "https://github.com/xglymps";
            this.githubLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 19);
            this.button2.TabIndex = 11;
            this.button2.Text = "Load Files Before";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 19);
            this.button3.TabIndex = 28;
            this.button3.Text = "Load Files After";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(239, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(239, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(239, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(239, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(239, 266);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 296);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.loadBeforeTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadBeforeTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loadAfterTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.csgoDirTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.steamDirTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.MainSignIn);
            this.Controls.Add(this.SignInMainAccountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignInAltTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AltSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Glymps\' Custom Switcher + Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AltSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SignInAltTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SignInMainAccountTextBox;
        private System.Windows.Forms.Button MainSignIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox steamDirTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox csgoDirTextBox;
        private System.Windows.Forms.TextBox loadAfterTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox loadBeforeTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loadBeforeTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label githubLink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

