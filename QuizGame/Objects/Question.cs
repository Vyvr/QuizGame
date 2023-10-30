using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class Question
    {
        #region Public Fields
        Guid Id;
        string Content;
        List<string> Answers;
        int NumberOfCorrectAnswers;
        bool IsCorrect;
        #endregion

        #region ctors
        public Question(string _content, List<string> _answers, int _numberOfCorrectAnswers)
        {
            this.generateId();
            this.Content = _content;
            this.Answers = _answers;
            this.NumberOfCorrectAnswers = _numberOfCorrectAnswers;
            IsCorrect = false;
        }
        #endregion

        #region Public Methods
        public void setAsCorrect()
        {
            this.IsCorrect = true;
        }
        #endregion

        #region Private Methods
        private void generateId()
        {
            this.Id = Guid.NewGuid();
        }
        #endregion
    }
}
