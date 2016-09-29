using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson4
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = (Button)sender;

            ResultTextBox.Text = CalculatorButton.Text;


            switch(CalculatorButton.Text)
            {
                case "C":
                    ResultTextBox.Text = "0";
                    break;
                case "+":
                    // call the addition method
                    break;
                case "-":
                    // call the subtraction method
                    break;
            }
        }
    }
}
