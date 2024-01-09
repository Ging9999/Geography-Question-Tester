namespace Geography_Question_Tester.Forms
{
    partial class ViewStats
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
            this.Loggedinas = new System.Windows.Forms.Button();
            this.StudentStatsBox = new System.Windows.Forms.GroupBox();
            this.AvgHazDifficultylbl = new System.Windows.Forms.Label();
            this.AvrHotDesertsBtn = new System.Windows.Forms.Button();
            this.AvrChangingPlacesBtn = new System.Windows.Forms.Button();
            this.HazardDifficultyBtn = new System.Windows.Forms.Button();
            this.AvrDifflbl = new System.Windows.Forms.Label();
            this.FCAverage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvrWaterCardBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentStatsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 51);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loggedinas
            // 
            this.Loggedinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Loggedinas.Location = new System.Drawing.Point(686, 0);
            this.Loggedinas.Name = "Loggedinas";
            this.Loggedinas.Size = new System.Drawing.Size(113, 51);
            this.Loggedinas.TabIndex = 1;
            this.Loggedinas.UseVisualStyleBackColor = false;
            // 
            // StudentStatsBox
            // 
            this.StudentStatsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentStatsBox.Controls.Add(this.label3);
            this.StudentStatsBox.Controls.Add(this.AvrWaterCardBtn);
            this.StudentStatsBox.Controls.Add(this.label1);
            this.StudentStatsBox.Controls.Add(this.label2);
            this.StudentStatsBox.Controls.Add(this.AvgHazDifficultylbl);
            this.StudentStatsBox.Controls.Add(this.AvrHotDesertsBtn);
            this.StudentStatsBox.Controls.Add(this.AvrChangingPlacesBtn);
            this.StudentStatsBox.Controls.Add(this.HazardDifficultyBtn);
            this.StudentStatsBox.Controls.Add(this.AvrDifflbl);
            this.StudentStatsBox.Controls.Add(this.FCAverage);
            this.StudentStatsBox.Location = new System.Drawing.Point(47, 70);
            this.StudentStatsBox.Name = "StudentStatsBox";
            this.StudentStatsBox.Size = new System.Drawing.Size(320, 325);
            this.StudentStatsBox.TabIndex = 2;
            this.StudentStatsBox.TabStop = false;
            // 
            // AvgHazDifficultylbl
            // 
            this.AvgHazDifficultylbl.AutoSize = true;
            this.AvgHazDifficultylbl.Location = new System.Drawing.Point(6, 109);
            this.AvgHazDifficultylbl.Name = "AvgHazDifficultylbl";
            this.AvgHazDifficultylbl.Size = new System.Drawing.Size(127, 13);
            this.AvgHazDifficultylbl.TabIndex = 5;
            this.AvgHazDifficultylbl.Text = "Average Hazard Difficulty";
            // 
            // AvrHotDesertsBtn
            // 
            this.AvrHotDesertsBtn.Enabled = false;
            this.AvrHotDesertsBtn.Location = new System.Drawing.Point(214, 207);
            this.AvrHotDesertsBtn.Name = "AvrHotDesertsBtn";
            this.AvrHotDesertsBtn.Size = new System.Drawing.Size(83, 33);
            this.AvrHotDesertsBtn.TabIndex = 4;
            this.AvrHotDesertsBtn.UseVisualStyleBackColor = true;
            // 
            // AvrChangingPlacesBtn
            // 
            this.AvrChangingPlacesBtn.Enabled = false;
            this.AvrChangingPlacesBtn.Location = new System.Drawing.Point(214, 154);
            this.AvrChangingPlacesBtn.Name = "AvrChangingPlacesBtn";
            this.AvrChangingPlacesBtn.Size = new System.Drawing.Size(83, 33);
            this.AvrChangingPlacesBtn.TabIndex = 3;
            this.AvrChangingPlacesBtn.UseVisualStyleBackColor = true;
            // 
            // HazardDifficultyBtn
            // 
            this.HazardDifficultyBtn.Enabled = false;
            this.HazardDifficultyBtn.Location = new System.Drawing.Point(214, 99);
            this.HazardDifficultyBtn.Name = "HazardDifficultyBtn";
            this.HazardDifficultyBtn.Size = new System.Drawing.Size(83, 33);
            this.HazardDifficultyBtn.TabIndex = 2;
            this.HazardDifficultyBtn.UseVisualStyleBackColor = true;
            // 
            // AvrDifflbl
            // 
            this.AvrDifflbl.AutoSize = true;
            this.AvrDifflbl.Location = new System.Drawing.Point(6, 53);
            this.AvrDifflbl.Name = "AvrDifflbl";
            this.AvrDifflbl.Size = new System.Drawing.Size(90, 13);
            this.AvrDifflbl.TabIndex = 1;
            this.AvrDifflbl.Text = "Average Difficulty";
            // 
            // FCAverage
            // 
            this.FCAverage.Enabled = false;
            this.FCAverage.Location = new System.Drawing.Point(214, 43);
            this.FCAverage.Name = "FCAverage";
            this.FCAverage.Size = new System.Drawing.Size(83, 33);
            this.FCAverage.TabIndex = 0;
            this.FCAverage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average Changing Places Difficulty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average Hot Deserts Difficulty";
            // 
            // AvrWaterCardBtn
            // 
            this.AvrWaterCardBtn.Enabled = false;
            this.AvrWaterCardBtn.Location = new System.Drawing.Point(214, 264);
            this.AvrWaterCardBtn.Name = "AvrWaterCardBtn";
            this.AvrWaterCardBtn.Size = new System.Drawing.Size(83, 33);
            this.AvrWaterCardBtn.TabIndex = 8;
            this.AvrWaterCardBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Average Water and Carbon Difficulty";
            // 
            // ViewStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentStatsBox);
            this.Controls.Add(this.Loggedinas);
            this.Controls.Add(this.BackBtn);
            this.Name = "ViewStats";
            this.Text = "Form1";
            this.StudentStatsBox.ResumeLayout(false);
            this.StudentStatsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button Loggedinas;
        private System.Windows.Forms.GroupBox StudentStatsBox;
        private System.Windows.Forms.Button FCAverage;
        private System.Windows.Forms.Label AvrDifflbl;
        private System.Windows.Forms.Button AvrHotDesertsBtn;
        private System.Windows.Forms.Button AvrChangingPlacesBtn;
        private System.Windows.Forms.Button HazardDifficultyBtn;
        private System.Windows.Forms.Label AvgHazDifficultylbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AvrWaterCardBtn;
        private System.Windows.Forms.Label label1;
    }
}