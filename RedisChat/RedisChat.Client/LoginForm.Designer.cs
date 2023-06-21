﻿namespace RedisChat.Client
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            RedisChat = new Label();
            btnClose = new Button();
            PanelLogin = new Panel();
            label3 = new Label();
            label4 = new Label();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            btnLogin = new Button();
            PanelRegister = new Panel();
            txtRegisterLastName = new TextBox();
            txtRegisterFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRegisterPassword = new TextBox();
            txtRegisterUserName = new TextBox();
            btnRegister = new Button();
            btnLoginNav = new Button();
            btnRegisterNav = new Button();
            panel1.SuspendLayout();
            PanelLogin.SuspendLayout();
            PanelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 89, 205);
            panel1.Controls.Add(RedisChat);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 41);
            panel1.TabIndex = 3;
            // 
            // RedisChat
            // 
            RedisChat.AutoSize = true;
            RedisChat.Font = new Font("Cambria", 25F, FontStyle.Bold, GraphicsUnit.Point);
            RedisChat.ForeColor = SystemColors.ButtonHighlight;
            RedisChat.Location = new Point(270, 2);
            RedisChat.Name = "RedisChat";
            RedisChat.Size = new Size(179, 40);
            RedisChat.TabIndex = 4;
            RedisChat.Text = "Redis Chat";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.Location = new Point(681, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 22);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.Controls.Add(label3);
            PanelLogin.Controls.Add(label4);
            PanelLogin.Controls.Add(txtLoginPassword);
            PanelLogin.Controls.Add(txtLoginUsername);
            PanelLogin.Controls.Add(btnLogin);
            PanelLogin.Location = new Point(26, 107);
            PanelLogin.Margin = new Padding(3, 2, 3, 2);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(664, 309);
            PanelLogin.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(138, 136);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 97);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginPassword.Location = new Point(249, 134);
            txtLoginPassword.Margin = new Padding(3, 2, 3, 2);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(190, 29);
            txtLoginPassword.TabIndex = 10;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginUsername.Location = new Point(249, 94);
            txtLoginUsername.Margin = new Padding(3, 2, 3, 2);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(190, 29);
            txtLoginUsername.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(9, 89, 205);
            btnLogin.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(181, 208);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(396, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PanelRegister
            // 
            PanelRegister.BackColor = Color.Transparent;
            PanelRegister.Controls.Add(txtRegisterLastName);
            PanelRegister.Controls.Add(txtRegisterFirstName);
            PanelRegister.Controls.Add(label6);
            PanelRegister.Controls.Add(label5);
            PanelRegister.Controls.Add(label2);
            PanelRegister.Controls.Add(label1);
            PanelRegister.Controls.Add(txtRegisterPassword);
            PanelRegister.Controls.Add(txtRegisterUserName);
            PanelRegister.Controls.Add(btnRegister);
            PanelRegister.Location = new Point(12, 90);
            PanelRegister.Margin = new Padding(3, 2, 3, 2);
            PanelRegister.Name = "PanelRegister";
            PanelRegister.Size = new Size(688, 337);
            PanelRegister.TabIndex = 13;
            // 
            // txtRegisterLastName
            // 
            txtRegisterLastName.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegisterLastName.Location = new Point(248, 58);
            txtRegisterLastName.Margin = new Padding(3, 2, 3, 2);
            txtRegisterLastName.Name = "txtRegisterLastName";
            txtRegisterLastName.Size = new Size(190, 29);
            txtRegisterLastName.TabIndex = 16;
            // 
            // txtRegisterFirstName
            // 
            txtRegisterFirstName.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegisterFirstName.Location = new Point(247, 28);
            txtRegisterFirstName.Margin = new Padding(3, 2, 3, 2);
            txtRegisterFirstName.Name = "txtRegisterFirstName";
            txtRegisterFirstName.Size = new Size(190, 29);
            txtRegisterFirstName.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(136, 62);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 14;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(133, 30);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 13;
            label5.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 134);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 95);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegisterPassword.Location = new Point(248, 132);
            txtRegisterPassword.Margin = new Padding(3, 2, 3, 2);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PasswordChar = '*';
            txtRegisterPassword.Size = new Size(190, 29);
            txtRegisterPassword.TabIndex = 10;
            // 
            // txtRegisterUserName
            // 
            txtRegisterUserName.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegisterUserName.Location = new Point(248, 93);
            txtRegisterUserName.Margin = new Padding(3, 2, 3, 2);
            txtRegisterUserName.Name = "txtRegisterUserName";
            txtRegisterUserName.Size = new Size(190, 29);
            txtRegisterUserName.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(9, 89, 205);
            btnRegister.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(179, 207);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(396, 44);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLoginNav
            // 
            btnLoginNav.BackColor = Color.Silver;
            btnLoginNav.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginNav.Location = new Point(0, 46);
            btnLoginNav.Margin = new Padding(3, 2, 3, 2);
            btnLoginNav.Name = "btnLoginNav";
            btnLoginNav.Size = new Size(353, 40);
            btnLoginNav.TabIndex = 11;
            btnLoginNav.Text = "Login";
            btnLoginNav.UseVisualStyleBackColor = false;
            btnLoginNav.Click += button1_Click;
            // 
            // btnRegisterNav
            // 
            btnRegisterNav.BackColor = Color.Silver;
            btnRegisterNav.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterNav.Location = new Point(358, 46);
            btnRegisterNav.Margin = new Padding(3, 2, 3, 2);
            btnRegisterNav.Name = "btnRegisterNav";
            btnRegisterNav.Size = new Size(353, 40);
            btnRegisterNav.TabIndex = 12;
            btnRegisterNav.Text = "Register";
            btnRegisterNav.UseVisualStyleBackColor = false;
            btnRegisterNav.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(710, 436);
            Controls.Add(PanelRegister);
            Controls.Add(PanelLogin);
            Controls.Add(btnRegisterNav);
            Controls.Add(btnLoginNav);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            PanelRegister.ResumeLayout(false);
            PanelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnClose;
        private Label RedisChat;
        private Panel PanelLogin;
        private Label label3;
        private Label label4;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private Button btnLogin;
        private Panel PanelRegister;
        private TextBox txtRegisterLastName;
        private TextBox txtRegisterFirstName;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtRegisterPassword;
        private TextBox txtRegisterUserName;
        private Button btnRegister;
        private Button btnLoginNav;
        private Button btnRegisterNav;
    }
}