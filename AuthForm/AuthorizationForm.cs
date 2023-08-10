using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CourseWork.Enviroment;

namespace CourseWork.AuthForm
{
    public partial class AuthorizationForm : Form
    {
        private bool IsEnted = false;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (!BusinessLogic.UpdateReadInfoFromXml()) ;

            /*string DebagText = "";
            foreach (var U in BusinessLogic.Users)
            {
                DebagText+=U.DebugPrintInfo()+"\n";
            }

            DebagText += "\n";
            
            MessageBox.Show(DebagText);*/
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (EnterUsername.Text.Length == 0)
            {
                LabelUsername.ForeColor = Color.Red;
                MessageBox.Show("you left the \"Username\" field empty", "Error!");
                goto End;
            }

            if (EnterPassword.Text.Length == 0)
            {
                LabelPassword.ForeColor = Color.Red;
                MessageBox.Show("you left the \"Password\" field empty", "Error!");
                goto End;
            }

            var IndInBaseByUsername = 0;
            foreach (var user in BusinessLogic.Users)
            {
                if (user.IsThisUsername(EnterUsername.Text)) break;
                IndInBaseByUsername++;
            }

            if (IndInBaseByUsername == BusinessLogic.Users.Count)
            {
                LabelUsername.ForeColor = Color.Red;
                MessageBox.Show("No user with this Username was found", "Error!");
                goto End;
            }

            if (BusinessLogic.Users[IndInBaseByUsername].IsThisPassword(EnterPassword.Text) == false)
            {
                LabelPassword.ForeColor = Color.Red;
                MessageBox.Show("Invalid Password entered", "Error!");
                goto End;
            }

            //success
            BusinessLogic.CurrentUsername = EnterUsername.Text;
            BusinessLogic.CurrentPassword = EnterPassword.Text;
            var window = new MainForm.MainForm();
            Owner = window;
            Owner.Show();
            Hide();
            End:
            {
            }
        }

        private void EnterUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelUsername.ForeColor = Color.White;
        }

        private void EnterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelPassword.ForeColor = Color.White;
        }

        private void EnterUsername_TextChanged(object sender, EventArgs e)
        {
            var oldText = EnterUsername.Text;
            EnterUsername.Text = Regex.Replace(EnterUsername.Text, @"[^A-Za-z01-9_]", "");
            if (EnterUsername.Text != oldText)
            {
                EnterUsername.SelectionStart = EnterUsername.Text.Length;
                EnterUsername.SelectionLength = 0;
            }
        }

        private void EnterPassword_TextChanged(object sender, EventArgs e)
        {
            var oldText = EnterPassword.Text;
            EnterPassword.Text = Regex.Replace(EnterPassword.Text, @"[^A-Za-z01-9_]", "");
            if (EnterPassword.Text != oldText)
            {
                EnterPassword.SelectionStart = EnterPassword.Text.Length;
                EnterPassword.SelectionLength = 0;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ButtonLogin.Visible)
            {
                ButtonLogin.Hide();
                LabelContactPhone.Show();
                LabelEMail.Show();
                LabelRealName.Show();
                EnterPhone.Show();
                EnterPhone.Text = "";
                EnterEmail.Show();
                EnterEmail.Text = "";
                EnterRealName.Show();
                EnterRealName.Text = "";
                //show registration menu
            }
            else
            {
                //Try registration
                if (EnterUsername.Text.Length == 0)
                {
                    LabelUsername.ForeColor = Color.Red;
                    MessageBox.Show("you left the \"Username\" field empty", "Error!");
                    goto End;
                }

                if (EnterPassword.Text.Length == 0)
                {
                    LabelPassword.ForeColor = Color.Red;
                    MessageBox.Show("you left the \"Password\" field empty", "Error!");
                    goto End;
                }

                if (EnterRealName.Text.Length == 0)
                {
                    LabelRealName.ForeColor = Color.Red;
                    MessageBox.Show("you left the \"Real Name\" field empty", "Error!");
                    goto End;
                }

                var IndInBaseByUsername = 0;
                foreach (var user in BusinessLogic.Users)
                {
                    if (user.IsThisUsername(EnterUsername.Text)) break;
                    IndInBaseByUsername++;
                }

                if (IndInBaseByUsername != BusinessLogic.Users.Count)
                {
                    LabelUsername.ForeColor = Color.Red;
                    MessageBox.Show("This user is already registered", "Error!");
                    goto End;
                }

                if (!BusinessLogic.ValidatePhone(EnterPhone.Text))
                {
                    LabelContactPhone.ForeColor = Color.Red;
                    MessageBox.Show("Incorrect mobile phone number", "Error!");
                    goto End;
                }

                if (!BusinessLogic.ValidateEmail(EnterEmail.Text))
                {
                    LabelEMail.ForeColor = Color.Red;
                    MessageBox.Show("Incorrect E-mail", "Error!");
                    goto End;
                }

                //success
                while (BusinessLogic.TryRegisterNewUser(EnterUsername.Text, EnterPassword.Text, EnterPhone.Text,
                    EnterEmail.Text, EnterRealName.Text) == false) ;
                MessageBox.Show("Welcome to family!", "Notification");
                ButtonLogin.Show();
                LabelContactPhone.Hide();
                LabelEMail.Hide();
                LabelRealName.Hide();
                EnterPhone.Hide();
                EnterEmail.Hide();
                EnterRealName.Hide();

                //End
                End:
                {
                }
            }
        }

        private void EnterRealName_TextChanged(object sender, EventArgs e)
        {
            var oldText = EnterRealName.Text;
            EnterRealName.Text = Regex.Replace(EnterRealName.Text, @"[^A-Za-z]", "");
            if (EnterRealName.Text != oldText)
            {
                EnterRealName.SelectionStart = EnterRealName.Text.Length;
                EnterRealName.SelectionLength = 0;
            }
        }

        private void EnterPhone_KeyUp(object sender, KeyEventArgs e)
        {
            LabelContactPhone.ForeColor = Color.White;
        }

        private void EnterEmail_KeyUp(object sender, KeyEventArgs e)
        {
            LabelEMail.ForeColor = Color.White;
        }

        private void EnterRealName_KeyUp(object sender, KeyEventArgs e)
        {
            LabelRealName.ForeColor = Color.White;
        }
    }
}