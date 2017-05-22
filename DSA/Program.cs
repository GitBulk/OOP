namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //BalanceBracket.Frame.Run();
            //StackEx.Frame.Run();
            
            int []arr = { -7, 1, 5, 2, -4, 3, 0 };
            int arr_size = arr.Length;
            System.Console.WriteLine("First equilibrium index is " +
                               Eequilibrium(arr, arr_size));
        }

        static int Eequilibrium(int[] arr, int n)
        {
            int sum = 0;      // initialize sum of whole array
            int leftsum = 0; // initialize leftsum

            /* Find sum of the whole array */
            for (int i = 0; i < n; ++i)
                sum += arr[i];

            for (int i = 0; i < n; ++i)
            {
                sum -= arr[i]; // sum is now right sum for index i

                if (leftsum == sum)
                    return i;

                leftsum += arr[i];
            }

            /* If no equilibrium index found, then return 0 */
            return -1;
        }
    }

}
