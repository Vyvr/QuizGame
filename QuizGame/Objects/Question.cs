using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Globalization;

namespace QuizGame
{
    public class Question
    {
        #region Public Fields
        public Guid Id { get; private set; }
        public string Content { get; set; }
        public Dictionary<string, bool> Questions { get; set; }
        public int NumberOfCorrectAnswers { get; set; }
        public bool IsCorrect { get; set; }
        #endregion

        #region ctors
        public Question()
        {
            this.generateId();
            IsCorrect = false;
            Questions = new Dictionary<string, bool>();
        }
        #endregion

        #region Public Methods
        public void setAsCorrect()
        {
            this.IsCorrect = true;
        }
        public void saveToFile()
        {
            string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Assets";

            var filePath = Path.Combine(workingDirectory, "answers.txt");

            List<Question> existingQuestions = new List<Question>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                existingQuestions = JsonSerializer.Deserialize<List<Question>>(existingJson) ?? new List<Question>();
            }

            existingQuestions.Add(this);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(existingQuestions, options);
            File.WriteAllText(filePath, json);
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
