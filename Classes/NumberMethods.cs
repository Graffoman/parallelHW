namespace parallelHW.Classes
{
    internal class NumberMethods
    {
        public static int[] GenerateRandomNumbers(int collectionSize)
        {
            Random random = new();

            List<int> randomNumbers = [];
            for (int i = 0; i < collectionSize; i++)
            {
                int randomNumber = random.Next(1, 101);
                randomNumbers.Add(randomNumber);
            }
            return randomNumbers.ToArray();
        }

        public static int SequentialSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int ParallelSum(int[] array)
        {
            int sum = 0;
            object lockObject = new object();

            Parallel.For(0, array.Length, () => 0, (i, loopState, partialSum) =>
            {
                partialSum += array[i];
                return partialSum;
            },
            partialSum =>
            {
                lock (lockObject)
                {
                    sum += partialSum;
                }
            });

            return sum;
        }

        public static int LinqSum(int[] array)
        {
            return array.AsParallel().Sum();
        }
    }
}
