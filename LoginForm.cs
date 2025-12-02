using C969.Localization;
using C969.Services;
using System.Globalization;

namespace C969
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentUICulture;
            var timezone = TimeZoneInfo.Local;

            labelLocale.Text = $"Language: {culture.TwoLetterISOLanguageName},\nTime Zone: {timezone.DisplayName}";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string u = textboxUsername.Text;
            string p = textboxPassword.Text;

            var auth = new AuthService();
            var user = auth.Login(u, p);

            if (user == null)
            {
                MessageBox.Show(Messages.InvalidLogin());
                return;
            }

            //success
            MessageBox.Show($"Welcome {user.UserName}!");
        }
    }
}
