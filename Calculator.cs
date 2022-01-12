using System;
using System.Collections.Generic;
using System.Text;
/*
 Rameswari, Bhoi
Description: This class is build for performing the simple calculations
Date: 10/7/2021
 */
namespace Project_420_WebApp
{
    class Calculator 
    {
        private string op;
        private double operand1;
        private double operand2;
        private string result_string;

        public double Operand1 {
            get { return operand1; }
            set {
                if (value >= 0)
                {
                    operand1 = value;
                }
            }
        }
        public double Operand2
        {
            get { return operand2; }
            set
            {
                if (value >= 0)
                {
                    this.operand2 = value;
                }
            }
        }
        public String Result_string
        {
            get { return result_string; }
            set
            {
                 this.result_string = value; 
            }
        }
        public void Add(double displayValue)
        {
            op = "+";
            operand1 = displayValue;
        }

        public void Subtract(double displayValue)
        {
            op = "-";
            operand1 = displayValue;
        }

        public void Multiply(double displayValue)
        {
            op = "*";
            operand1 = displayValue;
        }

        public void Divide(double displayValue)
        {
            op = "/";
            operand1 = displayValue;
        }
        public double Equals(double displayValue)
        {
            double result;
            operand2 = displayValue;
            switch (op)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                default:
                    result = operand1 / operand2;
                    break;
            }
            result_string = operand1.ToString() + " " + op + " " + operand2.ToString() + " = " + result.ToString();
            return Math.Round(result,3);
        }
        public void Clear()
        {
            operand1 = operand2 = 0;
        }
    }
}
