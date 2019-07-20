using System;
using System.Linq;

class Parser
{
    private string calculatorInput;
    private string[] calculatorOperators;
    private string[] splitCalculatorInput;
    public Parser(string calculatorInput)
    {
        this.calculatorInput = calculatorInput;
    }

    private void OperatorScouter(string input)
    {
        int numberOfOperators = input.Length - input.Count(Char.IsDigit);
        calculatorOperators = new string[numberOfOperators];
        int arrayLocation = 0;
        foreach (Char c in input)
        {
            if (!Char.IsDigit(c))
            {
                calculatorOperators[arrayLocation] = c.ToString();
                arrayLocation++;
            }
        }
    }

    private void InputSplitter(string input)
    {
        splitCalculatorInput = new string[calculatorOperators.Length];
        int nextInputIndex = 0;
        for (int i = 0; i < calculatorOperators.Length; i++)
        {
            splitCalculatorInput[i] = input.Substring(nextInputIndex, input.IndexOf(calculatorOperators[i]));
            nextInputIndex = input.IndexOf(calculatorOperators[i]) + 1;
        }
    }

    private void OperatorPrecedence()
    {

    }
}