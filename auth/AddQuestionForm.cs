namespace auth
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="AddQuestionForm" />
    /// </summary>
    public partial class AddQuestionForm : Form
    {
        /// <summary>
        /// Defines the questions
        /// </summary>
        internal List<Question> questions;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddQuestionForm"/> class.
        /// </summary>
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Form1_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            questions = new List<Question>();
        }

        /// <summary>
        /// The ClearAnswerButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void ClearAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswersList.SelectedItems.Count > 0)
            {
                AnswersList.Items.Remove(AnswersList.SelectedItems[0]);
            }
        }

        /// <summary>
        /// The AddNewQuestionButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void AddNewQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionTextBox.Text.Length > 0)
            {
                Question question = new Question
                {
                    SubjectId = SubjectIdTextBox.Text,
                    QuestionType = QuestionTypeTextBox.Text,
                    QuestionText = QuestionTextBox.Text
                };

                foreach (ListViewItem answerItem in AnswersList.Items)
                {
                    Answer answer = new Answer
                    {
                        AnswerText = answerItem.SubItems[0].Text,
                        IsCorrect = answerItem.SubItems[1].Text.ToLower() == "true"
                    };

                    question.Answers.Add(answer);
                    questions.Add(question);
                }
                QuestionTextBox.Text = "";
                QuestionTypeTextBox.Text = "";
                AnswersList.Items.Clear();

                ListViewItem questionItem = new ListViewItem(question.QuestionText);
                questionItem.SubItems.Add(question.QuestionType);
                string answersText = string.Join(", ", question.Answers.Select(a => $"{a.AnswerText} ({a.IsCorrect})"));
                questionItem.SubItems.Add(answersText);
                QuestionListView.Items.Add(questionItem);
            }
        }

        /// <summary>
        /// The AddAnswerButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox.Text != "")
            {
                ListViewItem item = new ListViewItem(AnswerTextBox.Text);
                item.SubItems.Add(CorrectAnswerCheckBox.Checked.ToString());
                AnswersList.Items.Add(item);
                AnswerTextBox.Clear();
                CorrectAnswerCheckBox.Checked = false;
            }
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = QuestionListView.SelectedItems[0];

                // Remove the associated Question object
                if (selectedItem.Tag is Question questionToRemove)
                {
                    questions.Remove(questionToRemove);
                }

                // Remove the ListView item
                QuestionListView.Items.Remove(selectedItem);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //TODO: questions , navigation
        }
    }
}
