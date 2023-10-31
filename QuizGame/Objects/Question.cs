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
        public Guid Id;
        public string Content;
        public List<string> Answers;
        public int NumberOfCorrectAnswers;
        public bool IsCorrect;
        #endregion

        #region ctors
        public Question()
        {
            this.generateId();
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
