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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.labelBits = new System.Windows.Forms.Label();
            this.labelPerceprton = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Accuracy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.LightGray;
            this.LoadButton.Location = new System.Drawing.Point(37, 583);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(120, 32);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(1236, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // loadedFile
            // 
            this.loadedFile.AutoSize = true;
            this.loadedFile.Location = new System.Drawing.Point(61, 549);
            this.loadedFile.Name = "loadedFile";
            this.loadedFile.Size = new System.Drawing.Size(69, 16);
            this.loadedFile.TabIndex = 2;
            this.loadedFile.Text = "Load a file";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightGray;
            this.Start.Location = new System.Drawing.Point(448, 549);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 32);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TotalBrenches
            // 
            this.TotalBrenches.AutoSize = true;
            this.TotalBrenches.Location = new System.Drawing.Point(12, 74);
            this.TotalBrenches.Name = "TotalBrenches";
            this.TotalBrenches.Size = new System.Drawing.Size(95, 16);
            this.TotalBrenches.TabIndex = 4;
            this.TotalBrenches.Text = "TotalBrenches";
            // 
            // TakenBrenches
            // 
            this.TakenBrenches.AutoSize = true;
            this.TakenBrenches.Location = new System.Drawing.Point(12, 118);
            this.TakenBrenches.Name = "TakenBrenches";
            this.TakenBrenches.Size = new System.Drawing.Size(103, 16);
            this.TakenBrenches.TabIndex = 5;
            this.TakenBrenches.Text = "TakenBrenches";
            this.TakenBrenches.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TakenPredictedBrenches
            // 
            this.TakenPredictedBrenches.AutoSize = true;
            this.TakenPredictedBrenches.Location = new System.Drawing.Point(12, 328);
            this.TakenPredictedBrenches.Name = "TakenPredictedBrenches";
            this.TakenPredictedBrenches.Size = new System.Drawing.Size(161, 16);
            this.TakenPredictedBrenches.TabIndex = 6;
            this.TakenPredictedBrenches.Text = "TakenPredictedBrenches";
            // 
            // NotTakenBrenches
            // 
            this.NotTakenBrenches.AutoSize = true;
            this.NotTakenBrenches.Location = new System.Drawing.Point(12, 162);
            this.NotTakenBrenches.Name = "NotTakenBrenches";
            this.NotTakenBrenches.Size = new System.Drawing.Size(124, 16);
            this.NotTakenBrenches.TabIndex = 7;
            this.NotTakenBrenches.Text = "NotTakenBrenches";
            // 
            // NotTakenPredictedBrenches
            // 
            this.NotTakenPredictedBrenches.AutoSize = true;
            this.NotTakenPredictedBrenches.Location = new System.Drawing.Point(12, 372);
            this.NotTakenPredictedBrenches.Name = "NotTakenPredictedBrenches";
            this.NotTakenPredictedBrenches.Size = new System.Drawing.Size(182, 16);
            this.NotTakenPredictedBrenches.TabIndex = 8;
            this.NotTakenPredictedBrenches.Text = "NotTakenPredictedBrenches";
            // 
            // NumberOfPerceptrons
            // 
            this.NumberOfPerceptrons.BackColor = System.Drawing.Color.White;
            this.NumberOfPerceptrons.Location = new System.Drawing.Point(376, 569);
            this.NumberOfPerceptrons.Name = "NumberOfPerceptrons";
            this.NumberOfPerceptrons.Size = new System.Drawing.Size(61, 22);
            this.NumberOfPerceptrons.TabIndex = 9;
            // 
            // NumberOfBits
            // 
            this.NumberOfBits.BackColor = System.Drawing.Color.White;
            this.NumberOfBits.Location = new System.Drawing.Point(376, 538);
            this.NumberOfBits.Name = "NumberOfBits";
            this.NumberOfBits.Size = new System.Drawing.Size(61, 22);
            this.NumberOfBits.TabIndex = 10;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(120, 624);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 11;
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(341, 541);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(29, 16);
            this.labelBits.TabIndex = 12;
            this.labelBits.Text = "Bits";
            // 
            // labelPerceprton
            // 
            this.labelPerceprton.AutoSize = true;
            this.labelPerceprton.Location = new System.Drawing.Point(290, 572);
            this.labelPerceprton.Name = "labelPerceprton";
            this.labelPerceprton.Size = new System.Drawing.Size(80, 16);
            this.labelPerceprton.TabIndex = 13;
            this.labelPerceprton.Text = "Perceptrons";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(293, 27);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(366, 193);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 20);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1423, 20);
            this.panel2.TabIndex = 21;
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(293, 258);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(366, 193);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // Accuracy
            // 
            this.Accuracy.AutoSize = true;
            this.Accuracy.Location = new System.Drawing.Point(12, 455);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(63, 16);
            this.Accuracy.TabIndex = 23;
            this.Accuracy.Text = "Accuracy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1425, 665);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelPerceprton);
            this.Controls.Add(this.labelBits);
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
            this.Text = "Brench Predictor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.Label labelBits;
        private System.Windows.Forms.Label labelPerceprton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label Accuracy;
    }
}

