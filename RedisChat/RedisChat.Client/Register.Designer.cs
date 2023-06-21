namespace RedisChat.Client
{
    partial class Register
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
            panel1 = new Panel();
            RedisChat = new Label();
            btnClose = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            btnRegister = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 89, 205);
            panel1.Controls.Add(RedisChat);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 55);
            panel1.TabIndex = 4;
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
            btnClose.Location = new Point(392, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 68);
            label3.Name = "label3";
            label3.Size = new Size(114, 33);
            label3.TabIndex = 9;
            label3.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(125, 148);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(216, 25);
            textBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 182);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 15;
            label1.Text = "Fullname";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(125, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 25);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 120);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 17;
            label4.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(125, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 25);
            textBox3.TabIndex = 16;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(125, 223);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 251);
            ClientSize = new Size(427, 279);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label RedisChat;
        private Button btnClose;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Button btnRegister;
    }
}