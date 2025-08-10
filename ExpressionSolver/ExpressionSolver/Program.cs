using System;
using System.Collections.Generic;
namespace ExpressionSolver;
class Program
{
    static void Main()
    {
        string strExpression = "2+3*3*2+((3+5)/(2*4))+1+(1/2*3)";
        bool isValid = ExpressionValidator.IsValidExpression(strExpression);
        if (!isValid)
        {
            Console.WriteLine("Invalid expression.");
        }
        else
        {
            var e = strExpression.GetEnumerator();
            e.MoveNext();
            double result = ExpressionSolver.Evaluate(e);
            Console.WriteLine(result);
        }
            
    }
}
