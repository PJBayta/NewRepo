using SMS.App.Views.IViews;

namespace SMS.App.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public event EventHandler LoginEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string Username => textBoxUsername.Text.Trim();

        public string Password => textBoxPassword.Text.Trim();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        
    }
}
