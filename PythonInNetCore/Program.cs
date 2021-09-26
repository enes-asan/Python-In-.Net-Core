using IronPython.Hosting;
using System;

namespace PythonInNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
	//install IronPython packes from nuget
            var source = @"C:\Users\easan\Desktop\PythonInNetCore\PythonInNetCore\PythonInNetCore\PythonFiles\Calculate.py";
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var operation = engine.Operations;
            engine.ExecuteFile(source, scope);
            var calculate = scope.GetVariable("Calculate");
            dynamic ins = operation.CreateInstance(calculate);

            Console.WriteLine($"Sum={ins.sum(25,12)}");
            Console.WriteLine($"Multiply={ins.multiply(25, 12)}");
            Console.WriteLine($"Difference={ins.difference(25, 12)}");
            Console.WriteLine($"Divide={ins.divide(25, 12)}");
        }
    }
}
