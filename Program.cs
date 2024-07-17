using parallelHW.Classes;


SystemInfoPrinter.PrintSystemInfo();

List<int> collectionSizes = [100_000, 1_000_000, 10_000_000];

foreach (int size in collectionSizes)
{
    Console.WriteLine("__________________________________________");
    Console.WriteLine("");
    Console.WriteLine($"Working with collection size of {size} elements");
    Console.WriteLine("__________________________________________");

    var myCollection = NumberMethods.GenerateRandomNumbers(size);

    MyTimer.MeasureTime(() => NumberMethods.SequentialSum(myCollection), "SequentialSum");
    MyTimer.MeasureTime(() => NumberMethods.ParallelSum(myCollection), "ParallelSum");
    MyTimer.MeasureTime(() => NumberMethods.LinqSum(myCollection), "LinqSum");
}
