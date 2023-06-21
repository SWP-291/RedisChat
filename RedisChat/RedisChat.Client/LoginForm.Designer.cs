namespace RedisChat.Client
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
            btnLogin = new Button();
            btnRegister = new Button();
            panel1 = new Panel();
            RedisChat = new Label();
            btnClose = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(128, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(250, 183);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 89, 205);
            panel1.Controls.Add(RedisChat);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 55);
            panel1.TabIndex = 3;
            // 
            // RedisChat
            // 
            RedisChat.AutoSize = true;
            RedisChat.Font = new Font("Cambria", 20F, FontStyle.Regular, GraphicsUnit.Point);
            RedisChat.ForeColor = SystemColors.ButtonHighlight;
            RedisChat.Location = new Point(125, 9);
            RedisChat.Name = "RedisChat";
            RedisChat.Size = new Size(171, 40);
            RedisChat.TabIndex = 4;
            RedisChat.Text = "Redis Chat";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.Location = new Point(399, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(128, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(128, 148);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(216, 25);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 106);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 58);
            label3.Name = "label3";
            label3.Size = new Size(83, 33);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(435, 262);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Panel panel1;
        private Button btnClose;
        private Label RedisChat;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}