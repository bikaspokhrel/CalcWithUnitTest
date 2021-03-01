using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithUnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string result;
        Single number1, number2;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            String num1 = numOne.Text;
            String num2 = numTwo.Text;
            String answer = Add(num1, num2);
            lblOutput.Text = answer;
        }
        public string Add(string num1, string num2)
        {
            try
            {
                Single sngNum1, sngNum2, sngAnswer;
                sngNum1 = Convert.ToSingle(num1);
                sngNum2 = Convert.ToSingle(num2);
                sngAnswer = sngNum1 + sngNum2;
                return sngAnswer.ToString();
            }
            catch (Exception)
            {
                return "Please provide the correct input";
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {

            String num1 = numOne.Text;
            String num2 = numTwo.Text;
            String answer = Multiply(num1, num2);
            lblOutput.Text = answer;
        }
        public string Multiply(string num1, string num2)
        {
            try
            {
                Single sngNum1, sngNum2, sngAnswer;
                sngNum1 = Convert.ToSingle(num1);
                sngNum2 = Convert.ToSingle(num2);
                sngAnswer = sngNum1 * sngNum2;
                return sngAnswer.ToString();
            }
            catch (Exception)
            {
                return "Please provide the correct input";
            }
        }
    }
}
