using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace DelegateProgram
{
    delegate void PerformOperation(int a, int b);
    internal static class MyProgram
    {
        static void Main(string[] args)
        {
            PerformOperation handler = null;

            handler += Calculate;
            handler += Log;
            handler += Notify;

            Console.WriteLine("First Invocation");
            handler(10, 5);

            handler -= Log;

            Console.WriteLine("Second Invocation");
            handler(10, 5);

            Console.ReadLine();
        }
        static void Calculate(int a, int b)
        {
            Console.WriteLine($"Result: {a + b}");
        }

        static void Log(int a, int b)
        {
            Console.WriteLine($"Log Calculating {a} + {b}");
        }

        static void Notify(int a, int b)
        {
            Console.WriteLine("Notification: Calculation completed");
        }

    }
}
