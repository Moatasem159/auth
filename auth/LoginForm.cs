using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (EmailTextBox.Text == "")
            {

                isValid = false;
            }

            if (PasswordTextBox.Text == "")
            {

                isValid = false;

            }

            if (isValid)
            {
                // ✅ All fields are valid — do your action here
                MessageBox.Show("Login Successful!");
                // or save data, open another form, etc.
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterationForm form2 = new RegisterationForm();
            this.Hide();
            form2.Show();
        }
    }
}
