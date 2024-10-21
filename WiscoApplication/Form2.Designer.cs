namespace WiscoApplication
{
    partial class Form2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            accountPanel = new Panel();
            settingsbutton = new Guna.UI2.WinForms.Guna2Button();
            deafenbutton = new Guna.UI2.WinForms.Guna2Button();
            mutebutton = new Guna.UI2.WinForms.Guna2Button();
            availabilityIndicator = new PictureBox();
            usernameLabel = new Label();
            profilePicture = new PictureBox();
            topPanel = new Panel();

            this.Resize += new EventHandler(this.Form2_Resize);

            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availabilityIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // accountPanel
            // 
            accountPanel.AutoSize = false;
            accountPanel.BackColor = Color.FromArgb(35, 36, 40);
            accountPanel.Controls.Add(settingsbutton);
            accountPanel.Controls.Add(deafenbutton);
            accountPanel.Controls.Add(mutebutton);
            accountPanel.Controls.Add(availabilityIndicator);
            accountPanel.Controls.Add(usernameLabel);
            accountPanel.Controls.Add(profilePicture);
            accountPanel.Location = new Point(0, 401);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(269, 65);
            accountPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // settingsbutton
            // 
            settingsbutton.CustomizableEdges = customizableEdges1;
            settingsbutton.DisabledState.BorderColor = Color.DarkGray;
            settingsbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            settingsbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            settingsbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            settingsbutton.FillColor = Color.FromArgb(35, 36, 40);
            settingsbutton.Font = new Font("Segoe UI", 9F);
            settingsbutton.ForeColor = Color.White;
            settingsbutton.Image = Properties.Resources.setting;
            settingsbutton.Location = new Point(231, 15);
            settingsbutton.Margin = new Padding(4, 3, 4, 3);
            settingsbutton.Name = "settingsbutton";
            settingsbutton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            settingsbutton.Size = new Size(29, 29);
            settingsbutton.TabIndex = 7;
            settingsbutton.MouseHover += settingsbutton_MouseHover;
            // 
            // deafenbutton
            // 
            deafenbutton.CustomizableEdges = customizableEdges3;
            deafenbutton.DisabledState.BorderColor = Color.DarkGray;
            deafenbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            deafenbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deafenbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deafenbutton.FillColor = Color.FromArgb(35, 36, 40);
            deafenbutton.Font = new Font("Segoe UI", 9F);
            deafenbutton.ForeColor = Color.White;
            deafenbutton.Image = Properties.Resources.headphone;
            deafenbutton.Location = new Point(194, 15);
            deafenbutton.Margin = new Padding(4, 3, 4, 3);
            deafenbutton.Name = "deafenbutton";
            deafenbutton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deafenbutton.Size = new Size(29, 29);
            deafenbutton.TabIndex = 6;
            deafenbutton.MouseHover += deafenbutton_MouseHover;
            // 
            // mutebutton
            // 
            mutebutton.CustomizableEdges = customizableEdges5;
            mutebutton.DisabledState.BorderColor = Color.DarkGray;
            mutebutton.DisabledState.CustomBorderColor = Color.DarkGray;
            mutebutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            mutebutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            mutebutton.FillColor = Color.FromArgb(35, 36, 40);
            mutebutton.Font = new Font("Segoe UI", 9F);
            mutebutton.ForeColor = Color.White;
            mutebutton.Image = Properties.Resources.microphone;
            mutebutton.Location = new Point(157, 15);
            mutebutton.Margin = new Padding(4, 3, 4, 3);
            mutebutton.Name = "mutebutton";
            mutebutton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            mutebutton.Size = new Size(29, 29);
            mutebutton.TabIndex = 2;
            mutebutton.MouseHover += mutebutton_MouseHover;
            // 
            // availabilityIndicator
            // 
            availabilityIndicator.Image = Properties.Resources.online;
            availabilityIndicator.Location = new Point(41, 40);
            availabilityIndicator.Margin = new Padding(4, 3, 4, 3);
            availabilityIndicator.Name = "availabilityIndicator";
            availabilityIndicator.Size = new Size(18, 17);
            availabilityIndicator.SizeMode = PictureBoxSizeMode.StretchImage;
            availabilityIndicator.TabIndex = 2;
            availabilityIndicator.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            usernameLabel.ForeColor = SystemColors.ControlLight;
            usernameLabel.Location = new Point(70, 17);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 17);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // profilePicture
            // 
            profilePicture.BackgroundImageLayout = ImageLayout.None;
            profilePicture.Location = new Point(12, 12);
            profilePicture.Margin = new Padding(4, 3, 4, 3);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(47, 46);
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(43, 45, 49);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(269, 401);
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 51, 56);
            ClientSize = new Size(915, 466);
            Controls.Add(accountPanel);
            Controls.Add(topPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Wisco App - Bejelentkezve";
            Resize += Form2_Resize;
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availabilityIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button deafenButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.PictureBox availabilityIndicator;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel topPanel;
        private Guna.UI2.WinForms.Guna2Button mutebutton;
        private Guna.UI2.WinForms.Guna2Button settingsbutton;
        private Guna.UI2.WinForms.Guna2Button deafenbutton;
    }
}