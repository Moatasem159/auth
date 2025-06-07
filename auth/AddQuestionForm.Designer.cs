namespace auth
{
    partial class AddQuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.SubjectIDLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.SubjectIdTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTypeTextBox = new System.Windows.Forms.TextBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.CorrectAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.QusetionTypeLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AnswersList = new System.Windows.Forms.ListView();
            this.Answers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuestionListView = new System.Windows.Forms.ListView();
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuestionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnswersHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new auth.CustomButton();
            this.RemoveQuestionButton = new auth.CustomButton();
            this.AddQuestionButton = new auth.CustomButton();
            this.RemoveAnswerButton = new auth.CustomButton();
            this.AddAnswerButton = new auth.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectIDLabel
            // 
            this.SubjectIDLabel.AutoSize = true;
            this.SubjectIDLabel.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectIDLabel.Location = new System.Drawing.Point(32, 28);
            this.SubjectIDLabel.Name = "SubjectIDLabel";
            this.SubjectIDLabel.Size = new System.Drawing.Size(124, 43);
            this.SubjectIDLabel.TabIndex = 1;
            this.SubjectIDLabel.Text = "Subject Id";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(503, 34);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(114, 43);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(503, 171);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(100, 43);
            this.AnswerLabel.TabIndex = 1;
            this.AnswerLabel.Text = "Answer";
            // 
            // SubjectIdTextBox
            // 
            this.SubjectIdTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubjectIdTextBox.Enabled = false;
            this.SubjectIdTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SubjectIdTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.SubjectIdTextBox.Location = new System.Drawing.Point(278, 41);
            this.SubjectIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectIdTextBox.MaximumSize = new System.Drawing.Size(120, 30);
            this.SubjectIdTextBox.MinimumSize = new System.Drawing.Size(120, 30);
            this.SubjectIdTextBox.Name = "SubjectIdTextBox";
            this.SubjectIdTextBox.ReadOnly = true;
            this.SubjectIdTextBox.Size = new System.Drawing.Size(120, 30);
            this.SubjectIdTextBox.TabIndex = 0;
            // 
            // QuestionTypeTextBox
            // 
            this.QuestionTypeTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.QuestionTypeTextBox.Location = new System.Drawing.Point(278, 89);
            this.QuestionTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionTypeTextBox.MaximumSize = new System.Drawing.Size(500, 60);
            this.QuestionTypeTextBox.MinimumSize = new System.Drawing.Size(120, 30);
            this.QuestionTypeTextBox.Name = "QuestionTypeTextBox";
            this.QuestionTypeTextBox.Size = new System.Drawing.Size(120, 32);
            this.QuestionTypeTextBox.TabIndex = 1;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.QuestionTextBox.Location = new System.Drawing.Point(628, 41);
            this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionTextBox.MaximumSize = new System.Drawing.Size(250, 100);
            this.QuestionTextBox.MinimumSize = new System.Drawing.Size(120, 30);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(250, 100);
            this.QuestionTextBox.TabIndex = 2;
            // 
            // CorrectAnswerCheckBox
            // 
            this.CorrectAnswerCheckBox.AutoSize = true;
            this.CorrectAnswerCheckBox.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerCheckBox.Location = new System.Drawing.Point(628, 285);
            this.CorrectAnswerCheckBox.Name = "CorrectAnswerCheckBox";
            this.CorrectAnswerCheckBox.Size = new System.Drawing.Size(167, 41);
            this.CorrectAnswerCheckBox.TabIndex = 4;
            this.CorrectAnswerCheckBox.Text = "Correct answer";
            this.CorrectAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // QusetionTypeLabel
            // 
            this.QusetionTypeLabel.AutoSize = true;
            this.QusetionTypeLabel.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QusetionTypeLabel.Location = new System.Drawing.Point(32, 82);
            this.QusetionTypeLabel.Name = "QusetionTypeLabel";
            this.QusetionTypeLabel.Size = new System.Drawing.Size(167, 43);
            this.QusetionTypeLabel.TabIndex = 1;
            this.QusetionTypeLabel.Text = "Question type";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AnswerTextBox.Location = new System.Drawing.Point(628, 178);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerTextBox.MaximumSize = new System.Drawing.Size(250, 100);
            this.AnswerTextBox.MinimumSize = new System.Drawing.Size(120, 30);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(250, 100);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(auth.Question);
            // 
            // questionBindingSource1
            // 
            this.questionBindingSource1.DataSource = typeof(auth.Question);
            // 
            // AnswersList
            // 
            this.AnswersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Answers,
            this.CorrectAnswer});
            this.AnswersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnswersList.Font = new System.Drawing.Font("Cairo Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswersList.FullRowSelect = true;
            this.AnswersList.GridLines = true;
            this.AnswersList.HideSelection = false;
            this.AnswersList.Location = new System.Drawing.Point(31, 138);
            this.AnswersList.MaximumSize = new System.Drawing.Size(400, 210);
            this.AnswersList.MinimumSize = new System.Drawing.Size(380, 210);
            this.AnswersList.Name = "AnswersList";
            this.AnswersList.Size = new System.Drawing.Size(396, 210);
            this.AnswersList.TabIndex = 6;
            this.AnswersList.UseCompatibleStateImageBehavior = false;
            this.AnswersList.View = System.Windows.Forms.View.Details;
            // 
            // Answers
            // 
            this.Answers.Text = "Answers";
            this.Answers.Width = 220;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.Text = "Correct answer";
            this.CorrectAnswer.Width = 150;
            // 
            // QuestionListView
            // 
            this.QuestionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Question,
            this.QuestionType,
            this.AnswersHeader});
            this.QuestionListView.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionListView.FullRowSelect = true;
            this.QuestionListView.GridLines = true;
            this.QuestionListView.HideSelection = false;
            this.QuestionListView.Location = new System.Drawing.Point(40, 472);
            this.QuestionListView.Name = "QuestionListView";
            this.QuestionListView.Size = new System.Drawing.Size(903, 257);
            this.QuestionListView.TabIndex = 7;
            this.QuestionListView.UseCompatibleStateImageBehavior = false;
            this.QuestionListView.View = System.Windows.Forms.View.Details;
            // 
            // Question
            // 
            this.Question.Text = "Question";
            this.Question.Width = 300;
            // 
            // QuestionType
            // 
            this.QuestionType.Text = "Question type";
            this.QuestionType.Width = 90;
            // 
            // AnswersHeader
            // 
            this.AnswersHeader.Text = "Answers";
            this.AnswersHeader.Width = 338;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question type";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SubmitButton.BorderRadius = 10;
            this.SubmitButton.BorderSize = 0;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(744, 735);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(199, 48);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.TextColor = System.Drawing.Color.White;
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RemoveQuestionButton
            // 
            this.RemoveQuestionButton.BackColor = System.Drawing.Color.Red;
            this.RemoveQuestionButton.BackgroundColor = System.Drawing.Color.Red;
            this.RemoveQuestionButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RemoveQuestionButton.BorderRadius = 10;
            this.RemoveQuestionButton.BorderSize = 0;
            this.RemoveQuestionButton.FlatAppearance.BorderSize = 0;
            this.RemoveQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveQuestionButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveQuestionButton.ForeColor = System.Drawing.Color.White;
            this.RemoveQuestionButton.Location = new System.Drawing.Point(40, 735);
            this.RemoveQuestionButton.Name = "RemoveQuestionButton";
            this.RemoveQuestionButton.Size = new System.Drawing.Size(199, 48);
            this.RemoveQuestionButton.TabIndex = 5;
            this.RemoveQuestionButton.Text = "Remove question ";
            this.RemoveQuestionButton.TextColor = System.Drawing.Color.White;
            this.RemoveQuestionButton.UseVisualStyleBackColor = false;
            this.RemoveQuestionButton.Click += new System.EventHandler(this.RemoveQuestionButton_Click);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.BackColor = System.Drawing.Color.Green;
            this.AddQuestionButton.BackgroundColor = System.Drawing.Color.Green;
            this.AddQuestionButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddQuestionButton.BorderRadius = 10;
            this.AddQuestionButton.BorderSize = 0;
            this.AddQuestionButton.FlatAppearance.BorderSize = 0;
            this.AddQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQuestionButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestionButton.ForeColor = System.Drawing.Color.White;
            this.AddQuestionButton.Location = new System.Drawing.Point(31, 354);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(175, 48);
            this.AddQuestionButton.TabIndex = 5;
            this.AddQuestionButton.Text = "Add question ";
            this.AddQuestionButton.TextColor = System.Drawing.Color.White;
            this.AddQuestionButton.UseVisualStyleBackColor = false;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddNewQuestionButton_Click);
            // 
            // RemoveAnswerButton
            // 
            this.RemoveAnswerButton.BackColor = System.Drawing.Color.Red;
            this.RemoveAnswerButton.BackgroundColor = System.Drawing.Color.Red;
            this.RemoveAnswerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RemoveAnswerButton.BorderRadius = 10;
            this.RemoveAnswerButton.BorderSize = 0;
            this.RemoveAnswerButton.FlatAppearance.BorderSize = 0;
            this.RemoveAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAnswerButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAnswerButton.ForeColor = System.Drawing.Color.White;
            this.RemoveAnswerButton.Location = new System.Drawing.Point(628, 396);
            this.RemoveAnswerButton.Name = "RemoveAnswerButton";
            this.RemoveAnswerButton.Size = new System.Drawing.Size(167, 48);
            this.RemoveAnswerButton.TabIndex = 5;
            this.RemoveAnswerButton.Text = "Remove answer ";
            this.RemoveAnswerButton.TextColor = System.Drawing.Color.White;
            this.RemoveAnswerButton.UseVisualStyleBackColor = false;
            this.RemoveAnswerButton.Click += new System.EventHandler(this.ClearAnswerButton_Click);
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.BackColor = System.Drawing.Color.Green;
            this.AddAnswerButton.BackgroundColor = System.Drawing.Color.Green;
            this.AddAnswerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddAnswerButton.BorderRadius = 10;
            this.AddAnswerButton.BorderSize = 0;
            this.AddAnswerButton.FlatAppearance.BorderSize = 0;
            this.AddAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnswerButton.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnswerButton.ForeColor = System.Drawing.Color.White;
            this.AddAnswerButton.Location = new System.Drawing.Point(628, 332);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(167, 48);
            this.AddAnswerButton.TabIndex = 5;
            this.AddAnswerButton.Text = "Add answer";
            this.AddAnswerButton.TextColor = System.Drawing.Color.White;
            this.AddAnswerButton.UseVisualStyleBackColor = false;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(982, 823);
            this.Controls.Add(this.QuestionListView);
            this.Controls.Add(this.AnswersList);
            this.Controls.Add(this.CorrectAnswerCheckBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RemoveQuestionButton);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.RemoveAnswerButton);
            this.Controls.Add(this.AddAnswerButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.QuestionTypeTextBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.SubjectIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QusetionTypeLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SubjectIDLabel);
            this.MaximumSize = new System.Drawing.Size(1000, 870);
            this.MinimumSize = new System.Drawing.Size(1000, 870);
            this.Name = "AddQuestionForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SubjectIDLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox SubjectIdTextBox;
        private System.Windows.Forms.TextBox QuestionTypeTextBox;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private CustomButton AddAnswerButton;
        private System.Windows.Forms.CheckBox CorrectAnswerCheckBox;
        private System.Windows.Forms.Label QusetionTypeLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private CustomButton RemoveAnswerButton;
        private CustomButton AddQuestionButton;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.BindingSource questionBindingSource1;
        private System.Windows.Forms.ListView AnswersList;
        private System.Windows.Forms.ColumnHeader Answers;
        private System.Windows.Forms.ColumnHeader CorrectAnswer;
        private System.Windows.Forms.ListView QuestionListView;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.ColumnHeader QuestionType;
        private System.Windows.Forms.ColumnHeader AnswersHeader;
        private CustomButton RemoveQuestionButton;
        private System.Windows.Forms.Label label1;
        private CustomButton SubmitButton;
    }
}