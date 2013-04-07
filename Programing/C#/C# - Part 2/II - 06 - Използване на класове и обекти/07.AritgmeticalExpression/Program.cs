///*Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
//*Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//*Arithmetic operators: +, -, *, / (standard priorities)
//*Mathematical functions: ln(x), sqrt(x), pow(x,y)
//*Brackets (for changing the default priorities)
//*Examples:
//*(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) ---> ~ 10.6
//*pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) ---> ~ 21.22
//*Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".*/

//using System;
//using System.Globalization;
//using System.Text;
//using System.Threading;

//public class Exercise07Expression
//{
//    private static void Main()
//    {
//        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
//        Console.Write("\nPlease enter expression like this (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) : ");
//        string test = Console.ReadLine();
//        StringBuilder expression = new StringBuilder();
//        expression.Append('(', 2);
//        foreach (var item in test)
//        {
//            if (item != ' ')
//            {
//                expression.Append(item);
//            }
//        }

//        expression.Append(')', 2);

//        while (SearchBrackets(expression) != 0)
//        {
//            expression = CalculateExpression(true, SearchBrackets(expression), expression);
//        }

//        Console.WriteLine("\n\nResult is: {0}\n\n", expression);
//    }

//    private static decimal ExtractNum(int offset, int startPoint, StringBuilder expression)
//    {
//        int temp = 0;
//        StringBuilder result = new StringBuilder();
//        startPoint += offset;
//        if (offset > 0 && (expression[startPoint] == '-' || expression[startPoint] == '+'))
//        {
//            result.Append(expression[startPoint]);
//            startPoint += offset;
//        }

//        while (int.TryParse(expression[startPoint].ToString(), out temp) || expression[startPoint] == '.')
//        {
//            if (offset == -1)
//            {
//                result.Insert(0, expression[startPoint]);
//                if ((expression[startPoint - 1] == '-' || expression[startPoint - 1] == '+') && !int.TryParse(expression[startPoint - 2].ToString(), out temp))
//                {
//                    result.Insert(0, expression[startPoint - 1]);
//                }
//            }
//            else
//            {
//                result.Append(expression[startPoint]);
//            }

//            if (startPoint > 0 && startPoint < expression.Length - 1)
//            {
//                startPoint += offset;
//            }
//            else
//            {
//                break;
//            }
//        }

//        return decimal.Parse(result.ToString());
//    }

//    private static StringBuilder Calculate(int startPoint, StringBuilder expression)
//    {
//        decimal result = 0;
//        switch (expression[startPoint])
//        {
//            case '-':
//                {
//                    result = ExtractNum(-1, startPoint, expression) - ExtractNum(1, startPoint, expression);
//                    return Exchange(startPoint - ExtractNum(-1, startPoint, expression).ToString().Length, startPoint + ExtractNum(1, startPoint, expression).ToString().Length + 1, result.ToString(), expression);
//                }

//            case '+':
//                {
//                    result = ExtractNum(-1, startPoint, expression) + ExtractNum(1, startPoint, expression);
//                    return Exchange(startPoint - ExtractNum(-1, startPoint, expression).ToString().Length, startPoint + ExtractNum(1, startPoint, expression).ToString().Length + 1, result.ToString(), expression);
//                }

//            case '*':
//                {
//                    result = ExtractNum(-1, startPoint, expression) * ExtractNum(1, startPoint, expression);
//                    return Exchange(startPoint - ExtractNum(-1, startPoint, expression).ToString().Length, startPoint + ExtractNum(1, startPoint, expression).ToString().Length + 1, result.ToString(), expression);
//                }

//            default:
//                {
//                    result = ExtractNum(-1, startPoint, expression) / ExtractNum(1, startPoint, expression);
//                    return Exchange(startPoint - ExtractNum(-1, startPoint, expression).ToString().Length, startPoint + ExtractNum(1, startPoint, expression).ToString().Length + 1, result.ToString(), expression);
//                }
//        }
//    }

//    private static StringBuilder Exchange(int startIndex, int endIndex, string valueToExchange, StringBuilder expression)
//    {
//        expression.Remove(startIndex, endIndex - startIndex);
//        expression.Insert(startIndex, valueToExchange);
//        return expression;
//    }

