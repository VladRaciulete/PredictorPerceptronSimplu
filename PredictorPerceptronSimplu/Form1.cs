using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PredictorPerceptronSimplu
{
    public partial class Form1 : Form
    {
        int windowWidth;
        int windowHeight;

        int TotalBrenches1 = 0, TakenBrenches1 = 0, NotTakenBrenches1 = 0, TakenPredictedBrenches1 = 0, NotTakenPredictedBrenches1 = 0;

        Series series = new Series("MySeries");
        Series series2 = new Series("MySeries");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            windowWidth = ClientRectangle.Width;
            windowHeight = ClientRectangle.Height;

            int windowWidth2 = (int)Math.Round(0.20 * windowWidth);

            richTextBox1.Location = new Point(windowWidth - windowWidth2, 20);

            richTextBox1.Size = new Size(windowWidth2, windowHeight - 40);

            NumberOfBits.Text = "6";
            NumberOfPerceptrons.Text = "10";

            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(windowWidth, 20);

            panel2.Location = new Point(0, windowHeight-20);
            panel2.Size = new Size(windowWidth, 20);

            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = false;

            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = false;

            //series.Points.Add(new DataPoint(1, 5) { AxisLabel = "TotalBrenches" });
            //series.Points.Add(new DataPoint(2, 10) { AxisLabel = "TakenBrenches" });
            //series.Points.Add(new DataPoint(3, 8) { AxisLabel = "NotTakenBrenches" });
            //series.Points.Add(new DataPoint(4, 12) { AxisLabel = "TakenPredictedBrenches" });
            //series.Points.Add(new DataPoint(5, 12) { AxisLabel = "NotTakenPredictedBrenches" });
            //chart1.Series.Add(series);

            //chart1.Titles.Add("My Chart Title");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Trace files (*.tra)|*.tra";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] fileName = filePath.Split('\\');
                    loadedFile.Text = fileName[fileName.Length - 1];
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            TotalBrenches1 = 0;
            TakenBrenches1 = 0;
            NotTakenBrenches1 = 0;
            TakenPredictedBrenches1 = 0;
            NotTakenPredictedBrenches1 = 0;

            if (NumberOfBits.Text.ToString() != "" && NumberOfPerceptrons.Text.ToString() != "")
            {
                int InputNumberOfBits = int.Parse(NumberOfBits.Text.ToString());
                int InputNumberOfPerceptrons = int.Parse(NumberOfPerceptrons.Text.ToString());

                int[] HR = new int[InputNumberOfBits];
                Cell[,] P = new Cell[InputNumberOfPerceptrons, InputNumberOfBits];
                Cell[] Perceptron = new Cell[InputNumberOfBits];

                for (int i = 0; i < InputNumberOfBits; i++)
                {
                    HR[i] = -1;
                }

                for (int i = 0; i < InputNumberOfPerceptrons; i++)
                {
                    for (int j = 0; j < InputNumberOfBits; j++)
                    {
                        P[i, j] = new Cell(1,-1);
                    }
                }

                string text = richTextBox1.Text;
                string[] lines = text.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                int PC, index, suma;
                bool predictedtrue, readtrue;
                int GoodPrediction = 0, BadPrediction = 0;


                ErrorLabel.Text = text;

                foreach (string line in lines)
                {
                    TotalBrenches1 += 1;
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {

                        if (word[0] == 'B' || word[0] == 'N')
                        {
                            predictedtrue = false;
                            readtrue = false;

                            PC = int.Parse(words[1]);

                            index = PC % InputNumberOfPerceptrons;
                            suma = 0;

                            if (HR[0] == 1) {
                                for (int i = 0; i < InputNumberOfBits; i++)
                                    suma += P[index, i].Taken * HR[i];
                            }
                            else if (HR[0] == -1)
                            {
                                for (int i = 0; i < InputNumberOfBits; i++)
                                    suma += P[index, i].NotTaken * HR[i];
                            }

                            // Fac prezicerea
                            if (suma >= 0)
                            {
                                //prezic ca saltul se face
                                TakenPredictedBrenches1 += 1;
                                predictedtrue = true;
                            }
                            else if (suma < 0)
                            {
                                //prezic ca saltul NU se face
                                NotTakenPredictedBrenches1 += 1;
                                predictedtrue = false;
                            }


                            // Verific daca saltul s a facut
                            if (word[0] == 'B') // Saltul s-a facut
                            {
                                TakenBrenches1 += 1;
                                readtrue = true;

                                // incrementez seturile perceptronului cu 1 (nu si ponderile saltului curent)
                                for (int i = 0; i < InputNumberOfBits; i++)
                                {
                                    P[index, i].NotTaken += 1;
                                    P[index, i].Taken += 1;
                                }

                                // shiftez h cu o pozitie la dreapta si adaug 1 pe pozitia 0
                                for (int i = 1; i < InputNumberOfBits; i++)
                                {
                                    HR[i] = HR[i - 1];
                                }
                                HR[0] = 1;
                            }

                            else if (word[0] == 'N') // Saltul nu s-a facut
                            {
                                NotTakenBrenches1 += 1;
                                readtrue = false;

                                // decrementez cu 1 ponderile salturilor anterioare (nu si ponderile saltului curent)
                                for (int i = 0; i < InputNumberOfBits; i++)
                                {
                                    P[index, i].NotTaken -= 1;
                                    P[index, i].Taken -= 1;
                                }

                                // shiftez toate elem cu o pozitie si adaug -1 pe pozitia 0
                                for (int i = 1; i < InputNumberOfBits; i++)
                                {
                                    HR[i] = HR[i-1];
                                }
                                HR[0] = -1;

                            }

                            if (predictedtrue && readtrue)
                            {
                                GoodPrediction += 1;
                            }
                            else if (!predictedtrue && !readtrue)
                            {
                                GoodPrediction += 1;
                            }
                            else
                            {
                                BadPrediction += 1;
                            }
                        }
                    }
                }

                TotalBrenches.Text = "TotalBrenches = " + TotalBrenches1.ToString();
                TakenBrenches.Text = "TakenBrenches = " + TakenBrenches1.ToString();
                NotTakenBrenches.Text = "NotTakenBrenches = " + NotTakenBrenches1.ToString();
                TakenPredictedBrenches.Text = "TakenPredictedBrenches = " + TakenPredictedBrenches1.ToString();
                NotTakenPredictedBrenches.Text = "NotTakenPredictedBrenches = " + NotTakenPredictedBrenches1.ToString();

                series.Points.Add(new DataPoint(1, TakenBrenches1) { AxisLabel = "TotalBrenches" });
                series.Points.Add(new DataPoint(2, NotTakenBrenches1) { AxisLabel = "TakenBrenches" });
                chart1.Series.Add(series);

                series2.Points.Add(new DataPoint(1, TakenPredictedBrenches1) { AxisLabel = "TakenPredictedBrenches" });
                series2.Points.Add(new DataPoint(2, NotTakenPredictedBrenches1) { AxisLabel = "NotTakenPredictedBrenches" });
                chart2.Series.Add(series);

                /*
                if (TakenBrenches1 > TakenPredictedBrenches1)
                {
                    Accuracy.Text = "Accuracy = " + (double)TakenPredictedBrenches1 / TakenBrenches1;
                }

                else
                {
                    Accuracy.Text = "Accuracy = " + (double)TakenBrenches1 / TakenPredictedBrenches1;
                }
                */

                Accuracy.Text = "Accuracy = " + (double)GoodPrediction / (GoodPrediction + BadPrediction);

            }

            else {
                ErrorLabel.Text = "error";
            }
        }
    }
}
