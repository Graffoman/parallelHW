using System.Diagnostics;

namespace parallelHW.Classes
{
    internal class MyTimer
    {
        public delegate int CalculationDelegate();

        public static void MeasureTime(CalculationDelegate calculationDelegate, string calculationType)
        {
            Stopwatch sw = Stopwatch.StartNew();

            sw.Start();

            var result = calculationDelegate();

            sw.Stop();

            Console.WriteLine("");
            Console.WriteLine($"CalculationType={calculationType}");
            Console.WriteLine($"ElapsedMilliseconds={sw.ElapsedMilliseconds}");
            Console.WriteLine($"Result sum={result}");
        }
    }
}
