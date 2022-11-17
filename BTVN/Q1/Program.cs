internal class Program
{
    public static void Main(string[] args)
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
        if (arr.Length==0)
        {
            Console.WriteLine("Array is null");
        } else
        {
            findMin(arr, ref min);
            Console.WriteLine(min);
        }
       
        Console.ReadKey();
    }
}