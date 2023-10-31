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
        private List<TextBox> AddedTextBoxes = new List<TextBox>();
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

            AnswersGroupBox.Controls.Add(newTextBox);
            this.AddedTextBoxes.Add(newTextBox);
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.AddedTextBoxes.Count > 0)
            {
                TextBox textBoxToRemove = this.AddedTextBoxes[this.AddedTextBoxes.Count - 1];
                AnswersGroupBox.Controls.Remove(textBoxToRemove);
                this.AddedTextBoxes.RemoveAt(this.AddedTextBoxes.Count - 1);

                AnswersCount--;
                textBoxToRemove.Dispose();
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

        #endregion
    }
}
