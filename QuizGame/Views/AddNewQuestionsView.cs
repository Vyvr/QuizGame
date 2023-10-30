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
        private int AnswersCount = 0;

        public AddNewQuestionsView()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var homeView = new HomeView();
            homeView.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(homeView);
        }

        private void AddNewQuestionButton_Click(object sender, EventArgs e)
        {
            if(this.AnswersCount >=12)
            {
                return;
            }
            int x = AddNewQuestionButton.Location.X;
            int y = AddNewQuestionButton.Location.Y;

            // Create and configure the new TextBox
            TextBox newTextBox = new TextBox
            {
                Size = new Size(242, 23),
                Location = new Point(x, y)
            };

            // Add the TextBox to the GroupBox
            AnswersGroupBox.Controls.Add(newTextBox);

            // Move the button down
            AddNewQuestionButton.Location = new Point(x, y + 25);

            // Increase the counter
            AnswersCount++;
        }
    }
}
