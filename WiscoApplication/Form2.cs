    using System;
    using System.Configuration;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using WiscoApplication.Data;
    using System.Drawing;

    namespace WiscoApplication
    {
    public partial class Form2 : Form
    {
        private readonly UserRepository _userRepository;
        private string _identifier;

        public Form2(string identifier)
        {
            InitializeComponent();
            _userRepository = new UserRepository(ConfigurationManager.ConnectionStrings["MyAppConnectionString"].ConnectionString);
            _identifier = identifier;
            LoadUserData();
        }

        private void LoadUserData()
        {
            string username = _userRepository.GetUsername(_identifier);
            usernameLabel.Text = username;
            string imageUrl = _userRepository.GetProfileImageUrl(username);
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    profilePicture.Image = Image.FromFile(imageUrl);
                }
                catch (Exception ex)
                {
                    profilePicture.Image = Properties.Resources.DefaultProfilePicture1;
                    MessageBox.Show("Nem sikerült betölteni: " + ex.Message);
                }
            }
            else
            {
                profilePicture.Image = Properties.Resources.DefaultProfilePicture1;
            }
        }

        private void muteButton_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void settingsbutton_MouseHover(object sender, EventArgs e)
        {
            settingsbutton.BorderRadius = 4;
        }

        private void deafenbutton_MouseHover(object sender, EventArgs e)
        {
            deafenbutton.BorderRadius = 4;
        }

        private void mutebutton_MouseHover(object sender, EventArgs e)
        {
            mutebutton.BorderRadius = 4;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            topPanel.Location = new Point(0, 0);

            accountPanel.Location = new Point(0, this.ClientSize.Height - accountPanel.Height);
        }

        private void accountPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}