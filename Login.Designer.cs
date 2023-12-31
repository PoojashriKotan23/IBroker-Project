﻿namespace IBroker
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.plLoginDetails = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lklblForgot = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubLogin2 = new System.Windows.Forms.Label();
            this.lblSubLogin = new System.Windows.Forms.Label();
            this.lblSubLog = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.plImage = new System.Windows.Forms.Panel();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.plLoginDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.plImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLoginDetails
            // 
            this.plLoginDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plLoginDetails.Controls.Add(this.label3);
            this.plLoginDetails.Controls.Add(this.label2);
            this.plLoginDetails.Controls.Add(this.panel2);
            this.plLoginDetails.Controls.Add(this.panel1);
            this.plLoginDetails.Controls.Add(this.lklblForgot);
            this.plLoginDetails.Controls.Add(this.label5);
            this.plLoginDetails.Controls.Add(this.label4);
            this.plLoginDetails.Controls.Add(this.btnSignIn);
            this.plLoginDetails.Controls.Add(this.label1);
            this.plLoginDetails.Controls.Add(this.lblSubLogin2);
            this.plLoginDetails.Controls.Add(this.lblSubLogin);
            this.plLoginDetails.Controls.Add(this.lblSubLog);
            this.plLoginDetails.Controls.Add(this.lblLogin);
            this.plLoginDetails.Controls.Add(this.pictureBox2);
            this.plLoginDetails.Location = new System.Drawing.Point(759, 0);
            this.plLoginDetails.Name = "plLoginDetails";
            this.plLoginDetails.Size = new System.Drawing.Size(572, 727);
            this.plLoginDetails.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(286, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = ":I-Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(54, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnShowPass);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.btnHidePass);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(74, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 78);
            this.panel2.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPassword.Location = new System.Drawing.Point(13, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 21);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(16, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(370, 44);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(74, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 72);
            this.panel1.TabIndex = 15;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserName.Location = new System.Drawing.Point(13, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User ID";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserName.Location = new System.Drawing.Point(17, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(370, 44);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "Enter User ID";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // lklblForgot
            // 
            this.lklblForgot.AutoSize = true;
            this.lklblForgot.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblForgot.LinkColor = System.Drawing.Color.DimGray;
            this.lklblForgot.Location = new System.Drawing.Point(315, 435);
            this.lklblForgot.Name = "lklblForgot";
            this.lklblForgot.Size = new System.Drawing.Size(155, 20);
            this.lklblForgot.TabIndex = 14;
            this.lklblForgot.TabStop = true;
            this.lklblForgot.Text = "Forgot Password?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1846, 1050);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = ":I-Percent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(197, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Powered By";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignIn.Location = new System.Drawing.Point(191, 522);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(167, 58);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(336, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "your Account";
            // 
            // lblSubLogin2
            // 
            this.lblSubLogin2.AutoSize = true;
            this.lblSubLogin2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLogin2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubLogin2.Location = new System.Drawing.Point(236, 230);
            this.lblSubLogin2.Name = "lblSubLogin2";
            this.lblSubLogin2.Size = new System.Drawing.Size(106, 27);
            this.lblSubLogin2.TabIndex = 4;
            this.lblSubLogin2.Text = "-Sign in to";
            // 
            // lblSubLogin
            // 
            this.lblSubLogin.AutoSize = true;
            this.lblSubLogin.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubLogin.Location = new System.Drawing.Point(69, 230);
            this.lblSubLogin.Name = "lblSubLogin";
            this.lblSubLogin.Size = new System.Drawing.Size(177, 27);
            this.lblSubLogin.TabIndex = 3;
            this.lblSubLogin.Text = "Welcome I-Broker";
            // 
            // lblSubLog
            // 
            this.lblSubLog.AutoSize = true;
            this.lblSubLog.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLog.Location = new System.Drawing.Point(65, 240);
            this.lblSubLog.Name = "lblSubLog";
            this.lblSubLog.Size = new System.Drawing.Size(0, 49);
            this.lblSubLog.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(204, 156);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(117, 49);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(177, 571);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(407, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // plImage
            // 
            this.plImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plImage.Controls.Add(this.pictureBox3);
            this.plImage.Controls.Add(this.pictureBox1);
            this.plImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.plImage.Location = new System.Drawing.Point(0, 0);
            this.plImage.Name = "plImage";
            this.plImage.Size = new System.Drawing.Size(761, 727);
            this.plImage.TabIndex = 0;
            // 
            // btnShowPass
            // 
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(358, 22);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(28, 27);
            this.btnShowPass.TabIndex = 19;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePass.Image")));
            this.btnHidePass.Location = new System.Drawing.Point(358, 22);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(28, 27);
            this.btnHidePass.TabIndex = 19;
            this.btnHidePass.UseVisualStyleBackColor = true;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.plLoginDetails);
            this.Controls.Add(this.plImage);
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.plLoginDetails.ResumeLayout(false);
            this.plLoginDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.plImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plLoginDetails;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSubLog;
        private System.Windows.Forms.Label lblSubLogin;
        private System.Windows.Forms.Label lblSubLogin2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lklblForgot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plImage;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnHidePass;
    }
}

