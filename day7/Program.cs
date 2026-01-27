namespace Day7_demo_1
{
    internal class Program
    {
        // Counting Sort implementation
        static void CountingSort(int[] arr, int maxValue)
        {
            int[] count = new int[maxValue + 1];

            // Step 1: Count occurrences
            foreach (int num in arr)
            {
                count[num]++;
            }

            // Step 2: Rebuild array
            int index = 0;
            for (int i = 0; i <= maxValue; i++)
            {
                while (count[i] > 0)
                {
                    arr[index++] = i;
                    count[i]--;
                }
            }
        }
        // radix sort implementation
        static void RadixSort(int[] arr)
        {
            int max = arr.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, exp);
            }
        }

        static void CountingSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            // Step 1: Count occurrences based on digit
            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }
            // Step 2: Update count array
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            // Step 3: Build output array
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }
            // Step 4: Copy output to original array
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        // Main method to test the sorting algorithms
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 2, 2, 8, 3, 3, 1 };
            Console.WriteLine("Original Array for Counting Sort: " + string.Join(", ", arr1));
            int maxValue = arr1.Max();
            CountingSort(arr1, maxValue);
            Console.WriteLine("Counting Sort Result: " + string.Join(", ", arr1));
            int[] arr2 = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.WriteLine("Original Array for Radix Sort: " + string.Join(", ", arr2));
            RadixSort(arr2);
            Console.WriteLine("Radix Sort Result: " + string.Join(", ", arr2));


        }
    }
}