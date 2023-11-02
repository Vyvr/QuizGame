namespace QuizGame.Views
{
    partial class SummaryView
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
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.QuestionCountLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(3, 3);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(91, 23);
            this.BackToMenuButton.TabIndex = 3;
            this.BackToMenuButton.Text = "<< Main menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(278, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(244, 79);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Summary";
            // 
            // QuestionCountLabel
            // 
            this.QuestionCountLabel.AutoSize = true;
            this.QuestionCountLabel.Location = new System.Drawing.Point(313, 207);
            this.QuestionCountLabel.Name = "QuestionCountLabel";
            this.QuestionCountLabel.Size = new System.Drawing.Size(103, 13);
            this.QuestionCountLabel.TabIndex = 5;
            this.QuestionCountLabel.Text = "QuestionCountLabel";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(313, 260);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(88, 13);
            this.PercentageLabel.TabIndex = 6;
            this.PercentageLabel.Text = "PercentageLabel";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(313, 307);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(75, 13);
            this.SecondsLabel.TabIndex = 7;
            this.SecondsLabel.Text = "SecondsLabel";
            // 
            // SummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.QuestionCountLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BackToMenuButton);
            this.Name = "SummaryView";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label QuestionCountLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label SecondsLabel;
    }
}
