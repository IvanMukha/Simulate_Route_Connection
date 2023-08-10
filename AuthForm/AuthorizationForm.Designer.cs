namespace CourseWork.AuthForm
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.EnterUsername = new System.Windows.Forms.TextBox();
            this.EnterPassword = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Label();
            this.EnterPhone = new System.Windows.Forms.TextBox();
            this.EnterEmail = new System.Windows.Forms.TextBox();
            this.EnterRealName = new System.Windows.Forms.TextBox();
            this.LabelContactPhone = new System.Windows.Forms.Label();
            this.LabelEMail = new System.Windows.Forms.Label();
            this.LabelRealName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LabelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelWelcome.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelWelcome.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelWelcome.Location = new System.Drawing.Point(65, 36);
            this.LabelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(541, 140);
            this.LabelWelcome.TabIndex = 1;
            this.LabelWelcome.Text = "You\'re welcome";
            // 
            // LabelUsername
            // 
            this.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.LabelUsername.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelUsername.Location = new System.Drawing.Point(542, 53);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(279, 40);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelPassword.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelPassword.Location = new System.Drawing.Point(542, 149);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(279, 40);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.ButtonLogin.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ButtonLogin.Location = new System.Drawing.Point(542, 246);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(279, 93);
            this.ButtonLogin.TabIndex = 6;
            this.ButtonLogin.Text = "LOG IN";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // EnterUsername
            // 
            this.EnterUsername.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.EnterUsername.Location = new System.Drawing.Point(542, 96);
            this.EnterUsername.MaxLength = 20;
            this.EnterUsername.Name = "EnterUsername";
            this.EnterUsername.ShortcutsEnabled = false;
            this.EnterUsername.Size = new System.Drawing.Size(279, 50);
            this.EnterUsername.TabIndex = 8;
            this.EnterUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterUsername.TextChanged += new System.EventHandler(this.EnterUsername_TextChanged);
            this.EnterUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUsername_KeyPress);
            // 
            // EnterPassword
            // 
            this.EnterPassword.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.EnterPassword.Location = new System.Drawing.Point(542, 191);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.PasswordChar = '*';
            this.EnterPassword.Size = new System.Drawing.Size(279, 50);
            this.EnterPassword.TabIndex = 9;
            this.EnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterPassword.TextChanged += new System.EventHandler(this.EnterPassword_TextChanged);
            this.EnterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPassword_KeyPress);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.RegisterButton.Font = new System.Drawing.Font("MV Boli", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (1)), true);
            this.RegisterButton.ForeColor = System.Drawing.Color.Black;
            this.RegisterButton.Location = new System.Drawing.Point(826, 96);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(38, 243);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "S I G N    U P";
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // EnterPhone
            // 
            this.EnterPhone.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.EnterPhone.Location = new System.Drawing.Point(543, 289);
            this.EnterPhone.Name = "EnterPhone";
            this.EnterPhone.Size = new System.Drawing.Size(279, 50);
            this.EnterPhone.TabIndex = 11;
            this.EnterPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterPhone.Visible = false;
            this.EnterPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterPhone_KeyUp);
            // 
            // EnterEmail
            // 
            this.EnterEmail.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.EnterEmail.Location = new System.Drawing.Point(543, 389);
            this.EnterEmail.Name = "EnterEmail";
            this.EnterEmail.Size = new System.Drawing.Size(279, 50);
            this.EnterEmail.TabIndex = 12;
            this.EnterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterEmail.Visible = false;
            this.EnterEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterEmail_KeyUp);
            // 
            // EnterRealName
            // 
            this.EnterRealName.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold);
            this.EnterRealName.Location = new System.Drawing.Point(543, 486);
            this.EnterRealName.Name = "EnterRealName";
            this.EnterRealName.Size = new System.Drawing.Size(279, 50);
            this.EnterRealName.TabIndex = 13;
            this.EnterRealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterRealName.Visible = false;
            this.EnterRealName.TextChanged += new System.EventHandler(this.EnterRealName_TextChanged);
            this.EnterRealName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterRealName_KeyUp);
            // 
            // LabelContactPhone
            // 
            this.LabelContactPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.LabelContactPhone.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelContactPhone.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelContactPhone.Location = new System.Drawing.Point(543, 246);
            this.LabelContactPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelContactPhone.Name = "LabelContactPhone";
            this.LabelContactPhone.Size = new System.Drawing.Size(279, 40);
            this.LabelContactPhone.TabIndex = 14;
            this.LabelContactPhone.Text = "Contact Phone";
            this.LabelContactPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelContactPhone.Visible = false;
            // 
            // LabelEMail
            // 
            this.LabelEMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelEMail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEMail.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelEMail.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelEMail.Location = new System.Drawing.Point(543, 346);
            this.LabelEMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEMail.Name = "LabelEMail";
            this.LabelEMail.Size = new System.Drawing.Size(279, 40);
            this.LabelEMail.TabIndex = 15;
            this.LabelEMail.Text = "E-Mail";
            this.LabelEMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelEMail.Visible = false;
            // 
            // LabelRealName
            // 
            this.LabelRealName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRealName.BackColor = System.Drawing.Color.Transparent;
            this.LabelRealName.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelRealName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LabelRealName.Location = new System.Drawing.Point(543, 443);
            this.LabelRealName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRealName.Name = "LabelRealName";
            this.LabelRealName.Size = new System.Drawing.Size(279, 40);
            this.LabelRealName.TabIndex = 16;
            this.LabelRealName.Text = "Real Name";
            this.LabelRealName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRealName.Visible = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::CourseWork.Properties.Resources.Sirocco;
            this.ClientSize = new System.Drawing.Size(957, 683);
            this.Controls.Add(this.LabelRealName);
            this.Controls.Add(this.LabelEMail);
            this.Controls.Add(this.LabelContactPhone);
            this.Controls.Add(this.EnterRealName);
            this.Controls.Add(this.EnterEmail);
            this.Controls.Add(this.EnterPhone);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.EnterPassword);
            this.Controls.Add(this.EnterUsername);
            this.Controls.Add(this.LabelWelcome);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelPassword);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuthorizationForm";
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox EnterEmail;
        private System.Windows.Forms.TextBox EnterPhone;
        private System.Windows.Forms.TextBox EnterRealName;
        private System.Windows.Forms.Label LabelContactPhone;
        private System.Windows.Forms.Label LabelEMail;
        private System.Windows.Forms.Label LabelRealName;

        private System.Windows.Forms.Label RegisterButton;

        private System.Windows.Forms.TextBox EnterPassword;

        private System.Windows.Forms.TextBox EnterUsername;

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelWelcome;

        #endregion
    }
}