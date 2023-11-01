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
    public partial class SummaryView : UserControl
    {
        public SummaryView(Dictionary<Guid, Question> questions)
        {
            InitializeComponent();

            int correctQuestionsCount = countCorrectQuestions(questions);
            float percentage = ((float)correctQuestionsCount / questions.Count)*100;

            QuestionCountLabel.Text = "Correct answers: " + correctQuestionsCount.ToString() + "/" + questions.Count;
            PercentageLabel.Text = "Percentage: " + percentage.ToString() + "%";
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            var homeView = new HomeView();
            homeView.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(homeView);
        }

        public int countCorrectQuestions(Dictionary<Guid, Question> questions)
        {
            int counter = 0;
            foreach (Question question in questions.Values)
            {
                if(question.IsCorrect == true)
                {
                    counter++;
                }
            } 
            return counter;
        }
    }
}
