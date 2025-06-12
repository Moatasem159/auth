namespace auth
{
    partial class TestBankManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TestCodeIDLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.IsPublishedLabel = new System.Windows.Forms.Label();
            this.SubjectIDLabel = new System.Windows.Forms.Label();
            this.QuestionsIDsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QrCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuestionIdTextBox = new System.Windows.Forms.TextBox();
            this.SubjectIDTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TestCodeIDTextBox = new System.Windows.Forms.TextBox();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new auth.CustomButton();
            this.DeleteButton = new auth.CustomButton();
            this.AddButton = new auth.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestCodeIDLabel
            // 
            this.TestCodeIDLabel.AutoSize = true;
            this.TestCodeIDLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCodeIDLabel.Location = new System.Drawing.Point(34, 59);
            this.TestCodeIDLabel.Name = "TestCodeIDLabel";
            this.TestCodeIDLabel.Size = new System.Drawing.Size(122, 37);
            this.TestCodeIDLabel.TabIndex = 0;
            this.TestCodeIDLabel.Text = "Test Code ID";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(101, 119);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(55, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(64, 179);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(92, 37);
            this.DurationLabel.TabIndex = 0;
            this.DurationLabel.Text = "Duration";
            // 
            // IsPublishedLabel
            // 
            this.IsPublishedLabel.AutoSize = true;
            this.IsPublishedLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsPublishedLabel.Location = new System.Drawing.Point(36, 359);
            this.IsPublishedLabel.Name = "IsPublishedLabel";
            this.IsPublishedLabel.Size = new System.Drawing.Size(120, 37);
            this.IsPublishedLabel.TabIndex = 0;
            this.IsPublishedLabel.Text = "Is Published";
            // 
            // SubjectIDLabel
            // 
            this.SubjectIDLabel.AutoSize = true;
            this.SubjectIDLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectIDLabel.Location = new System.Drawing.Point(53, 239);
            this.SubjectIDLabel.Name = "SubjectIDLabel";
            this.SubjectIDLabel.Size = new System.Drawing.Size(103, 37);
            this.SubjectIDLabel.TabIndex = 0;
            this.SubjectIDLabel.Text = "Subject ID";
            // 
            // QuestionsIDsLabel
            // 
            this.QuestionsIDsLabel.AutoSize = true;
            this.QuestionsIDsLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsIDsLabel.Location = new System.Drawing.Point(22, 299);
            this.QuestionsIDsLabel.Name = "QuestionsIDsLabel";
            this.QuestionsIDsLabel.Size = new System.Drawing.Size(134, 37);
            this.QuestionsIDsLabel.TabIndex = 0;
            this.QuestionsIDsLabel.Text = "Questions IDs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QrCode,
            this.BarCode});
            this.dataGridView1.Location = new System.Drawing.Point(50, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(790, 96);
            this.dataGridView1.TabIndex = 1;
            // 
            // QrCode
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.QrCode.Frozen = true;
            this.QrCode.HeaderText = "Qr Code";
            this.QrCode.MinimumWidth = 6;
            this.QrCode.Name = "QrCode";
            this.QrCode.ReadOnly = true;
            this.QrCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QrCode.Width = 300;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "Bar code";
            this.BarCode.MinimumWidth = 6;
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BarCode.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuestionIdTextBox);
            this.groupBox1.Controls.Add(this.SubjectIDTextBox);
            this.groupBox1.Controls.Add(this.DurationTextBox);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.TestCodeIDTextBox);
            this.groupBox1.Controls.Add(this.NoRadioButton);
            this.groupBox1.Controls.Add(this.YesRadioButton);
            this.groupBox1.Controls.Add(this.TestCodeIDLabel);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Controls.Add(this.DurationLabel);
            this.groupBox1.Controls.Add(this.IsPublishedLabel);
            this.groupBox1.Controls.Add(this.QuestionsIDsLabel);
            this.groupBox1.Controls.Add(this.SubjectIDLabel);
            this.groupBox1.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 410);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Information";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // QuestionIdTextBox
            // 
            this.QuestionIdTextBox.Location = new System.Drawing.Point(179, 299);
            this.QuestionIdTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.QuestionIdTextBox.Multiline = true;
            this.QuestionIdTextBox.Name = "QuestionIdTextBox";
            this.QuestionIdTextBox.Size = new System.Drawing.Size(444, 37);
            this.QuestionIdTextBox.TabIndex = 2;
            // 
            // SubjectIDTextBox
            // 
            this.SubjectIDTextBox.Location = new System.Drawing.Point(179, 239);
            this.SubjectIDTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.SubjectIDTextBox.Multiline = true;
            this.SubjectIDTextBox.Name = "SubjectIDTextBox";
            this.SubjectIDTextBox.ReadOnly = true;
            this.SubjectIDTextBox.Size = new System.Drawing.Size(444, 37);
            this.SubjectIDTextBox.TabIndex = 2;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(179, 179);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.DurationTextBox.Multiline = true;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(444, 37);
            this.DurationTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(179, 119);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(444, 37);
            this.TitleTextBox.TabIndex = 2;
            // 
            // TestCodeIDTextBox
            // 
            this.TestCodeIDTextBox.Location = new System.Drawing.Point(179, 59);
            this.TestCodeIDTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.TestCodeIDTextBox.Multiline = true;
            this.TestCodeIDTextBox.Name = "TestCodeIDTextBox";
            this.TestCodeIDTextBox.ReadOnly = true;
            this.TestCodeIDTextBox.Size = new System.Drawing.Size(444, 37);
            this.TestCodeIDTextBox.TabIndex = 2;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(285, 359);
            this.NoRadioButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(63, 41);
            this.NoRadioButton.TabIndex = 1;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(179, 359);
            this.YesRadioButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(66, 41);
            this.YesRadioButton.TabIndex = 1;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
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
            this.ClearButton.Location = new System.Drawing.Point(690, 650);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 45);
            this.ClearButton.TabIndex = 5;
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
            this.DeleteButton.Location = new System.Drawing.Point(374, 650);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 45);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextColor = System.Drawing.Color.White;
            this.DeleteButton.UseVisualStyleBackColor = false;
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
            this.AddButton.Location = new System.Drawing.Point(50, 650);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 45);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.TextColor = System.Drawing.Color.White;
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // TestBankManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(876, 746);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestBankManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Bank Manager Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TestCodeIDLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label IsPublishedLabel;
        private System.Windows.Forms.Label SubjectIDLabel;
        private System.Windows.Forms.Label QuestionsIDsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TestCodeIDTextBox;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QuestionIdTextBox;
        private System.Windows.Forms.TextBox SubjectIDTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private CustomButton AddButton;
        private CustomButton DeleteButton;
        private CustomButton ClearButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn QrCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
    }
}