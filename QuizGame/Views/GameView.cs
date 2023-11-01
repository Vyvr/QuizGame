using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.Views
{
    public partial class GameView : UserControl
    {
        #region Private Fields
        private Dictionary<Guid, Question> Questions = new Dictionary<Guid, Question>();
        private List<Guid> QuestionIds = new List<Guid>();
        private int CurrentQuestionIndex = 0;
        private Question CurrentQuestion;
        private List<Control> DynamicControls = new List<Control>();

        private enum QuestionType
        {
            Multi,
            Single,
        }
        #endregion

        #region ctors
        public GameView()
        {
            InitializeComponent();

            loadQuestions();
            DisplayQuestion();
        }
        #endregion

        #region Private Methods
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            var homeView = new HomeView();
            homeView.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(homeView);
        }

        private void loadQuestions()
        {
            string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Assets";

            var filePath = Path.Combine(workingDirectory, "answers.txt");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var questionList = JsonSerializer.Deserialize<List<Question>>(json);

                if (questionList != null)
                {
                    foreach (var question in questionList)
                    {
                        Questions.Add(question.Id, question);
                        QuestionIds.Add(question.Id);
                    }
                }
            }

            if(Questions.Count == 0)
            {
                string message = "No questions provided";
                string caption = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, caption, buttons, icon);

                var homeView = new HomeView();
                homeView.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(homeView);

                return;

            }
        }

        private void DisplayQuestion()
        {
            if (Questions.Count == 0) return;

            var currentQuestionId = QuestionIds[CurrentQuestionIndex];
            CurrentQuestion = Questions[currentQuestionId];

            ClearDynamicControls();
            GenerateQuestionUI(CurrentQuestion);
        }

        private void ClearDynamicControls()
        {
            foreach (var control in DynamicControls)
            {
                AnswersPanel.Controls.Remove(control);
                control.Dispose();
            }
            DynamicControls.Clear();
        }

        private void GenerateQuestionUI(Question question)
        {
            this.QuestionLabel.Text = question.Content;

            if(question.NumberOfCorrectAnswers > 1)
            {
                GenerateAnswers(QuestionType.Multi, question);
            }
            else
            {
                GenerateAnswers(QuestionType.Single, question);
            }
        }

        private void GenerateAnswers(QuestionType type, Question question)
        {
            int yOffset = 0;

            if (type == QuestionType.Single)
            {
                foreach (var answer in question.Questions)
                {
                    var answerField = new RadioButton
                    {
                        Text = answer.Key,
                        AutoSize = true,
                        Location = new Point(0, 0)
                    };
                    AnswersPanel.Controls.Add(answerField);
                    answerField.Location = new Point(0, yOffset);
                    DynamicControls.Add(answerField);
                    yOffset += 30;
                }
            }
            else
            {
                foreach (var answer in question.Questions)
                {
                    var answerField = new CheckBox
                    {
                        Text = answer.Key,
                        AutoSize = true,
                        Location = new Point(0, 0)
                    };
                    AnswersPanel.Controls.Add(answerField);
                    answerField.Location = new Point(0, yOffset);
                    DynamicControls.Add(answerField);
                    yOffset += 30;
                }
            }
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            bool isAnswearsCorrect = true;
            foreach(var question in CurrentQuestion.Questions)
            {
                foreach(var answear in DynamicControls)
                {
                    if (answear is RadioButton radioButton)
                    {
                        if (radioButton.Text == question.Key && question.Value != radioButton.Checked)
                        {
                            isAnswearsCorrect = false;
                        }
                    }
                    else if (answear is CheckBox checkBox)
                    {
                        if (checkBox.Text == question.Key && question.Value != checkBox.Checked)
                        {
                            isAnswearsCorrect = false;
                        }
                    }
                }
            }

            CurrentQuestion.IsCorrect = isAnswearsCorrect;

            if (CurrentQuestionIndex < QuestionIds.Count - 1)
            {
                CurrentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                var summaryView = new SummaryView(Questions);
                summaryView.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(summaryView);
            }
        }
        
        private void PreviousQuestionButton_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex > 0)
            {
                CurrentQuestionIndex--;
                DisplayQuestion();
            }
        }

        #endregion
    }
}
