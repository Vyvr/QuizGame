namespace QuizGame.Views
{
    partial class GameView
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
            this.components = new System.ComponentModel.Container();
            this.PreviousQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.TimeInQuizTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Location = new System.Drawing.Point(3, 438);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousQuestionButton.TabIndex = 0;
            this.PreviousQuestionButton.Text = "< Previous";
            this.PreviousQuestionButton.UseVisualStyleBackColor = true;
            this.PreviousQuestionButton.Click += new System.EventHandler(this.PreviousQuestionButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(738, 438);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.NextQuestionButton.TabIndex = 1;
            this.NextQuestionButton.Text = "Next >";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(3, 3);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(91, 23);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.Text = "<< Main menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.Location = new System.Drawing.Point(77, 96);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(667, 320);
            this.AnswersPanel.TabIndex = 3;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(385, 40);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "label1";
            // 
            // TimeInQuizTimer
            // 
            this.TimeInQuizTimer.Tick += new System.EventHandler(this.TimeInQuizTimer_Tick);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.AnswersPanel);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.PreviousQuestionButton);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Timer TimeInQuizTimer;
    }
}
