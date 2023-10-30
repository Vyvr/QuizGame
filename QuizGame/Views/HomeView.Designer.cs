namespace QuizGame.Views
{
    partial class HomeView
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
            this.AddNewQuestionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewQuestionsButton
            // 
            this.AddNewQuestionsButton.Location = new System.Drawing.Point(262, 119);
            this.AddNewQuestionsButton.Name = "AddNewQuestionsButton";
            this.AddNewQuestionsButton.Size = new System.Drawing.Size(286, 220);
            this.AddNewQuestionsButton.TabIndex = 0;
            this.AddNewQuestionsButton.Text = "AddNewQuestions";
            this.AddNewQuestionsButton.UseVisualStyleBackColor = true;
            this.AddNewQuestionsButton.Click += new System.EventHandler(this.AddNewQuestionsButton_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddNewQuestionsButton);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuestionsButton;
    }
}
