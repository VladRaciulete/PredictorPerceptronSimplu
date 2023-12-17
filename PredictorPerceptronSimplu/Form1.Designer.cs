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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.labelBits = new System.Windows.Forms.Label();
            this.labelPerceprton = new System.Windows.Forms.Label();
            this.Traces = new System.Windows.Forms.ListBox();
            this.SellectAll = new System.Windows.Forms.Button();
            this.UnsellectAll = new System.Windows.Forms.Button();
            this.NumberOfBits = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPerceptrons = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPerceptrons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1153, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightGray;
            this.Start.Location = new System.Drawing.Point(131, 533);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 32);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(109, 420);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(29, 16);
            this.labelBits.TabIndex = 12;
            this.labelBits.Text = "Bits";
            // 
            // labelPerceprton
            // 
            this.labelPerceprton.AutoSize = true;
            this.labelPerceprton.Location = new System.Drawing.Point(58, 451);
            this.labelPerceprton.Name = "labelPerceprton";
            this.labelPerceprton.Size = new System.Drawing.Size(80, 16);
            this.labelPerceprton.TabIndex = 13;
            this.labelPerceprton.Text = "Perceptrons";
            // 
            // Traces
            // 
            this.Traces.FormattingEnabled = true;
            this.Traces.ItemHeight = 16;
            this.Traces.Location = new System.Drawing.Point(55, 99);
            this.Traces.Name = "Traces";
            this.Traces.Size = new System.Drawing.Size(303, 148);
            this.Traces.TabIndex = 26;
            // 
            // SellectAll
            // 
            this.SellectAll.Location = new System.Drawing.Point(105, 253);
            this.SellectAll.Name = "SellectAll";
            this.SellectAll.Size = new System.Drawing.Size(94, 24);
            this.SellectAll.TabIndex = 27;
            this.SellectAll.Text = "SellectAll";
            this.SellectAll.UseVisualStyleBackColor = true;
            this.SellectAll.Click += new System.EventHandler(this.SellectAll_Click);
            // 
            // UnsellectAll
            // 
            this.UnsellectAll.Location = new System.Drawing.Point(214, 253);
            this.UnsellectAll.Name = "UnsellectAll";
            this.UnsellectAll.Size = new System.Drawing.Size(94, 24);
            this.UnsellectAll.TabIndex = 28;
            this.UnsellectAll.Text = "UnsellectAll";
            this.UnsellectAll.UseVisualStyleBackColor = true;
            this.UnsellectAll.Click += new System.EventHandler(this.UnsellectAll_Click);
            // 
            // NumberOfBits
            // 
            this.NumberOfBits.Location = new System.Drawing.Point(147, 418);
            this.NumberOfBits.Name = "NumberOfBits";
            this.NumberOfBits.Size = new System.Drawing.Size(120, 22);
            this.NumberOfBits.TabIndex = 30;
            // 
            // NumberOfPerceptrons
            // 
            this.NumberOfPerceptrons.Location = new System.Drawing.Point(147, 451);
            this.NumberOfPerceptrons.Name = "NumberOfPerceptrons";
            this.NumberOfPerceptrons.Size = new System.Drawing.Size(120, 22);
            this.NumberOfPerceptrons.TabIndex = 31;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            this.splitContainer1.Size = new System.Drawing.Size(1412, 646);
            this.splitContainer1.SplitterDistance = 638;
            this.splitContainer1.TabIndex = 32;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(147, 56);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 24);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add New Trace";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 707);
            this.Controls.Add(this.Traces);
            this.Controls.Add(this.UnsellectAll);
            this.Controls.Add(this.SellectAll);
            this.Controls.Add(this.labelBits);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.NumberOfPerceptrons);
            this.Controls.Add(this.NumberOfBits);
            this.Controls.Add(this.labelPerceprton);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Brench Predictor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPerceptrons)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label labelBits;
        private System.Windows.Forms.Label labelPerceprton;
        private System.Windows.Forms.ListBox Traces;
        private System.Windows.Forms.Button SellectAll;
        private System.Windows.Forms.Button UnsellectAll;
        private System.Windows.Forms.NumericUpDown NumberOfBits;
        private System.Windows.Forms.NumericUpDown NumberOfPerceptrons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Add;
    }
}

