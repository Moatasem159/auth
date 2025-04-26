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
          
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(DepartmentTextBox.Text))
            {

                isValid = false;
            }


            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {

                isValid = false;
            }

            if (isValid)
            {
                // ✅ All fields are valid — do your action here
                MessageBox.Show("Registration Successful!");
                // or save data, open another form, etc.
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.Show();
        }
    }
}
