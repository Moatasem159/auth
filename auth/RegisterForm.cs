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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            NameRequired.Visible = false;
            DepartmentRequired.Visible = false;
            PhoneRequired.Visible = false;
            EmailRequired.Visible = false;
            PasswordRequired.Visible = false;
            ConfirmPasswordRequired.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameRequired.Visible = true;
                isValid = false;
            }
            else
            {
                NameRequired.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(DepartmentTextBox.Text))
            {
                DepartmentRequired.Visible = true;
                isValid = false;
            }
            else
            {
                DepartmentRequired.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                PhoneRequired.Visible = true;
                isValid = false;
            }
            else
            {
                PhoneRequired.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailRequired.Visible = true;
                isValid = false;
            }
            else
            {
                EmailRequired.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordRequired.Visible = true;
                isValid = false;
            }
            else
            {
                PasswordRequired.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                ConfirmPasswordRequired.Visible = true;
                isValid = false;
            }
            else if (ConfirmPasswordTextBox.Text != PasswordTextBox.Text) {

                ConfirmPasswordRequired.Visible = true;
                isValid = false;
            }
            else
            {
                ConfirmPasswordRequired.Visible = false;
            }

            if (isValid)
            {
                // ✅ All fields are valid — do your action here
                MessageBox.Show("Registration Successful!");
                // or save data, open another form, etc.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.Show();
        }
    }
}
