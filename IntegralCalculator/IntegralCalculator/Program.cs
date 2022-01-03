using System;
using System.Linq.Expressions;
using IntegralCalculator;
using ParseFormula;

static void Main(string[] args)
 {
     Console.OutputEncoding = System.Text.Encoding.UTF8;
     Console.WriteLine("Введите функцию с параметром Х");

     var str = Console.ReadLine();

     double[] accuracy = {0.1, 0.05, 0.01};

     try
     {
         var x = Expression.Parameter(typeof(double), "x");
         var expression = ParseFormula.DynamicExpression.ParseLambda(new ParameterExpression[]{x},typeof(double),str);

         var func = (Func<double, double>) expression.Compile();
         var calc = new Calculator();
         

         var y = calc.CalculateIntegral(func);

         Console.Write(
     }
     catch (Exception e)
     {
         Console.WriteLine(e);
     }
 }