//    private static StringBuilder CalculateFunc(int startIndex, StringBuilder expression)
//    {
//        CalculateExpression(false, startIndex, expression);
//        decimal result = 0;
//        switch (expression[startIndex - 1])
//        {
//            case 'n':
//                {
//                    result = (decimal)Math.Log((double)ExtractNum(1, startIndex, expression));
//                    return Exchange(startIndex - 2, startIndex + ExtractNum(1, startIndex, expression).ToString().Length + 2, result.ToString(), expression);
//                }

//            case 't':
//                {
//                    result = (decimal)Math.Sqrt((double)ExtractNum(1, startIndex, expression));
//                    return Exchange(startIndex - 4, startIndex + ExtractNum(1, startIndex, expression).ToString().Length + 2, result.ToString(), expression);
//                }

//            default:
//                {
//                    int startIndex2 = startIndex;
//                    while (expression[startIndex2] != ',')
//                    {
//                        startIndex2++;
//                    }

//                    result = (decimal)Math.Pow((double)ExtractNum(-1, startIndex2, expression), (double)ExtractNum(1, startIndex2, expression));
//                    return Exchange(startIndex - 3, startIndex + ExtractNum(-1, startIndex2, expression).ToString().Length + ExtractNum(1, startIndex2, expression).ToString().Length + 3, result.ToString(), expression);
//                }
//        }
//    }

//    private static int SearchBrackets(StringBuilder expression)
//    {
//        int index = 0;
//        int result = 0;
//        while (index < expression.Length && expression[index] != ')')
//        {
//            if (expression[index] == '(')
//            {
//                result = index;
//            }

//            index++;
//        }

//        return result;
//    }

//    private static StringBuilder CalculateExpression(bool checkForFunc, int startIndex, StringBuilder expression)
//    {
//        if (checkForFunc)
//        {
//            int mod = 1;
//            if (startIndex == 0)
//            {
//                mod = 0;
//            }

//            if (expression[startIndex - mod] == 'n' || expression[startIndex - mod] == 't' || expression[startIndex - mod] == 'w')
//            {
//                return CalculateFunc(startIndex, expression);
//            }
//        }

//        while (SearchSign('*', startIndex, expression) != 0)
//        {
//            expression = Calculate(SearchSign('*', startIndex, expression), expression);
//        }

//        while (SearchSign('/', startIndex, expression) != 0)
//        {
//            expression = Calculate(SearchSign('/', startIndex, expression), expression);
//        }

//        while (SearchSign('-', startIndex, expression) != 0 || SearchSign('+', startIndex, expression) != 0)
//        {
//            while (SearchSign('+', startIndex, expression) != 0)
//            {
//                if (SearchSign('-', startIndex, expression) != 0 && (SearchSign('-', startIndex, expression) < SearchSign('+', startIndex, expression)))
//                {
//                    break;
//                }

//                expression = Calculate(SearchSign('+', startIndex, expression), expression);
//            }

//            while (SearchSign('-', startIndex, expression) != 0)
//            {
//                expression = Calculate(SearchSign('-', startIndex, expression), expression);
//            }
//        }

//        if (checkForFunc)
//        {
//            expression.Remove(startIndex, 1);
//            while (expression[startIndex] != ')')
//            {
//                startIndex++;
//            }

//            expression.Remove(startIndex, 1);
//        }

//        return expression;
//    }

//    private static int SearchSign(char sign, int startIndex, StringBuilder expression)
//    {
//        int resultIndex = 0;
//        while (expression[startIndex] != ')' && startIndex < expression.Length)
//        {
//            bool check = expression[startIndex - 1] == '*' || expression[startIndex - 1] == '/' || expression[startIndex - 1] == '+' || expression[startIndex - 1] == '-' || expression[startIndex - 1] == ',' || expression[startIndex - 1] == '(';
//            if (expression[startIndex] == sign && !check)
//            {
//                resultIndex = startIndex;
//                break;
//            }

//            startIndex++;
//        }

//        return resultIndex;
//    }
//}