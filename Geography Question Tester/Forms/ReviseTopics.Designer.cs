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
            this.SelectTopicBox = new System.Windows.Forms.ComboBox();
            this.SelectTopicLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.SelectTopicLbl);
            this.groupBox1.Controls.Add(this.SelectTopicBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Topic";
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
            // SelectTopicLbl
            // 
            this.SelectTopicLbl.AutoSize = true;
            this.SelectTopicLbl.Location = new System.Drawing.Point(32, 65);
            this.SelectTopicLbl.Name = "SelectTopicLbl";
            this.SelectTopicLbl.Size = new System.Drawing.Size(67, 13);
            this.SelectTopicLbl.TabIndex = 1;
            this.SelectTopicLbl.Text = "Select Topic";
            // 
            // ReviseTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoggedIn);
            this.Controls.Add(this.BackBtn);
            this.Name = "ReviseTopics";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LoggedIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectTopicLbl;
        private System.Windows.Forms.ComboBox SelectTopicBox;
    }
}