using System;
using System.Configuration;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WiscoApplication.Data;

namespace WiscoApplication
{
    public partial class Form1 : Form
    {
        private readonly UserRepository _userRepository;
        private ErrorProvider errorProvider;

        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(this);
            _userRepository = new UserRepository(ConfigurationManager.ConnectionStrings["MyAppConnectionString"].ConnectionString);
        }

        private void regToDef_Click(object sender, EventArgs e)
        {
            rgpnl.Visible = false;
            dfpnl.Visible = true;
            regEmailText.Text = string.Empty;
            regUserText.Text = string.Empty;
            regPassText.Text = string.Empty;
            errorProvider.Clear();
        }

        private void saveReg_Click(object sender, EventArgs e)
        {
            string username = regUserText.Text;
            string email = regEmailText.Text;
            string password = regPassText.Text;

            if (IsValidEmail(regEmailText.Text))
            {
                if (username.Length > 0 && password.Length > 0)
                {
                    try
                    {
                        _userRepository.RegisterUser(username, email, password);
                        MessageBox.Show("Sikeres regisztráció!");
                        saveReg.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a regisztráció során: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Üresen hagytál valamit! Próbáld újra!");
                }
            }
            else
            {
                MessageBox.Show("Nem megfelelő E-mail címet adtál meg! Próbáld újra!");
            }
        }


        private void logToDef_Click(object sender, EventArgs e)
        {
            dfpnl.Visible = false;
        }

        private void savelog_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = logUserText.Text;
            string password = logPassText.Text;

            if (_userRepository.LoginUser(usernameOrEmail, password))
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                this.Hide();
                Form2 form2 = new Form2(usernameOrEmail);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó.");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            dfpnl.Visible = false;
            rgpnl.Visible = true;
            saveReg.Enabled = true;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            dfpnl.Visible = false;
        }

        private void dfpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logLabel_Click(object sender, EventArgs e)
        {

        }

        private void regEmailText_TextChanged(object sender, EventArgs e)
        {
            string email = regEmailText.Text;
            if (!IsValidEmail(email))
            {
                errorProvider.SetError(regEmailText, "Nem valós E-mail címet adtál meg!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.com$");
            return emailRegex.IsMatch(email);
        }
    }
}
