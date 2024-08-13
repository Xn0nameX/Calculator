using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SOLIDCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double finalResult = 0;

        private string operation = "";

        private string userInputNumber = "";


        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    finalResult += userInputNumberToDouble();
                    checkdata.Text = ("Итого:" + finalResult.ToString());
                    userInputNumber = "";
                    inputField.Text = "";
                    break;
                case "-":
                    finalResult -= userInputNumberToDouble();
                    checkdata.Text = ("Итого:" + finalResult.ToString());
                    userInputNumber = "";
                    inputField.Text = "";
                    break;
                case "*":
                    finalResult *= userInputNumberToDouble();
                    checkdata.Text = ("Итого:" + finalResult.ToString());
                    userInputNumber = "";
                    inputField.Text = "";
                    break;
                case "/":
                    finalResult /= userInputNumberToDouble();
                    checkdata.Text = ("Итого:" + finalResult.ToString());
                    userInputNumber = "";
                    inputField.Text = "";
                    break;

            }
          
            
        }

        private double userInputNumberToDouble()
        {
            return Convert.ToDouble(inputField.Text);
        }

        private void addNumberToUserInputNumber(string number)
        {
            userInputNumber += number;
            inputField.Text = userInputNumber;
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("0");
        }

        private void comma_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber(",");
        }

        private void eraseNumber_Click(object sender, EventArgs e)
        {
            if (inputField.Text != "")
            {
                inputField.Text = inputField.Text.Remove(inputField.Text.Length - 1);
                userInputNumber = inputField.Text.Remove(inputField.Text.Length - 1);
            }
            
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("3");
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("2");
        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("1");
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("6");
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("5");
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("4");
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("9");
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("8");
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            addNumberToUserInputNumber("7");
        }

        private void plusNumber_Click(object sender, EventArgs e)
        {
                
                operation = "+";
                finalResult += userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();

        }
        private int stepOfMinus = 0;
        private void minusNumber_Click(object sender, EventArgs e)
        {
            operation = "-";
            if (stepOfMinus == 0 && operation !="")
            {
                finalResult += userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
                stepOfMinus += 1;
            }
            else
            {
                finalResult -= userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
            }
        }

        private int stepOfMulty = 0;
        private void multiplyNumber_Click(object sender, EventArgs e)
        {
            operation = "*";
            if (stepOfMulty == 0)
            {
                finalResult += userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
                stepOfMulty += 1;
            }
            else
            {
                finalResult *= userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
            }
        }
        private int stepOfDivide = 0;
        private void divideNumber_Click(object sender, EventArgs e)
        {
            operation = "/";
            if (stepOfDivide == 0)
            {
                finalResult += userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
                stepOfDivide += 1;
            }
            else
            {
                finalResult/= userInputNumberToDouble();
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
            }

        }

        private void rootOfTheNumber_Click(object sender, EventArgs e)
        {
            if (finalResult >= 0)
            {
                finalResult = userInputNumberToDouble();
                finalResult = Math.Sqrt(finalResult);
                userInputNumber = "";
                inputField.Text = userInputNumber;
                checkdata.Text = "Итого:" + finalResult.ToString();
            }

            else
            {
                checkdata.Text = "Неккоректный ввод";
            }
            
        }

        private void numberSquared_Click(object sender, EventArgs e)
        {
            finalResult = userInputNumberToDouble();
            finalResult = Math.Pow(finalResult, 2);
            userInputNumber = "";
            inputField.Text = userInputNumber;
            checkdata.Text = "Итого:" + finalResult.ToString();
        }

        private void oneDivideNumber_Click(object sender, EventArgs e)
        {
            finalResult = userInputNumberToDouble();
            finalResult = 1 / finalResult;
            userInputNumber = "";
            inputField.Text = userInputNumber;
            checkdata.Text = "Итого:" + finalResult.ToString();
        }

        private void checkdata_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stepOfMulty = 0;
            finalResult = 0;
            stepOfMinus = 0;
            userInputNumber = "";
            operation = "";
            inputField.Text = "";
            checkdata.Text = finalResult.ToString();
        }
    }
}
