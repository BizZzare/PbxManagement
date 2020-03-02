using PbxManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbxManagement
{
    public partial class LoginForm : Form
    {
        private Color _defaultColor { get; set; }
        private Color _accentColor { get; set; }

        public LoginForm()
        {
            InitializeComponent();

            _defaultColor = Color.WhiteSmoke;
            _accentColor = Color.FromArgb(0, 146, 254);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NormalizeUsernameField()
        {
            pbUsername.BackgroundImage = Resources.user_white;
            panelUsername.BackColor = _defaultColor;
            tbUsername.ForeColor = _defaultColor;
        }

        private void NormalizePasswordField()
        {
            pbPassword.BackgroundImage = Resources.password_white;
            panelPassword.BackColor = _defaultColor;
            tbPassword.ForeColor = _defaultColor;
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Clear();
            }

            pbUsername.BackgroundImage = Resources.user;
            panelUsername.BackColor = _accentColor;
            tbUsername.ForeColor = _accentColor;

            NormalizePasswordField();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == "Password")
            {
                tbPassword.Clear();
                tbPassword.PasswordChar = '•';
            }
            
            pbPassword.BackgroundImage = Resources.password;
            panelPassword.BackColor = _accentColor;
            tbPassword.ForeColor = _accentColor;

            NormalizeUsernameField();
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            btnShowPassword.BackgroundImage = Resources.eye;

            tbPasswordNormal.ForeColor = tbPassword.ForeColor;

            tbPassword.Visible = false;
            tbPasswordNormal.Visible = true;
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            btnShowPassword.BackgroundImage = Resources.closed_eye;
            tbPasswordNormal.Visible = false;
            tbPassword.Visible = true;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPasswordNormal.Text = tbPassword.Text;
        }
    }
}
