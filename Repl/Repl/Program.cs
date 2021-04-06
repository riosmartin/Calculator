using Core.Expression;
using Core.Parsing;
using Core.Parsing.Expression;
using System;

namespace Repl
{
    class Program
    {
        private static void Main(string[] args)
        {
            string input = "";
            while (input.ToLower() != "exit")
            {
                Console.WriteLine($"Please, provide an operation to be evaluated or write 'exit' to close the program: ");
                input = Console.ReadLine();
                if (input.ToLower() != "exit")
                {
                    ProcessOperation(input);
                }
            }

        }

        private static void ProcessOperation(string operation)
        {
            try
            {
                ParseAndSolve(operation);
            }
            catch (UnrecognizedExpressionException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unhandled exception was thrown : {e.Message} at {e.StackTrace}");
            }
        }

        private static void ParseAndSolve(string operation)
        {
            Console.WriteLine($"Evaluating operation : {operation}");
            IExpression parsedExpression = ParsingEngine.Parse(operation);
            Console.WriteLine($"Parsed Expression : {parsedExpression.Print()}");
            Solve(parsedExpression);
        }

        private static void Solve(IExpression expression)
        {
            Console.WriteLine($"Evaluation result : {expression.Evaluate()}");
        }
    }
}
