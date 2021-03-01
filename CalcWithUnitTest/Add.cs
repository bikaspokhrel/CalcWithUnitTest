using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithUnitTest
{
    public class Add
    {
        string result;
        Single number1, number2;
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
}