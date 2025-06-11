namespace auth
{
    partial class RegisterationForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new auth.CustomButton();
            this.SubmitButton = new auth.CustomButton();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(44, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 34);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(44, 113);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 34);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(479, 113);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(49, 34);
            this.RoleLabel.TabIndex = 0;
            this.RoleLabel.Text = "Role";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(44, 187);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 34);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.NameTextBox.Location = new System.Drawing.Point(47, 77);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.MaximumSize = new System.Drawing.Size(250, 30);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(250, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.EmailTextBox.Location = new System.Drawing.Point(47, 151);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.MaximumSize = new System.Drawing.Size(250, 30);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(250, 30);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(250, 30);
            this.EmailTextBox.TabIndex = 2;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DepartmentTextBox.Location = new System.Drawing.Point(485, 151);
            this.DepartmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentTextBox.MaximumSize = new System.Drawing.Size(250, 30);
            this.DepartmentTextBox.MinimumSize = new System.Drawing.Size(250, 30);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(250, 30);
            this.DepartmentTextBox.TabIndex = 5;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PhoneTextBox.Location = new System.Drawing.Point(485, 77);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.MaximumSize = new System.Drawing.Size(250, 30);
            this.PhoneTextBox.MinimumSize = new System.Drawing.Size(250, 30);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(250, 30);
            this.PhoneTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(47, 225);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.MaximumSize = new System.Drawing.Size(250, 30);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(250, 30);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 30);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.BackgroundColor = System.Drawing.Color.Red;
            this.ClearButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClearButton.BorderRadius = 8;
            this.ClearButton.BorderSize = 0;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(288, 363);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(240, 45);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextColor = System.Drawing.Color.White;
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Green;
            this.SubmitButton.BackgroundColor = System.Drawing.Color.Green;
            this.SubmitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SubmitButton.BorderRadius = 8;
            this.SubmitButton.BorderSize = 0;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(288, 287);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(240, 45);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.TextColor = System.Drawing.Color.White;
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // RegisterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private CustomButton SubmitButton;
        private CustomButton ClearButton;
    }
}