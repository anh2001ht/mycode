internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 2, 3, 1, 5, 4, 6, 8, 20, 14 };
        int min = arr[0];
        static void findMin(int[] a, ref int min)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
        }
        findMin(arr, ref min);
        Console.WriteLine(min);
        Console.ReadKey();
        //123
    }
}