namespace PredictorPerceptronSimplu
{
    partial class Form1
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.loadedFile = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.TotalBrenches = new System.Windows.Forms.Label();
            this.TakenBrenches = new System.Windows.Forms.Label();
            this.TakenPredictedBrenches = new System.Windows.Forms.Label();
            this.NotTakenBrenches = new System.Windows.Forms.Label();
            this.NotTakenPredictedBrenches = new System.Windows.Forms.Label();
            this.NumberOfPerceptrons = new System.Windows.Forms.TextBox();
            this.NumberOfBits = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(22, 488);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(110, 28);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(374, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(104, 550);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // loadedFile
            // 
            this.loadedFile.AutoSize = true;
            this.loadedFile.Location = new System.Drawing.Point(46, 458);
            this.loadedFile.Name = "loadedFile";
            this.loadedFile.Size = new System.Drawing.Size(69, 16);
            this.loadedFile.TabIndex = 2;
            this.loadedFile.Text = "Load a file";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(230, 488);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(110, 28);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TotalBrenches
            // 
            this.TotalBrenches.AutoSize = true;
            this.TotalBrenches.Location = new System.Drawing.Point(12, 122);
            this.TotalBrenches.Name = "TotalBrenches";
            this.TotalBrenches.Size = new System.Drawing.Size(95, 16);
            this.TotalBrenches.TabIndex = 4;
            this.TotalBrenches.Text = "TotalBrenches";
            // 
            // TakenBrenches
            // 
            this.TakenBrenches.AutoSize = true;
            this.TakenBrenches.Location = new System.Drawing.Point(12, 66);
            this.TakenBrenches.Name = "TakenBrenches";
            this.TakenBrenches.Size = new System.Drawing.Size(103, 16);
            this.TakenBrenches.TabIndex = 5;
            this.TakenBrenches.Text = "TakenBrenches";
            this.TakenBrenches.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TakenPredictedBrenches
            // 
            this.TakenPredictedBrenches.AutoSize = true;
            this.TakenPredictedBrenches.Location = new System.Drawing.Point(179, 66);
            this.TakenPredictedBrenches.Name = "TakenPredictedBrenches";
            this.TakenPredictedBrenches.Size = new System.Drawing.Size(161, 16);
            this.TakenPredictedBrenches.TabIndex = 6;
            this.TakenPredictedBrenches.Text = "TakenPredictedBrenches";
            // 
            // NotTakenBrenches
            // 
            this.NotTakenBrenches.AutoSize = true;
            this.NotTakenBrenches.Location = new System.Drawing.Point(8, 15);
            this.NotTakenBrenches.Name = "NotTakenBrenches";
            this.NotTakenBrenches.Size = new System.Drawing.Size(124, 16);
            this.NotTakenBrenches.TabIndex = 7;
            this.NotTakenBrenches.Text = "NotTakenBrenches";
            // 
            // NotTakenPredictedBrenches
            // 
            this.NotTakenPredictedBrenches.AutoSize = true;
            this.NotTakenPredictedBrenches.Location = new System.Drawing.Point(158, 15);
            this.NotTakenPredictedBrenches.Name = "NotTakenPredictedBrenches";
            this.NotTakenPredictedBrenches.Size = new System.Drawing.Size(182, 16);
            this.NotTakenPredictedBrenches.TabIndex = 8;
            this.NotTakenPredictedBrenches.Text = "NotTakenPredictedBrenches";
            // 
            // NumberOfPerceptrons
            // 
            this.NumberOfPerceptrons.Location = new System.Drawing.Point(240, 452);
            this.NumberOfPerceptrons.Name = "NumberOfPerceptrons";
            this.NumberOfPerceptrons.Size = new System.Drawing.Size(100, 22);
            this.NumberOfPerceptrons.TabIndex = 9;
            // 
            // NumberOfBits
            // 
            this.NumberOfBits.Location = new System.Drawing.Point(240, 424);
            this.NumberOfBits.Name = "NumberOfBits";
            this.NumberOfBits.Size = new System.Drawing.Size(100, 22);
            this.NumberOfBits.TabIndex = 10;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(272, 391);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 584);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.NumberOfBits);
            this.Controls.Add(this.NumberOfPerceptrons);
            this.Controls.Add(this.NotTakenPredictedBrenches);
            this.Controls.Add(this.NotTakenBrenches);
            this.Controls.Add(this.TakenPredictedBrenches);
            this.Controls.Add(this.TakenBrenches);
            this.Controls.Add(this.TotalBrenches);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.loadedFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label loadedFile;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label TotalBrenches;
        private System.Windows.Forms.Label TakenBrenches;
        private System.Windows.Forms.Label TakenPredictedBrenches;
        private System.Windows.Forms.Label NotTakenBrenches;
        private System.Windows.Forms.Label NotTakenPredictedBrenches;
        private System.Windows.Forms.TextBox NumberOfPerceptrons;
        private System.Windows.Forms.TextBox NumberOfBits;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

