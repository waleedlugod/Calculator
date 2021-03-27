using System;
class Calculator
{
    public static void Main()
    {
        double operandFirst, operandSecond;
        double answer = 0;
        char operation;
        bool isNum;

        do
        {
            Console.Write("Enter the first operand: ");
            isNum = double.TryParse(Console.ReadLine(), out operandFirst);
        } while (!isNum);

        do
        {
            Console.Write("Enter an operation (+, -, *, /, %, ^): ");
            operation = char.Parse(Console.ReadLine());
        } while (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != '%' && operation != '^');

        do
        {
            Console.Write("Enter the second operand: ");
            isNum = double.TryParse(Console.ReadLine(), out operandSecond);
        } while (!isNum);

        switch (operation)
        {
            case '+':
                answer = operandFirst + operandSecond;
                break;
            case '-':
                answer = operandFirst - operandSecond;
                break;
            case '*':
                answer = operandFirst * operandSecond;
                break;
            case '/':
                answer = operandFirst / operandSecond;
                break;
            case '%':
                answer = operandFirst % operandSecond;
                break;
            case '^':
                answer = Math.Pow(operandFirst, operandSecond);
                break;
        }


        Console.WriteLine("The answer is: " + answer);
    }
}