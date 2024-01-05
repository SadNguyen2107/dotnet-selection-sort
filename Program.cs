namespace SN_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();

            // Generate an array of 100,000 random numbers
            int[] array = GenerateRandomArray(100000);

            // Perform selection sort
            SelectionSort(array);


            stopWatch.Stop();
            Console.WriteLine($"Selection Sort takes {stopWatch.GetElapsedTime()} miliseconds");
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in the unsorted part of the array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next();
            }

            return array;
        }
    }
}