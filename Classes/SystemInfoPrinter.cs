namespace parallelHW.Classes
{
    internal class SystemInfoPrinter
    {
        public static void PrintSystemInfo()
        {
            Console.WriteLine("_____System Info_____");
            Console.WriteLine();
            Console.WriteLine($"Total RAM: 8 GB");

            int processorCount = Environment.ProcessorCount;
            Console.WriteLine($"Number of processor cores: {processorCount}");

            string osVersion = Environment.OSVersion.ToString();
            Console.WriteLine($"Operating system: {osVersion}");

            Console.WriteLine("_____________________");
            Console.WriteLine();
        }
    }
}
