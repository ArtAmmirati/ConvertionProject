using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecToRom
{
    public partial class DecToRom : Form
    {
        public DecToRom()
        {
            InitializeComponent();
        }

        private void decToRomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            arabicEnterLB.Text = "Enter a number between 1 and 3999:";
            romanEnterLB.Text = "Roman Numeral Equivalent:";
            inputTextBox.Text = "";
            inputTextBox.MaxLength = 4;
            outputLabel.Text = "";
        }

        private void romToDecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            arabicEnterLB.Text = "Enter a Roman Numeral between I and MMMCMXCIX:";
            romanEnterLB.Text = "Decimal Equivalent:";
            inputTextBox.Text = "";
            inputTextBox.MaxLength = 16;
            outputLabel.Text = "";
        }

        private void romanEnterLB_Click(object sender, EventArgs e)
        {

        }

        private void convertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string a;
                string b;

                a = "(";
                b = ")";

                if (decToRomRadioButton.Checked)
                {
                    string Arabic;
                    Arabic = arabicToRoman.ArabicConverter(int.Parse(inputTextBox.Text));
                    outputLabel.Text = Arabic.ToString();
                }
                else if (romToDecRadioButton.Checked)
                {
                    int Roman;
                    Roman = romanToArabic.RomanConverter(inputTextBox.Text);
                    outputLabel.Text = Roman.ToString();
                }

                if (outputLabel.Text.Contains(a) == true && outputLabel.Text.Contains(b) == true)
                {
                    MessageBox.Show("Not in range");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
