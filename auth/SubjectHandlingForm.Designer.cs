namespace auth
{
    partial class SubjectHandlingForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SubjectsButton = new auth.CustomButton();
            this.QuestionsBanksButton = new auth.CustomButton();
            this.TestsBanksButton = new auth.CustomButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 60, 3, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 24);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 218);
            this.textBox2.Margin = new System.Windows.Forms.Padding(60, 0, 60, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 24);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 367);
            this.textBox3.Margin = new System.Windows.Forms.Padding(60, 0, 60, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 24);
            this.textBox3.TabIndex = 5;
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.BackColor = System.Drawing.Color.Green;
            this.SubjectsButton.BackgroundColor = System.Drawing.Color.Green;
            this.SubjectsButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SubjectsButton.BorderRadius = 10;
            this.SubjectsButton.BorderSize = 0;
            this.SubjectsButton.FlatAppearance.BorderSize = 0;
            this.SubjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsButton.ForeColor = System.Drawing.Color.White;
            this.SubjectsButton.Location = new System.Drawing.Point(104, 133);
            this.SubjectsButton.Margin = new System.Windows.Forms.Padding(60, 0, 60, 40);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(175, 45);
            this.SubjectsButton.TabIndex = 2;
            this.SubjectsButton.Text = "Subjects";
            this.SubjectsButton.TextColor = System.Drawing.Color.White;
            this.SubjectsButton.UseVisualStyleBackColor = false;
            // 
            // QuestionsBanksButton
            // 
            this.QuestionsBanksButton.BackColor = System.Drawing.Color.Blue;
            this.QuestionsBanksButton.BackgroundColor = System.Drawing.Color.Blue;
            this.QuestionsBanksButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.QuestionsBanksButton.BorderRadius = 10;
            this.QuestionsBanksButton.BorderSize = 0;
            this.QuestionsBanksButton.FlatAppearance.BorderSize = 0;
            this.QuestionsBanksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionsBanksButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsBanksButton.ForeColor = System.Drawing.Color.White;
            this.QuestionsBanksButton.Location = new System.Drawing.Point(104, 282);
            this.QuestionsBanksButton.Margin = new System.Windows.Forms.Padding(60, 0, 60, 40);
            this.QuestionsBanksButton.Name = "QuestionsBanksButton";
            this.QuestionsBanksButton.Size = new System.Drawing.Size(175, 45);
            this.QuestionsBanksButton.TabIndex = 4;
            this.QuestionsBanksButton.Text = "Questions Banks";
            this.QuestionsBanksButton.TextColor = System.Drawing.Color.White;
            this.QuestionsBanksButton.UseVisualStyleBackColor = false;
            // 
            // TestsBanksButton
            // 
            this.TestsBanksButton.BackColor = System.Drawing.Color.DarkOrange;
            this.TestsBanksButton.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.TestsBanksButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TestsBanksButton.BorderRadius = 10;
            this.TestsBanksButton.BorderSize = 0;
            this.TestsBanksButton.FlatAppearance.BorderSize = 0;
            this.TestsBanksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestsBanksButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestsBanksButton.ForeColor = System.Drawing.Color.White;
            this.TestsBanksButton.Location = new System.Drawing.Point(104, 431);
            this.TestsBanksButton.Margin = new System.Windows.Forms.Padding(0);
            this.TestsBanksButton.Name = "TestsBanksButton";
            this.TestsBanksButton.Size = new System.Drawing.Size(175, 45);
            this.TestsBanksButton.TabIndex = 6;
            this.TestsBanksButton.Text = "Tests Banks";
            this.TestsBanksButton.TextColor = System.Drawing.Color.White;
            this.TestsBanksButton.UseVisualStyleBackColor = false;
            // 
            // SubjectHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(384, 527);
            this.Controls.Add(this.TestsBanksButton);
            this.Controls.Add(this.QuestionsBanksButton);
            this.Controls.Add(this.SubjectsButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SubjectHandlingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Handling Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private CustomButton SubjectsButton;
        private CustomButton QuestionsBanksButton;
        private CustomButton TestsBanksButton;
    }
}