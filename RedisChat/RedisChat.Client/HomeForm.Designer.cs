namespace RedisChat.Client
{
    partial class HomeForm
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
            RedisChat = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(724, 41);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 409);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.img1;
            pictureBox1.Image = Properties.Resources.img11;
            pictureBox1.Location = new Point(62, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(193, 282);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 106);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 2);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 19;
            label2.Text = "My Profile";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label RedisChat;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}