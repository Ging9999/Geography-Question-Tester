namespace Geography_Question_Tester
{
    partial class ReviseTopics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackBtn = new System.Windows.Forms.Button();
            this.LoggedIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HardDifficultyBtn = new System.Windows.Forms.Button();
            this.MediumDifficultyBtn = new System.Windows.Forms.Button();
            this.EasyDifficultyBtn = new System.Windows.Forms.Button();
            this.GetFlashcardsBtn = new System.Windows.Forms.Button();
            this.LearnDefinitionBtn = new System.Windows.Forms.Button();
            this.KeywordBtn = new System.Windows.Forms.Button();
            this.SelectTopicLbl = new System.Windows.Forms.Label();
            this.SelectTopicBox = new System.Windows.Forms.ComboBox();
            this.FlashcardBox = new System.Windows.Forms.GroupBox();
            this.NextQuestionBtn = new System.Windows.Forms.Button();
            this.incorrectcorrectlbl = new System.Windows.Forms.Label();
            this.Guess3btn = new System.Windows.Forms.Button();
            this.Guess2btn = new System.Windows.Forms.Button();
            this.Guess1btn = new System.Windows.Forms.Button();
            this.Flashcardtermordefinition = new System.Windows.Forms.Button();
            this.finishedlbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.FlashcardBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 46);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoggedIn
            // 
            this.LoggedIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LoggedIn.Location = new System.Drawing.Point(694, 0);
            this.LoggedIn.Name = "LoggedIn";
            this.LoggedIn.Size = new System.Drawing.Size(108, 46);
            this.LoggedIn.TabIndex = 1;
            this.LoggedIn.UseVisualStyleBackColor = false;
            this.LoggedIn.Click += new System.EventHandler(this.LoggedIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.HardDifficultyBtn);
            this.groupBox1.Controls.Add(this.MediumDifficultyBtn);
            this.groupBox1.Controls.Add(this.EasyDifficultyBtn);
            this.groupBox1.Controls.Add(this.GetFlashcardsBtn);
            this.groupBox1.Controls.Add(this.LearnDefinitionBtn);
            this.groupBox1.Controls.Add(this.KeywordBtn);
            this.groupBox1.Controls.Add(this.SelectTopicLbl);
            this.groupBox1.Controls.Add(this.SelectTopicBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Topic";
            // 
            // HardDifficultyBtn
            // 
            this.HardDifficultyBtn.BackColor = System.Drawing.Color.White;
            this.HardDifficultyBtn.Location = new System.Drawing.Point(215, 219);
            this.HardDifficultyBtn.Name = "HardDifficultyBtn";
            this.HardDifficultyBtn.Size = new System.Drawing.Size(75, 23);
            this.HardDifficultyBtn.TabIndex = 7;
            this.HardDifficultyBtn.Text = "Hard";
            this.HardDifficultyBtn.UseVisualStyleBackColor = false;
            this.HardDifficultyBtn.Click += new System.EventHandler(this.HardDifficultyBtn_Click);
            // 
            // MediumDifficultyBtn
            // 
            this.MediumDifficultyBtn.BackColor = System.Drawing.Color.White;
            this.MediumDifficultyBtn.Location = new System.Drawing.Point(115, 219);
            this.MediumDifficultyBtn.Name = "MediumDifficultyBtn";
            this.MediumDifficultyBtn.Size = new System.Drawing.Size(75, 23);
            this.MediumDifficultyBtn.TabIndex = 6;
            this.MediumDifficultyBtn.Text = "Medium";
            this.MediumDifficultyBtn.UseVisualStyleBackColor = false;
            this.MediumDifficultyBtn.Click += new System.EventHandler(this.MediumDifficultyBtn_Click);
            // 
            // EasyDifficultyBtn
            // 
            this.EasyDifficultyBtn.BackColor = System.Drawing.Color.White;
            this.EasyDifficultyBtn.Location = new System.Drawing.Point(24, 219);
            this.EasyDifficultyBtn.Name = "EasyDifficultyBtn";
            this.EasyDifficultyBtn.Size = new System.Drawing.Size(75, 23);
            this.EasyDifficultyBtn.TabIndex = 5;
            this.EasyDifficultyBtn.Text = "Easy";
            this.EasyDifficultyBtn.UseVisualStyleBackColor = false;
            this.EasyDifficultyBtn.Click += new System.EventHandler(this.EasyDifficultyBtn_Click);
            // 
            // GetFlashcardsBtn
            // 
            this.GetFlashcardsBtn.BackColor = System.Drawing.Color.White;
            this.GetFlashcardsBtn.Location = new System.Drawing.Point(100, 289);
            this.GetFlashcardsBtn.Name = "GetFlashcardsBtn";
            this.GetFlashcardsBtn.Size = new System.Drawing.Size(101, 39);
            this.GetFlashcardsBtn.TabIndex = 4;
            this.GetFlashcardsBtn.Text = "Get Flashcards";
            this.GetFlashcardsBtn.UseVisualStyleBackColor = false;
            this.GetFlashcardsBtn.Click += new System.EventHandler(this.GetFlashcardsBtn_Click);
            // 
            // LearnDefinitionBtn
            // 
            this.LearnDefinitionBtn.BackColor = System.Drawing.Color.White;
            this.LearnDefinitionBtn.Location = new System.Drawing.Point(175, 141);
            this.LearnDefinitionBtn.Name = "LearnDefinitionBtn";
            this.LearnDefinitionBtn.Size = new System.Drawing.Size(89, 41);
            this.LearnDefinitionBtn.TabIndex = 3;
            this.LearnDefinitionBtn.Text = "Learn Definition";
            this.LearnDefinitionBtn.UseVisualStyleBackColor = false;
            this.LearnDefinitionBtn.Click += new System.EventHandler(this.LearnDefinitionBtn_Click);
            // 
            // KeywordBtn
            // 
            this.KeywordBtn.BackColor = System.Drawing.Color.White;
            this.KeywordBtn.Location = new System.Drawing.Point(35, 141);
            this.KeywordBtn.Name = "KeywordBtn";
            this.KeywordBtn.Size = new System.Drawing.Size(89, 41);
            this.KeywordBtn.TabIndex = 2;
            this.KeywordBtn.Text = "Learn Keyword";
            this.KeywordBtn.UseVisualStyleBackColor = false;
            this.KeywordBtn.Click += new System.EventHandler(this.KeywordBtn_Click_1);
            // 
            // SelectTopicLbl
            // 
            this.SelectTopicLbl.AutoSize = true;
            this.SelectTopicLbl.Location = new System.Drawing.Point(32, 65);
            this.SelectTopicLbl.Name = "SelectTopicLbl";
            this.SelectTopicLbl.Size = new System.Drawing.Size(67, 13);
            this.SelectTopicLbl.TabIndex = 1;
            this.SelectTopicLbl.Text = "Select Topic";
            // 
            // SelectTopicBox
            // 
            this.SelectTopicBox.FormattingEnabled = true;
            this.SelectTopicBox.Items.AddRange(new object[] {
            "Changing Places",
            "Water and Carbon",
            "Hazards",
            "Hot Deserts"});
            this.SelectTopicBox.Location = new System.Drawing.Point(127, 62);
            this.SelectTopicBox.Name = "SelectTopicBox";
            this.SelectTopicBox.Size = new System.Drawing.Size(121, 21);
            this.SelectTopicBox.TabIndex = 0;
            // 
            // FlashcardBox
            // 
            this.FlashcardBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FlashcardBox.Controls.Add(this.NextQuestionBtn);
            this.FlashcardBox.Controls.Add(this.incorrectcorrectlbl);
            this.FlashcardBox.Controls.Add(this.Guess3btn);
            this.FlashcardBox.Controls.Add(this.Guess2btn);
            this.FlashcardBox.Controls.Add(this.Guess1btn);
            this.FlashcardBox.Controls.Add(this.Flashcardtermordefinition);
            this.FlashcardBox.Location = new System.Drawing.Point(388, 64);
            this.FlashcardBox.Name = "FlashcardBox";
            this.FlashcardBox.Size = new System.Drawing.Size(377, 359);
            this.FlashcardBox.TabIndex = 3;
            this.FlashcardBox.TabStop = false;
            this.FlashcardBox.Text = "Flashcards";
            // 
            // NextQuestionBtn
            // 
            this.NextQuestionBtn.Location = new System.Drawing.Point(244, 289);
            this.NextQuestionBtn.Name = "NextQuestionBtn";
            this.NextQuestionBtn.Size = new System.Drawing.Size(97, 54);
            this.NextQuestionBtn.TabIndex = 5;
            this.NextQuestionBtn.Text = "Next Question";
            this.NextQuestionBtn.UseVisualStyleBackColor = true;
            this.NextQuestionBtn.Click += new System.EventHandler(this.NextQuestionBtn_Click);
            // 
            // incorrectcorrectlbl
            // 
            this.incorrectcorrectlbl.AutoSize = true;
            this.incorrectcorrectlbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.incorrectcorrectlbl.Location = new System.Drawing.Point(154, 289);
            this.incorrectcorrectlbl.Name = "incorrectcorrectlbl";
            this.incorrectcorrectlbl.Size = new System.Drawing.Size(0, 13);
            this.incorrectcorrectlbl.TabIndex = 4;
            // 
            // Guess3btn
            // 
            this.Guess3btn.BackColor = System.Drawing.Color.White;
            this.Guess3btn.Location = new System.Drawing.Point(24, 235);
            this.Guess3btn.Name = "Guess3btn";
            this.Guess3btn.Size = new System.Drawing.Size(317, 23);
            this.Guess3btn.TabIndex = 3;
            this.Guess3btn.UseVisualStyleBackColor = false;
            this.Guess3btn.Click += new System.EventHandler(this.Guess3btn_Click);
            // 
            // Guess2btn
            // 
            this.Guess2btn.BackColor = System.Drawing.Color.White;
            this.Guess2btn.Location = new System.Drawing.Point(24, 206);
            this.Guess2btn.Name = "Guess2btn";
            this.Guess2btn.Size = new System.Drawing.Size(317, 23);
            this.Guess2btn.TabIndex = 2;
            this.Guess2btn.UseVisualStyleBackColor = false;
            this.Guess2btn.Click += new System.EventHandler(this.Guess2btn_Click);
            // 
            // Guess1btn
            // 
            this.Guess1btn.BackColor = System.Drawing.Color.White;
            this.Guess1btn.Location = new System.Drawing.Point(24, 177);
            this.Guess1btn.Name = "Guess1btn";
            this.Guess1btn.Size = new System.Drawing.Size(317, 23);
            this.Guess1btn.TabIndex = 1;
            this.Guess1btn.UseVisualStyleBackColor = false;
            this.Guess1btn.Click += new System.EventHandler(this.Guess1btn_Click);
            // 
            // Flashcardtermordefinition
            // 
            this.Flashcardtermordefinition.BackColor = System.Drawing.Color.White;
            this.Flashcardtermordefinition.Location = new System.Drawing.Point(47, 42);
            this.Flashcardtermordefinition.Name = "Flashcardtermordefinition";
            this.Flashcardtermordefinition.Size = new System.Drawing.Size(274, 129);
            this.Flashcardtermordefinition.TabIndex = 0;
            this.Flashcardtermordefinition.UseVisualStyleBackColor = false;
            // 
            // finishedlbl
            // 
            this.finishedlbl.Location = new System.Drawing.Point(309, 17);
            this.finishedlbl.Name = "finishedlbl";
            this.finishedlbl.Size = new System.Drawing.Size(92, 44);
            this.finishedlbl.TabIndex = 4;
            // 
            // ReviseTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.finishedlbl);
            this.Controls.Add(this.FlashcardBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoggedIn);
            this.Controls.Add(this.BackBtn);
            this.Name = "ReviseTopics";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FlashcardBox.ResumeLayout(false);
            this.FlashcardBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LoggedIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectTopicLbl;
        private System.Windows.Forms.ComboBox SelectTopicBox;
        private System.Windows.Forms.Button KeywordBtn;
        private System.Windows.Forms.Button LearnDefinitionBtn;
        private System.Windows.Forms.Button GetFlashcardsBtn;
        private System.Windows.Forms.Button HardDifficultyBtn;
        private System.Windows.Forms.Button MediumDifficultyBtn;
        private System.Windows.Forms.Button EasyDifficultyBtn;
        private System.Windows.Forms.GroupBox FlashcardBox;
        private System.Windows.Forms.Button Guess2btn;
        private System.Windows.Forms.Button Guess1btn;
        private System.Windows.Forms.Button Flashcardtermordefinition;
        private System.Windows.Forms.Button Guess3btn;
        private System.Windows.Forms.Label incorrectcorrectlbl;
        private System.Windows.Forms.Button NextQuestionBtn;
        private System.Windows.Forms.Label finishedlbl;
    }
}