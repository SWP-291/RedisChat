using RedisChat.Client.Helper;
using RedisChat.Client.Services;

namespace RedisChat.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RedisHelper.Connect();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLoginNav.PerformClick();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PanelLogin.BringToFront();
            btnLoginNav.BackColor = Color.Blue;
            btnRegisterNav.BackColor = Color.Silver;
            btnLoginNav.ForeColor = Color.White;
            btnRegisterNav.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelRegister.BringToFront();
            btnRegisterNav.BackColor = Color.Blue;
            btnRegisterNav.ForeColor = Color.White;
            btnLoginNav.BackColor = Color.Silver;
            btnLoginNav.ForeColor = Color.Black;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}