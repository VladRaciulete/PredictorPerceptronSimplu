using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PredictorPerceptronSimplu
{
    public partial class Form1 : Form
    {
        int TotalBrenches = 0, TakenBrenches = 0, NotTakenBrenches = 0, TakenPredictedBrenches = 0, NotTakenPredictedBrenches = 0;

        Dictionary<string, string> TraceFiles = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SellectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Traces.Items.Count; i++)
            {
                Traces.SetSelected(i, true);
            }
        }

        private void UnsellectAll_Click(object sender, EventArgs e)
        {
            Traces.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            //int windowWidth = ClientRectangle.Width;
            //int windowHeight = ClientRectangle.Height;

            splitContainer1.Enabled = true;
            splitContainer1.FixedPanel = FixedPanel.None;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.SplitterDistance = 0;

            labelBits.Text = "Bits";

            GroupBox groupBoxLeft = new GroupBox();
            GroupBox groupBoxRight = new GroupBox();

            NumberOfPerceptrons.Anchor = AnchorStyles.None;
            labelPerceprton.Anchor = AnchorStyles.None;
            NumberOfBits.Anchor = AnchorStyles.None;
            labelBits.Anchor = AnchorStyles.None;
            SellectAll.Anchor = AnchorStyles.None;
            UnsellectAll.Anchor = AnchorStyles.None;
            Traces.Anchor = AnchorStyles.None;
            Start.Anchor = AnchorStyles.None;
            Add.Anchor = AnchorStyles.None;

            groupBoxLeft.Controls.Add(Add);
            groupBoxLeft.Controls.Add(Traces);
            groupBoxLeft.Controls.Add(SellectAll);
            groupBoxLeft.Controls.Add(UnsellectAll);
            groupBoxLeft.Controls.Add(labelBits);
            groupBoxLeft.Controls.Add(NumberOfBits);
            groupBoxLeft.Controls.Add(labelPerceprton);
            groupBoxLeft.Controls.Add(NumberOfPerceptrons);
            groupBoxLeft.Controls.Add(Start);

            if (true) { 
                int verticalSpacing = 10, horizontalSpacing = 10;
                int yPosition = -200;
                int xPosition;

                Add.Location = new Point((groupBoxLeft.Width - Add.Width) / 2, yPosition);
                yPosition += Add.Height + verticalSpacing;

                Traces.Location = new Point((groupBoxLeft.Width - Traces.Width) / 2, yPosition);
                yPosition += Traces.Height + verticalSpacing;

                xPosition = (groupBoxLeft.Width - SellectAll.Width - UnsellectAll.Width - horizontalSpacing) / 2;
                SellectAll.Location = new Point(xPosition, yPosition);
                xPosition += SellectAll.Width + horizontalSpacing;
                UnsellectAll.Location = new Point(xPosition, yPosition);
                yPosition += UnsellectAll.Height + 6 * verticalSpacing;

                xPosition = (groupBoxLeft.Width - SellectAll.Width - UnsellectAll.Width - horizontalSpacing) / 2;
                labelBits.Location = new Point(xPosition, yPosition);
                xPosition += labelPerceprton.Width + horizontalSpacing;
                NumberOfBits.Location = new Point(xPosition, yPosition);
                yPosition += NumberOfBits.Height + verticalSpacing;

                xPosition = (groupBoxLeft.Width - SellectAll.Width - UnsellectAll.Width - horizontalSpacing) / 2;
                labelPerceprton.Location = new Point(xPosition, yPosition);
                xPosition += labelPerceprton.Width + horizontalSpacing;
                NumberOfPerceptrons.Location = new Point(xPosition, yPosition);
                yPosition += NumberOfPerceptrons.Height + 6 * verticalSpacing;

                Start.Location = new Point((groupBoxLeft.Width - Start.Width) / 2, yPosition);
            }

            groupBoxLeft.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(groupBoxLeft);
            splitContainer1.Panel1.BackColor = Color.Azure;

            groupBoxRight.Controls.Add(richTextBox1);
            richTextBox1.Dock = DockStyle.Fill;
            groupBoxRight.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(groupBoxRight);

            splitContainer1.Panel1MinSize = 350;
            splitContainer1.Panel2MinSize = 800;

            NumberOfBits.Value = 6;
            NumberOfPerceptrons.Value = 10;

            Traces.SelectionMode = SelectionMode.MultiSimple;
            LoadTraceFiles();
        }

        public void LoadTraceFiles()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName;

            if (projectDirectory != null)
            {
                string traceFolderPath = Path.Combine(projectDirectory, "Trace");
                string[] files = Directory.GetFiles(traceFolderPath, "*.tra");
                TraceFiles.Clear();
                Traces.Items.Clear();
                foreach (string file in files)
                {
                    TraceFiles.Add(Path.GetFileNameWithoutExtension(file), file);
                    Traces.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Trace Files (*.tra)|*.tra|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Trace File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName;

                    if (projectDirectory != null)
                    {
                        string traceFolderPath = Path.Combine(projectDirectory, "Trace/");
                        string[] files = Directory.GetFiles(traceFolderPath, "*.tra");

                        string selectedFilePath = openFileDialog.FileName;
                        string destinationPath = Path.Combine(traceFolderPath, Path.GetFileName(selectedFilePath));

                        try
                        {
                            //File.Copy(selectedFilePath, destinationPath, true);
                            File.Copy(selectedFilePath, destinationPath);
                            LoadTraceFiles();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error adding the trace file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string traceFileContent;
            richTextBox1.Text = "";
            int counter = 0;

            if (Traces.SelectedItems.Count > 0)
            {
                if (NumberOfBits.Text.ToString() != "" && NumberOfPerceptrons.Text.ToString() != "")
                {
                    foreach (var selectedItem in Traces.SelectedItems)
                    {
                        string selectedTraceName = selectedItem.ToString();

                        if (TraceFiles.TryGetValue(selectedTraceName, out string selectedTraceFile))
                        {
                            //MessageBox.Show($"Selected Trace File: {selectedTraceFile}");

                            traceFileContent = File.ReadAllText(selectedTraceFile);

                            richTextBox1.AppendText("-----------------------------------------------------------------------------------------------\n");
                            richTextBox1.SelectionColor = Color.Red;
                            richTextBox1.AppendText("    " + selectedTraceName + "\n");
                            richTextBox1.AppendText(RunPrediction(traceFileContent));
                        }
                        counter += 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a trace file.");
            }
        }

        public string RunPrediction(string traceFileContent)
        {
            string output = "";
            TotalBrenches = 0;
            TakenBrenches = 0;
            NotTakenBrenches = 0;
            TakenPredictedBrenches = 0;
            NotTakenPredictedBrenches = 0;

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

            string text = traceFileContent;
            string[] lines = text.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            int PC, index, suma;
            bool predictedtrue, readtrue;
            int GoodPrediction = 0, BadPrediction = 0;

            foreach (string line in lines)
            {
                TotalBrenches += 1;
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
                            TakenPredictedBrenches += 1;
                            predictedtrue = true;
                        }
                        else if (suma < 0)
                        {
                            //prezic ca saltul NU se face
                            NotTakenPredictedBrenches += 1;
                            predictedtrue = false;
                        }

                        // Verific daca saltul s a facut
                        if (word[0] == 'B') // Saltul s-a facut
                        {
                            TakenBrenches += 1;
                            readtrue = true;

                            // incrementez seturile perceptronului cu 1 (nu si ponderile saltului curent
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
                            NotTakenBrenches += 1;
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

            output += "    Total Brenches  =  " + TotalBrenches.ToString() + "\n";
            output += "    Taken Brenches  =  " + TakenBrenches.ToString() + "  =  " + (((double)TakenBrenches / TotalBrenches)*100).ToString() + "%\n";
            output += "    Not Taken Brenches  =  " + NotTakenBrenches.ToString() + "  =  " + (((double)NotTakenBrenches / TotalBrenches) * 100).ToString() + "%\n";
            output += "\n";
            output += "    Taken Predicted Brenches  =  " + TakenPredictedBrenches.ToString() + "  =  " + (((double)TakenPredictedBrenches / TotalBrenches) * 100).ToString() + "%\n";
            output += "    Not Taken Predicted Brenches  =  " + NotTakenPredictedBrenches.ToString() + "  =  " + (((double)NotTakenPredictedBrenches / TotalBrenches) * 100).ToString() + "%\n";
            output += "    Right Predictions  =  " + GoodPrediction + "\n";
            output += "    Wrong Predictions  =  " + BadPrediction + "\n";
            output += "\n";
            output += "    Accuracy  =  " + (((double)GoodPrediction / (GoodPrediction + BadPrediction))*100).ToString() + "%\n";
            output += "\n";
            output += "\n";

            return output;
        }
    }
}
