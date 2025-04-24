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
            EmailRequired.Visible = false;
            PasswordRequired.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm form2 = new RegisterForm();
            this.Hide();
            form2.Show();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (textBox1.Text == "")
            {
                EmailRequired.Visible = true;
                isValid = false;
            }
            else {
                EmailRequired.Visible = false;
            }
            if (textBox2.Text == "")
            {
                PasswordRequired.Visible = true;
                isValid = false;

            }
            else {
                PasswordRequired.Visible = false;
            }
            if (isValid)
            {
                // ✅ All fields are valid — do your action here
                MessageBox.Show("Login Successful!");
                // or save data, open another form, etc.
            }
        }
    }
}
