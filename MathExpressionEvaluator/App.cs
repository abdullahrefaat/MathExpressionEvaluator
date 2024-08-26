using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ConsoleApp.TrainingApps.MathExpressionEvaluator
{
    public static class App
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                Console.Write("Enter an expression: ");
                var input = Console.ReadLine();
                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"L => {expr.LeftSideOperand}, Op => {expr.Operation}, R => {expr.RightSideOperand}");
                Console.WriteLine($"{input} = {EvaluateExpression(expr)}");
            }
        }

        private static object EvaluateExpression(MathExpression expr)
        {
            if (expr.Operation == MathOperation.Addition)
                return expr.LeftSideOperand + expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Subtraction)
                return expr.LeftSideOperand - expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Multiplication)
                return expr.LeftSideOperand * expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Division)
                return expr.LeftSideOperand / expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Power)
                return Math.Pow(expr.LeftSideOperand, expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Modulus)
                return expr.LeftSideOperand % expr.RightSideOperand;
            else if (expr.Operation == MathOperation.Sin)
                return Math.Sin(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Cos)
                return Math.Cos(expr.RightSideOperand);
            else if (expr.Operation == MathOperation.Tan)
                return Math.Tan(expr.RightSideOperand);

            return 0;
        }
    }
}
