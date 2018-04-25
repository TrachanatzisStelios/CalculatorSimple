using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSimple
{
    public partial class CalculatorSimple : Form
    {
        double FstN = 0;
        double SndN = 0;
        double result;
        string operator1;
        bool percentCase = false;

        public CalculatorSimple()
        {
            InitializeComponent();
        }

        private void No0_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "0";
        }

        private void No1_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "1";
        }

        private void No2_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "2";
        }

        private void No3_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "3";
        }

        private void No4_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "4";
        }

        private void No5_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "5";
        }

        private void No6_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "6";
        }

        private void No7_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "7";
        }

        private void No8_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "8";
        }

        private void No9_Click(object sender, EventArgs e)
        {
            ScreenText.Text += "9";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if(ScreenText.Text == "") { ScreenText.Text = ""; }
            else
            {
                FstN = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text = "";
                operator1 = "+";
            }
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (ScreenText.Text.Contains("-")) {
                ScreenText.Text = ScreenText.Text;
                FstN = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text = "";
                operator1 = "-";
            }
            else if (ScreenText.Text == "") { ScreenText.Text += "-"; }
            else
            {
                FstN = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text = "";
                operator1 = "-";
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (ScreenText.Text == "") { ScreenText.Text = ""; }
            else
            {
                FstN = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text = "";
                operator1 = "x";
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {   
            if (ScreenText.Text == "") { ScreenText.Text = ""; }
            else
            {
                FstN = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text = "";
                operator1 = "/";
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (ScreenText.Text == "") { ScreenText.Text = ""; }
            else
            {
                if (percentCase == false)
                {
                    SndN = Convert.ToDouble(ScreenText.Text);

                    switch (operator1)
                    {
                        case "x":
                            result = FstN * SndN;
                            FstN = 0;
                            break;
                        case "/":
                            result = FstN / SndN;
                            FstN = 0;
                            break;
                        case "+":
                            result = FstN + SndN;
                            FstN = 0;
                            break;
                        case "-":
                            result = FstN - SndN;
                            FstN = 0;
                            break;
                    }
                    ScreenText.Text = Convert.ToString(result);
                }
                else
                {
                    switch (operator1)
                    {
                        case "x":
                            result = FstN * SndN;
                            FstN = 0;
                            break;
                        case "/":
                            result = FstN / SndN;
                            FstN = 0;
                            break;
                        case "+":
                            result = FstN + SndN;
                            FstN = 0;
                            break;
                        case "-":
                            result = FstN - SndN;
                            FstN = 0;
                            break;
                    }
                    ScreenText.Text = Convert.ToString(result);
                    percentCase = false;
                }
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (ScreenText.Text == "") { ScreenText.Text = ""; }
            else
            {
                if (ScreenText.Text.Contains(",")) { ScreenText.Text = ScreenText.Text; }
                else { ScreenText.Text += ","; }
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScreenText.Text = "";
            FstN = 0;
            SndN = 0;
            result = 0;
        }

        private void SqrButton_Click(object sender, EventArgs e)
        {
            if (ScreenText.Text == "")
            { ScreenText.Text = ""; }
            else
            { ScreenText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(ScreenText.Text))); }
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            if ( (ScreenText.Text == "") || (FstN == 0) )
            { ScreenText.Text = ""; }
            else { ScreenText.Text += '%'; }
            
            if (ScreenText.Text.Contains('%'))
            {
                ScreenText.Text = ScreenText.Text.TrimEnd('%');
                double temp;
                temp = Convert.ToDouble(ScreenText.Text);
                ScreenText.Text += '%';
                SndN = FstN * temp / 100;
                percentCase = true;
            }
        }

        private void ScreenText_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
