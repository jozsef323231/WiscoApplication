namespace WiscoApplication
{
    partial class Form1
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
            rgpnl = new Panel();
            regUserText = new TextBox();
            regLabel = new Label();
            regUser = new Label();
            regEmail = new Label();
            regToDef = new Button();
            regEmailText = new TextBox();
            saveReg = new Button();
            regPass = new Label();
            regPassText = new TextBox();
            dfpnl = new Panel();
            pictureBox1 = new PictureBox();
            logUserText = new TextBox();
            regButton = new Button();
            logUser = new Label();
            logLabel = new Label();
            logPass = new Label();
            savelog = new Button();
            logPassText = new TextBox();
            rgpnl.SuspendLayout();
            dfpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rgpnl
            // 
            rgpnl.BackColor = Color.FromArgb(43, 45, 49);
            rgpnl.Controls.Add(regUserText);
            rgpnl.Controls.Add(regLabel);
            rgpnl.Controls.Add(regUser);
            rgpnl.Controls.Add(regEmail);
            rgpnl.Controls.Add(regToDef);
            rgpnl.Controls.Add(regEmailText);
            rgpnl.Controls.Add(saveReg);
            rgpnl.Controls.Add(regPass);
            rgpnl.Controls.Add(regPassText);
            rgpnl.Location = new Point(2, 1);
            rgpnl.Name = "rgpnl";
            rgpnl.Size = new Size(690, 448);
            rgpnl.TabIndex = 0;
            // 
            // regUserText
            // 
            regUserText.BackColor = Color.FromArgb(49, 49, 50);
            regUserText.ForeColor = SystemColors.Window;
            regUserText.Location = new Point(281, 227);
            regUserText.Name = "regUserText";
            regUserText.PlaceholderText = "Felhasználónév";
            regUserText.Size = new Size(163, 23);
            regUserText.TabIndex = 17;
            regUserText.TextAlign = HorizontalAlignment.Center;
            // 
            // regLabel
            // 
            regLabel.AutoSize = true;
            regLabel.Font = new Font("Verdana", 18F, FontStyle.Bold);
            regLabel.ForeColor = SystemColors.ButtonFace;
            regLabel.Location = new Point(266, 106);
            regLabel.Name = "regLabel";
            regLabel.Size = new Size(178, 29);
            regLabel.TabIndex = 9;
            regLabel.Text = "Regisztráció";
            // 
            // regUser
            // 
            regUser.AutoSize = true;
            regUser.Font = new Font("Verdana", 10F, FontStyle.Bold);
            regUser.ForeColor = SystemColors.ButtonFace;
            regUser.Location = new Point(143, 229);
            regUser.Name = "regUser";
            regUser.Size = new Size(132, 17);
            regUser.TabIndex = 16;
            regUser.Text = "Felhasználónév:";
            // 
            // regEmail
            // 
            regEmail.AutoSize = true;
            regEmail.Font = new Font("Verdana", 10F, FontStyle.Bold);
            regEmail.ForeColor = SystemColors.ButtonFace;
            regEmail.Location = new Point(220, 192);
            regEmail.Name = "regEmail";
            regEmail.Size = new Size(55, 17);
            regEmail.TabIndex = 10;
            regEmail.Text = "Email:";
            // 
            // regToDef
            // 
            regToDef.BackColor = Color.FromArgb(49, 49, 50);
            regToDef.Font = new Font("Verdana", 12F, FontStyle.Bold);
            regToDef.ForeColor = SystemColors.ButtonFace;
            regToDef.Location = new Point(609, 3);
            regToDef.Name = "regToDef";
            regToDef.Size = new Size(78, 27);
            regToDef.TabIndex = 15;
            regToDef.Text = "Vissza";
            regToDef.UseVisualStyleBackColor = false;
            regToDef.Click += regToDef_Click;
            // 
            // regEmailText
            // 
            regEmailText.BackColor = Color.FromArgb(49, 49, 50);
            regEmailText.ForeColor = SystemColors.Window;
            regEmailText.Location = new Point(281, 190);
            regEmailText.Name = "regEmailText";
            regEmailText.PlaceholderText = "Email";
            regEmailText.Size = new Size(163, 23);
            regEmailText.TabIndex = 11;
            regEmailText.TextAlign = HorizontalAlignment.Center;
            regEmailText.TextChanged += regEmailText_TextChanged;
            // 
            // saveReg
            // 
            saveReg.BackColor = Color.FromArgb(49, 49, 50);
            saveReg.Font = new Font("Verdana", 12F, FontStyle.Bold);
            saveReg.ForeColor = SystemColors.ButtonFace;
            saveReg.Location = new Point(294, 298);
            saveReg.Name = "saveReg";
            saveReg.Size = new Size(134, 38);
            saveReg.TabIndex = 14;
            saveReg.Text = "Regisztrálás";
            saveReg.UseVisualStyleBackColor = false;
            saveReg.Click += saveReg_Click;
            // 
            // regPass
            // 
            regPass.AutoSize = true;
            regPass.Font = new Font("Verdana", 10F, FontStyle.Bold);
            regPass.ForeColor = SystemColors.ButtonFace;
            regPass.Location = new Point(220, 258);
            regPass.Name = "regPass";
            regPass.Size = new Size(61, 17);
            regPass.TabIndex = 12;
            regPass.Text = "Jelszó:";
            // 
            // regPassText
            // 
            regPassText.BackColor = Color.FromArgb(49, 49, 50);
            regPassText.ForeColor = SystemColors.Window;
            regPassText.Location = new Point(281, 256);
            regPassText.Name = "regPassText";
            regPassText.PlaceholderText = "Jelszó";
            regPassText.Size = new Size(163, 23);
            regPassText.TabIndex = 13;
            regPassText.TextAlign = HorizontalAlignment.Center;
            // 
            // dfpnl
            // 
            dfpnl.BackColor = Color.FromArgb(43, 45, 49);
            dfpnl.Controls.Add(pictureBox1);
            dfpnl.Controls.Add(logUserText);
            dfpnl.Controls.Add(regButton);
            dfpnl.Controls.Add(logUser);
            dfpnl.Controls.Add(logLabel);
            dfpnl.Controls.Add(logPass);
            dfpnl.Controls.Add(savelog);
            dfpnl.Controls.Add(logPassText);
            dfpnl.Location = new Point(-1, 1);
            dfpnl.Name = "dfpnl";
            dfpnl.Size = new Size(690, 448);
            dfpnl.TabIndex = 16;
            dfpnl.Paint += dfpnl_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.image;
            pictureBox1.Location = new Point(220, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 159);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // logUserText
            // 
            logUserText.BackColor = Color.FromArgb(49, 49, 50);
            logUserText.ForeColor = SystemColors.Window;
            logUserText.Location = new Point(331, 266);
            logUserText.Name = "logUserText";
            logUserText.PlaceholderText = "Felhasználónév";
            logUserText.Size = new Size(163, 23);
            logUserText.TabIndex = 15;
            logUserText.TextAlign = HorizontalAlignment.Center;
            // 
            // regButton
            // 
            regButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            regButton.BackColor = Color.FromArgb(49, 49, 50);
            regButton.BackgroundImageLayout = ImageLayout.None;
            regButton.FlatAppearance.BorderColor = Color.Black;
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatAppearance.MouseDownBackColor = Color.Black;
            regButton.FlatAppearance.MouseOverBackColor = Color.Black;
            regButton.Font = new Font("Verdana", 12F, FontStyle.Bold);
            regButton.ForeColor = SystemColors.ButtonFace;
            regButton.Location = new Point(557, 410);
            regButton.Margin = new Padding(0);
            regButton.Name = "regButton";
            regButton.Size = new Size(130, 30);
            regButton.TabIndex = 6;
            regButton.Text = "Regisztráció";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // logUser
            // 
            logUser.AutoSize = true;
            logUser.Font = new Font("Verdana", 10F, FontStyle.Bold);
            logUser.ForeColor = SystemColors.ButtonFace;
            logUser.Location = new Point(193, 268);
            logUser.Name = "logUser";
            logUser.Size = new Size(132, 17);
            logUser.TabIndex = 14;
            logUser.Text = "Felhasználónév:";
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Font = new Font("Verdana", 18F, FontStyle.Bold);
            logLabel.ForeColor = SystemColors.ButtonFace;
            logLabel.Location = new Point(250, 200);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(201, 29);
            logLabel.TabIndex = 9;
            logLabel.Text = "Bejelentkezés";
            logLabel.Click += logLabel_Click;
            // 
            // logPass
            // 
            logPass.AutoSize = true;
            logPass.Font = new Font("Verdana", 10F, FontStyle.Bold);
            logPass.ForeColor = SystemColors.ButtonFace;
            logPass.Location = new Point(270, 297);
            logPass.Name = "logPass";
            logPass.Size = new Size(61, 17);
            logPass.TabIndex = 10;
            logPass.Text = "Jelszó:";
            // 
            // savelog
            // 
            savelog.BackColor = Color.FromArgb(49, 49, 50);
            savelog.Font = new Font("Verdana", 12F, FontStyle.Bold);
            savelog.ForeColor = SystemColors.ButtonFace;
            savelog.Location = new Point(279, 338);
            savelog.Name = "savelog";
            savelog.Size = new Size(134, 38);
            savelog.TabIndex = 12;
            savelog.Text = "Belépés";
            savelog.UseVisualStyleBackColor = false;
            savelog.Click += savelog_Click;
            // 
            // logPassText
            // 
            logPassText.BackColor = Color.FromArgb(49, 49, 50);
            logPassText.ForeColor = SystemColors.Window;
            logPassText.Location = new Point(331, 295);
            logPassText.Name = "logPassText";
            logPassText.PlaceholderText = "Jelszó";
            logPassText.Size = new Size(163, 23);
            logPassText.TabIndex = 11;
            logPassText.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(693, 450);
            Controls.Add(dfpnl);
            Controls.Add(rgpnl);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Wisco";
            rgpnl.ResumeLayout(false);
            rgpnl.PerformLayout();
            dfpnl.ResumeLayout(false);
            dfpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel rgpnl;
        private TextBox regUserText;
        private Label regLabel;
        private Label regUser;
        private Label regEmail;
        private Button regToDef;
        private TextBox regEmailText;
        private Button saveReg;
        private Label regPass;
        private TextBox regPassText;
        private Panel dfpnl;
        private PictureBox pictureBox1;
        private TextBox logUserText;
        private Button regButton;
        private Label logUser;
        private Label logLabel;
        private Label logPass;
        private Button savelog;
        private TextBox logPassText;
    }
}