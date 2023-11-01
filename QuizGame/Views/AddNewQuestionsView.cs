using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.Views
{
    public partial class AddNewQuestionsView : UserControl
    {
        #region Private Fields
        private int AnswersCount = 0;
        private Dictionary<TextBox, CheckBox> Questions = new Dictionary<TextBox, CheckBox>();
        private Point AddButtonPrimaryLocation;
        private enum Operations
        {
            Add,
            Remove,
        }
        #endregion

        #region Public Methods
        public AddNewQuestionsView()
        {
            InitializeComponent();
            AddButtonPrimaryLocation = new Point(AddNewQuestionButton.Location.X, AddNewQuestionButton.Location.Y);
        }
        #endregion

        #region Private Methods
        private void BackButton_Click(object sender, EventArgs e)
        {
            var homeView = new HomeView();
            homeView.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(homeView);
        }

        private void AddNewQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.AnswersCount >= 11)
            {
                return;
            }

            AnswersCount++;

            ToggleButtons(Operations.Add);

            int x = AddNewQuestionButton.Location.X;
            int y = AddNewQuestionButton.Location.Y - 25;

            TextBox newTextBox = new TextBox
            {
                Size = new Size(242, 23),
                Location = new Point(x, y)
            };

            CheckBox newCheckBox = new CheckBox
            {
                Location = new Point(x + newTextBox.Width + 5, y)
            };

            AnswersGroupBox.Controls.Add(newTextBox);
            AnswersGroupBox.Controls.Add(newCheckBox);

            Questions.Add(newTextBox, newCheckBox);
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.Questions.Count > 0)
            {
                var lastQuestion = Questions.Last();

                TextBox textBoxToRemove = lastQuestion.Key;
                CheckBox checkBoxToRemove = lastQuestion.Value;

                AnswersGroupBox.Controls.Remove(textBoxToRemove);
                AnswersGroupBox.Controls.Remove(checkBoxToRemove);

                Questions.Remove(textBoxToRemove);

                AnswersCount--;

                textBoxToRemove.Dispose();
                checkBoxToRemove.Dispose();

                ToggleButtons(Operations.Remove);
            }
        }

        private void ToggleButtons(Operations operation)
        {
            int addButtonLocationX = AddNewQuestionButton.Location.X;
            int addButtonLocationY = AddNewQuestionButton.Location.Y;

            int removeButtonLocationX = RemoveQuestionButton.Location.X;
            int removeButtonLocationY = RemoveQuestionButton.Location.Y;

            if (operation == Operations.Add)
            {
                RemoveQuestionButton.Visible = true;

                AddNewQuestionButton.Location = new Point(addButtonLocationX, addButtonLocationY + 25);
                RemoveQuestionButton.Location = new Point(removeButtonLocationX, removeButtonLocationY + 25);
            }
            else
            {
                AddNewQuestionButton.Location = new Point(addButtonLocationX, addButtonLocationY - 25);
                RemoveQuestionButton.Location = new Point(removeButtonLocationX, removeButtonLocationY - 25);

                if(this.AnswersCount == 0)
                {
                    RemoveQuestionButton.Visible = false;
                }
            }
        }

        private void SubmitQuestionButton_Click(object sender, EventArgs e)
        {
            Question question = new Question();

            question.Content = QuestionContentTextBox.Text;

            int correctAnswers = 0;

            foreach (var q in Questions)
            {
                string text = q.Key.Text;
                bool isChecked = q.Value.Checked;

                if (question.Questions.ContainsKey(text))
                {
                    string message = "Questions can't have the same answers";
                    string caption = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(message, caption, buttons, icon);
                    return;
                }
                question.Questions.Add(text, isChecked);

                if(isChecked)
                {
                    correctAnswers++;
                }
            }

            if(question.Content == "")
            {
                string message = "Question can't be empty!";
                string caption = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, caption, buttons, icon);
                return;

            }

            QuestionContentTextBox.Text = "";

            foreach (var q in Questions)
            {
                AnswersGroupBox.Controls.Remove(q.Key);
                AnswersGroupBox.Controls.Remove(q.Value);

                q.Key.Dispose();
                q.Value.Dispose();
            }

            Questions.Clear();
            AnswersCount = 0;
            AddNewQuestionButton.Location = AddButtonPrimaryLocation;
            RemoveQuestionButton.Location = new Point(RemoveQuestionButton.Location.X, AddButtonPrimaryLocation.Y + 25);
            RemoveQuestionButton.Visible = false;

            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            question.NumberOfCorrectAnswers = correctAnswers;

            question.saveToFile();
        }

        #endregion
    }
}
