using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPRO
{
    public partial class Form1 : Form
    {
        
        private string currentInput = "0";
        private string operation = "";
        private double firstNumber = 0;
        private bool operationPressed = false;
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void UpdateDisplay()
        {
            if (numbersimput != null)
                numbersimput.Text = currentInput;
        }

        
        private void ShowResult(string resultText)
        {
            if (result != null)
                result.Text = resultText;
        }

        
        private void HandleNumberInput(string number)
        {
            if (isNewEntry || currentInput == "0")
            {
                currentInput = number;
                isNewEntry = false;
            }
            else
            {
                currentInput += number;
            }
            UpdateDisplay();
        }

        
        private void HandleOperation(string op)
        {
            if (!operationPressed)
            {
                firstNumber = double.Parse(currentInput);
            }
            else if (operation != "" && !isNewEntry)
            {
                PerformCalculation();
            }

            operation = op;
            operationPressed = true;
            isNewEntry = true;
        }

       
        private void PerformCalculation()
        {
            if (operation == "" || isNewEntry) return;

            double secondNumber = double.Parse(currentInput);
            double calculationResult = 0;

            switch (operation)
            {
                case "+":
                    calculationResult = firstNumber + secondNumber;
                    break;
                case "-":
                    calculationResult = firstNumber - secondNumber;
                    break;
                case "×":
                    calculationResult = firstNumber * secondNumber;
                    break;
                case "÷":
                    if (secondNumber != 0)
                        calculationResult = firstNumber / secondNumber;
                    else
                    {
                        ShowResult("Error");
                        currentInput = "0";
                        UpdateDisplay();
                        return;
                    }
                    break;
                case "%":
                    calculationResult = (firstNumber * secondNumber) / 100;
                    break;
            }

            
            ShowResult(calculationResult.ToString());
            firstNumber = calculationResult;
            currentInput = calculationResult.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleNumberInput("4");
        }

        private void BorrarTODO_Click(object sender, EventArgs e)
        {
            currentInput = "0";
            operation = "";
            firstNumber = 0;
            operationPressed = false;
            isNewEntry = true;
            UpdateDisplay();
            ShowResult("0");
        }

        private void parentesis_Click(object sender, EventArgs e)
        {
            
            currentInput = "0";
            isNewEntry = true;
            UpdateDisplay();
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            HandleOperation("%");
        }

        private void dividido_Click(object sender, EventArgs e)
        {
            HandleOperation("÷");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            HandleNumberInput("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            HandleNumberInput("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            HandleNumberInput("9");
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            HandleOperation("×");
        }

        private void five_Click(object sender, EventArgs e)
        {
            HandleNumberInput("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            HandleNumberInput("6");
        }

        private void restar_Click(object sender, EventArgs e)
        {
            HandleOperation("-");
        }

        private void one_Click(object sender, EventArgs e)
        {
            HandleNumberInput("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            HandleNumberInput("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            HandleNumberInput("3");
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            HandleOperation("+");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            HandleNumberInput("0");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                if (isNewEntry)
                {
                    currentInput = "0.";
                    isNewEntry = false;
                }
                else
                {
                    currentInput += ".";
                }
                UpdateDisplay();
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 1 && currentInput != "Error")
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }
            else
            {
                currentInput = "0";
                isNewEntry = true;
            }
            UpdateDisplay();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operation != "" && !isNewEntry)
            {
                PerformCalculation();
                operation = "";
                operationPressed = false;
                isNewEntry = true;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
        
        }

        private void numbersimput_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateDisplay();
            ShowResult("0");
        }
    }
}