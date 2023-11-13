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

namespace PredictorPerceptronSimplu
{
    public partial class Form1 : Form
    {

        int windowWidth;
        int windowHeight;
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

            int windowWidth2 = (int)Math.Round(0.50 * windowWidth);

            richTextBox1.Location = new Point(windowWidth - windowWidth2, 0);

            richTextBox1.Size = new Size(windowWidth2, windowHeight);

            ErrorLabel.Text = windowWidth.ToString() + "    " + windowHeight.ToString();

            NumberOfBits.Text = "6";
            NumberOfPerceptrons.Text = "10";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Trace files (*.trc)|*.trc";
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
            if (NumberOfBits.Text.ToString() != "" && NumberOfPerceptrons.Text.ToString() != "")
            {
                int InputNumberOfBits = int.Parse(NumberOfBits.Text.ToString());
                int InputNumberOfPerceptrons = int.Parse(NumberOfPerceptrons.Text.ToString());

                int[] H = new int[InputNumberOfBits];
                int[,] P = new int[InputNumberOfPerceptrons, InputNumberOfBits];
                int[] Perceptron = new int[InputNumberOfBits];

                for (int i = 0; i < InputNumberOfBits; i++)
                {
                    if (i % 2 == 0)
                    {
                        H[i] = 1;
                    }
                    else
                    {
                        H[i] = -1;
                    }
                }

                for (int i = 0; i < InputNumberOfPerceptrons; i++)
                    for (int j = 0; j < InputNumberOfBits; j++)
                        P[i, j] = 1;

                int TotalBrenches1 = 0, TakenBrenches1 = 0, NotTakenBrenches1 = 0, TakenPredictedBrenches1 = 0, NotTakenPredictedBrenches1 = 0;

                TotalBrenches.Text = TotalBrenches1.ToString();
                TakenBrenches.Text = TakenBrenches1.ToString();
                NotTakenBrenches.Text = NotTakenBrenches1.ToString();
                TakenPredictedBrenches.Text = TakenPredictedBrenches1.ToString();
                NotTakenPredictedBrenches.Text = NotTakenPredictedBrenches1.ToString();


                string text = richTextBox1.Text;
                string[] lines = text.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                int PC, index, suma, contor;

                ErrorLabel.Text = text;

                foreach (string line in lines)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    contor = 0;
                    foreach (string word in words)
                    {
                        await Task.Delay(1000);

                        ErrorLabel.Text = word + " | DDDDDDDDDDDDDD";

                        if (word == "B")
                        {
                            await Task.Delay(1000);
                            ErrorLabel.Text = "DA";

                            PC = int.Parse(words[contor + 1]);

                            index = PC % InputNumberOfPerceptrons;
                            suma = 0;

                            //iau perceptronul
                            for (int i = 0; i < InputNumberOfBits; i++)
                                Perceptron[i] = P[index, i];


                            for (int i = 0; i < InputNumberOfBits; i++)
                                suma += Perceptron[i] * H[i];


                            if (suma >= 0)
                            {
                                //prezic ca saltul se face
                                TakenPredictedBrenches1 += 1;
                            }
                            else if (suma < 0)
                            {
                                //prezic ca saltul NU se face
                                NotTakenPredictedBrenches1 += 1;
                            }

                            // Verific daca saltul s a facut
                        }
                        contor += 1;
                    }

                    TotalBrenches.Text = TotalBrenches1.ToString();
                    TakenBrenches.Text = TakenBrenches1.ToString();
                    NotTakenBrenches.Text = NotTakenBrenches1.ToString();
                    TakenPredictedBrenches.Text = TakenPredictedBrenches1.ToString();
                    NotTakenPredictedBrenches.Text = NotTakenPredictedBrenches1.ToString();

                }
            }

            else {
                ErrorLabel.Text = "error";
            }
        }
    }
}
