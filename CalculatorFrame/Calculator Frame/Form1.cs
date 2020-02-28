using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Frame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double num1 = 0;
            Double num2 = 0;
            try
            {
                num1 = Convert.ToDouble(tbxNum1.Text);
                num2 = Convert.ToDouble(tbxNum2.Text);

                switch (cbbxSymbol.SelectedItem.ToString())
                {
                    case "＋":
                        lblResultNum.Text = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        lblResultNum.Text = Convert.ToString(num1 - num2);
                        break;
                    case "×":
                        lblResultNum.Text = Convert.ToString(num1 * num2);
                        break;
                    case "÷":
                        if (num2 == 0)
                        {
                            lblResultNum.Text = ("error：Dividend Cannot Be Zero");
                        }
                        else
                        {
                            lblResultNum.Text = Convert.ToString(num1 / num2);
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                lblResultNum.Text = "error: Wrong Number";
            }
            catch(OverflowException)
            {
                lblResultNum.Text = "error: Number Overflow";
            }
            catch(NullReferenceException)
            {
                lblResultNum.Text = " error: Wrong Sign of Operation";
            }
        }
    }
}
