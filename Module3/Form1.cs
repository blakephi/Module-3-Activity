using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string text = InputBox.Text;
            var Words = text.Split(' ');
            List<WordOccurrence> occurrences = WordCalculator.CalculateOccurrences(Words.ToList());
            string results = "";

            foreach (WordOccurrence occurrence in occurrences)
            {
                results += occurrence.ToString();
            }

            ResultsLabel.Text = results;
        }
    }
}
