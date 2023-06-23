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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            RedisChat = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnCreateGroup = new Button();
            btnGroupChat = new Button();
            btnPersonChat = new Button();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listUser1 = new ListUser();
            userControl1 = new UserControl();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            sendMessage1 = new SendMessage();
            user1 = new User();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // RedisChat
            // 
            RedisChat.AutoSize = true;
            RedisChat.Font = new Font("Cambria", 25F, FontStyle.Bold, GraphicsUnit.Point);
            RedisChat.ForeColor = SystemColors.ButtonHighlight;
            RedisChat.Location = new Point(506, 0);
            RedisChat.Name = "RedisChat";
            RedisChat.Size = new Size(223, 49);
            RedisChat.TabIndex = 4;
            RedisChat.Text = "Redis Chat";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.Location = new Point(1167, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 89, 205);
            panel1.Controls.Add(RedisChat);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 55);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 25, 40);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCreateGroup);
            panel2.Controls.Add(btnGroupChat);
            panel2.Controls.Add(btnPersonChat);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 55);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 723);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(26, 32, 47);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.img9;
            button1.Location = new Point(10, 482);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(63, 50);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.img1;
            pictureBox1.Image = Properties.Resources.img6;
            pictureBox1.InitialImage = Properties.Resources.img6;
            pictureBox1.Location = new Point(14, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.AllowDrop = true;
            btnCreateGroup.Anchor = AnchorStyles.None;
            btnCreateGroup.BackColor = Color.FromArgb(26, 32, 47);
            btnCreateGroup.BackgroundImageLayout = ImageLayout.None;
            btnCreateGroup.FlatAppearance.BorderSize = 0;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateGroup.ForeColor = Color.Transparent;
            btnCreateGroup.Image = (Image)resources.GetObject("btnCreateGroup.Image");
            btnCreateGroup.Location = new Point(10, 320);
            btnCreateGroup.Margin = new Padding(0);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(63, 50);
            btnCreateGroup.TabIndex = 20;
            btnCreateGroup.UseVisualStyleBackColor = false;
            // 
            // btnGroupChat
            // 
            btnGroupChat.AllowDrop = true;
            btnGroupChat.Anchor = AnchorStyles.None;
            btnGroupChat.BackColor = Color.FromArgb(26, 32, 47);
            btnGroupChat.BackgroundImageLayout = ImageLayout.None;
            btnGroupChat.FlatAppearance.BorderSize = 0;
            btnGroupChat.FlatStyle = FlatStyle.Flat;
            btnGroupChat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGroupChat.ForeColor = Color.Transparent;
            btnGroupChat.Image = Properties.Resources.img4;
            btnGroupChat.Location = new Point(10, 247);
            btnGroupChat.Margin = new Padding(0);
            btnGroupChat.Name = "btnGroupChat";
            btnGroupChat.Size = new Size(63, 50);
            btnGroupChat.TabIndex = 19;
            btnGroupChat.UseVisualStyleBackColor = false;
            // 
            // btnPersonChat
            // 
            btnPersonChat.AllowDrop = true;
            btnPersonChat.Anchor = AnchorStyles.None;
            btnPersonChat.BackColor = Color.FromArgb(26, 32, 47);
            btnPersonChat.BackgroundImageLayout = ImageLayout.None;
            btnPersonChat.FlatAppearance.BorderSize = 0;
            btnPersonChat.FlatStyle = FlatStyle.Flat;
            btnPersonChat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonChat.ForeColor = Color.Transparent;
            btnPersonChat.Image = (Image)resources.GetObject("btnPersonChat.Image");
            btnPersonChat.Location = new Point(11, 173);
            btnPersonChat.Margin = new Padding(0);
            btnPersonChat.Name = "btnPersonChat";
            btnPersonChat.Size = new Size(63, 50);
            btnPersonChat.TabIndex = 2;
            btnPersonChat.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(19, 25, 40);
            panel3.Dock = DockStyle.Right;
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(942, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 723);
            panel3.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(listUser1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(80, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(222, 723);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // listUser1
            // 
            listUser1.BackColor = Color.DimGray;
            listUser1.Dock = DockStyle.Top;
            listUser1.Location = new Point(3, 3);
            listUser1.Name = "listUser1";
            listUser1.Size = new Size(219, 107);
            listUser1.TabIndex = 0;
            // 
            // userControl1
            // 
            userControl1.Location = new Point(0, 0);
            userControl1.Name = "userControl1";
            userControl1.Size = new Size(150, 150);
            userControl1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(302, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(640, 98);
            panel4.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 24;
            label1.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.img1;
            pictureBox2.Image = Properties.Resources.img12;
            pictureBox2.InitialImage = Properties.Resources.img6;
            pictureBox2.Location = new Point(17, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button2);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(302, 701);
            panel5.Name = "panel5";
            panel5.Size = new Size(640, 77);
            panel5.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Type Here" });
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(17, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type Here";
            textBox1.Size = new Size(544, 47);
            textBox1.TabIndex = 24;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(26, 32, 47);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.send;
            button2.Location = new Point(564, 18);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(63, 50);
            button2.TabIndex = 23;
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(sendMessage1);
            flowLayoutPanel2.Controls.Add(user1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(302, 153);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(640, 548);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // sendMessage1
            // 
            sendMessage1.BackColor = Color.FromArgb(26, 32, 47);
            sendMessage1.Location = new Point(3, 3);
            sendMessage1.Name = "sendMessage1";
            sendMessage1.Size = new Size(637, 82);
            sendMessage1.TabIndex = 0;
            // 
            // user1
            // 
            user1.BackColor = Color.FromArgb(26, 32, 47);
            user1.Location = new Point(3, 91);
            user1.Name = "user1";
            user1.Size = new Size(631, 73);
            user1.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 47);
            ClientSize = new Size(1204, 778);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeForm";
            Text = "HomeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label RedisChat;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPersonChat;
        private Button btnGroupChat;
        private Button btnCreateGroup;
        private PictureBox pictureBox1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox2;
        private UserControl userControl1;
        private Panel panel5;
        private TextBox textBox1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private ListUser listUser1;
        private SendMessage sendMessage1;
        private User user1;
    }
}