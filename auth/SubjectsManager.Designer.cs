namespace auth
{
    partial class SubjectsManager
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
            this.SubjectCodeIDLabel = new System.Windows.Forms.Label();
            this.SubjectIdTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.InstructorIDLabel = new System.Windows.Forms.Label();
            this.InstructorIDTextBox = new System.Windows.Forms.TextBox();
            this.QuestionsBanksLabel = new System.Windows.Forms.Label();
            this.QuestionsBanksId = new System.Windows.Forms.TextBox();
            this.AddButton = new auth.CustomButton();
            this.ClearButton = new auth.CustomButton();
            this.DeleteButton = new auth.CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectCodeIDLabel
            // 
            this.SubjectCodeIDLabel.AutoSize = true;
            this.SubjectCodeIDLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCodeIDLabel.Location = new System.Drawing.Point(6, 47);
            this.SubjectCodeIDLabel.Name = "SubjectCodeIDLabel";
            this.SubjectCodeIDLabel.Size = new System.Drawing.Size(150, 37);
            this.SubjectCodeIDLabel.TabIndex = 0;
            this.SubjectCodeIDLabel.Text = "Subject Code ID";
            // 
            // SubjectIdTextBox
            // 
            this.SubjectIdTextBox.Location = new System.Drawing.Point(175, 51);
            this.SubjectIdTextBox.Multiline = true;
            this.SubjectIdTextBox.Name = "SubjectIdTextBox";
            this.SubjectIdTextBox.Size = new System.Drawing.Size(150, 24);
            this.SubjectIdTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(88, 89);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 37);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 96);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 24);
            this.NameTextBox.TabIndex = 2;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(41, 136);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(115, 37);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(175, 148);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(503, 60);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // InstructorIDLabel
            // 
            this.InstructorIDLabel.AutoSize = true;
            this.InstructorIDLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorIDLabel.Location = new System.Drawing.Point(399, 38);
            this.InstructorIDLabel.Name = "InstructorIDLabel";
            this.InstructorIDLabel.Size = new System.Drawing.Size(123, 37);
            this.InstructorIDLabel.TabIndex = 4;
            this.InstructorIDLabel.Text = "Instructor ID";
            // 
            // InstructorIDTextBox
            // 
            this.InstructorIDTextBox.Location = new System.Drawing.Point(528, 44);
            this.InstructorIDTextBox.Multiline = true;
            this.InstructorIDTextBox.Name = "InstructorIDTextBox";
            this.InstructorIDTextBox.ReadOnly = true;
            this.InstructorIDTextBox.Size = new System.Drawing.Size(150, 24);
            this.InstructorIDTextBox.TabIndex = 4;
            this.InstructorIDTextBox.TextChanged += new System.EventHandler(this.InstructorIDTextBox_TextChanged);
            // 
            // QuestionsBanksLabel
            // 
            this.QuestionsBanksLabel.AutoSize = true;
            this.QuestionsBanksLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsBanksLabel.Location = new System.Drawing.Point(363, 89);
            this.QuestionsBanksLabel.Name = "QuestionsBanksLabel";
            this.QuestionsBanksLabel.Size = new System.Drawing.Size(159, 37);
            this.QuestionsBanksLabel.TabIndex = 5;
            this.QuestionsBanksLabel.Text = "Questions Banks";
            // 
            // QuestionsBanksId
            // 
            this.QuestionsBanksId.Location = new System.Drawing.Point(528, 96);
            this.QuestionsBanksId.Multiline = true;
            this.QuestionsBanksId.Name = "QuestionsBanksId";
            this.QuestionsBanksId.ReadOnly = true;
            this.QuestionsBanksId.Size = new System.Drawing.Size(150, 24);
            this.QuestionsBanksId.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Green;
            this.AddButton.BackgroundColor = System.Drawing.Color.Green;
            this.AddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddButton.BorderRadius = 10;
            this.AddButton.BorderSize = 0;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(39, 295);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 45);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.TextColor = System.Drawing.Color.White;
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.BackgroundColor = System.Drawing.Color.Red;
            this.ClearButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClearButton.BorderRadius = 10;
            this.ClearButton.BorderSize = 0;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(598, 295);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 45);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextColor = System.Drawing.Color.White;
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.BackgroundColor = System.Drawing.Color.Red;
            this.DeleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.BorderSize = 0;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(318, 295);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 45);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextColor = System.Drawing.Color.White;
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.InstructorIDLabel);
            this.groupBox1.Controls.Add(this.QuestionsBanksLabel);
            this.groupBox1.Controls.Add(this.QuestionsBanksId);
            this.groupBox1.Controls.Add(this.InstructorIDTextBox);
            this.groupBox1.Controls.Add(this.SubjectIdTextBox);
            this.groupBox1.Controls.Add(this.SubjectCodeIDLabel);
            this.groupBox1.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            // 
            // SubjectsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(787, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Name = "SubjectsManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SubjectCodeIDLabel;
        private System.Windows.Forms.TextBox SubjectIdTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label InstructorIDLabel;
        private System.Windows.Forms.TextBox InstructorIDTextBox;
        private System.Windows.Forms.Label QuestionsBanksLabel;
        private System.Windows.Forms.TextBox QuestionsBanksId;
        private CustomButton AddButton;
        private CustomButton ClearButton;
        private CustomButton DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}