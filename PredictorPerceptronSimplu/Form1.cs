using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictorPerceptronSimplu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
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

        private void Start_Click(object sender, EventArgs e)
        {
            int InputNumberOfBits = 0, InputNumberOfPerceptrons = 0;
            if (NumberOfBits.Text.ToString() != "" && NumberOfPerceptrons.Text.ToString() != "")
            {
                InputNumberOfBits = int.Parse(NumberOfBits.Text.ToString());
                InputNumberOfPerceptrons = int.Parse(NumberOfPerceptrons.Text.ToString());
            }

            else {
                ErrorLabel.Text = "error";
            }

        }
    }
}
