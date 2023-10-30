namespace QuizGame.Views
{
    partial class AddNewQuestionsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.QuestionContentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnswersGroupBox = new System.Windows.Forms.GroupBox();
            this.AddNewQuestionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.AnswersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // QuestionContentTextBox
            // 
            this.QuestionContentTextBox.AcceptsReturn = true;
            this.QuestionContentTextBox.Location = new System.Drawing.Point(0, 19);
            this.QuestionContentTextBox.Multiline = true;
            this.QuestionContentTextBox.Name = "QuestionContentTextBox";
            this.QuestionContentTextBox.Size = new System.Drawing.Size(242, 329);
            this.QuestionContentTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuestionContentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(59, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The content of the question";
            // 
            // AnswersGroupBox
            // 
            this.AnswersGroupBox.Controls.Add(this.AddNewQuestionButton);
            this.AnswersGroupBox.Location = new System.Drawing.Point(515, 52);
            this.AnswersGroupBox.Name = "AnswersGroupBox";
            this.AnswersGroupBox.Size = new System.Drawing.Size(242, 348);
            this.AnswersGroupBox.TabIndex = 3;
            this.AnswersGroupBox.TabStop = false;
            this.AnswersGroupBox.Text = "Answers (max 12)";
            // 
            // AddNewQuestionButton
            // 
            this.AddNewQuestionButton.Location = new System.Drawing.Point(0, 19);
            this.AddNewQuestionButton.Name = "AddNewQuestionButton";
            this.AddNewQuestionButton.Size = new System.Drawing.Size(242, 23);
            this.AddNewQuestionButton.TabIndex = 0;
            this.AddNewQuestionButton.Text = "+";
            this.AddNewQuestionButton.UseVisualStyleBackColor = true;
            this.AddNewQuestionButton.Click += new System.EventHandler(this.AddNewQuestionButton_Click);
            // 
            // AddNewQuestionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnswersGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "AddNewQuestionsView";
            this.Size = new System.Drawing.Size(816, 489);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AnswersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox QuestionContentTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AnswersGroupBox;
        private System.Windows.Forms.Button AddNewQuestionButton;
    }
}
