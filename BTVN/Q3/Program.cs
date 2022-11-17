using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.UTF8;

        string[] arr = new string[] {
            "Event-Assign", "Event-View", "Event-Assign", "Event-Acept",
            "Event-Delete", "Event-Assign", "Event-Acept", "Event-Delete", "Event-Delete",
            "Event-View", "Event-Assign", "Event-Acept", "Event-Delete", "Event-Assign"
        };
        int count = 0;

        foreach (string s in arr)
        {
            if (s.Equals("Event-Acept"))
            {
                count++;
            }
        }

        int countEvent = 0;
        for (int i = 0; i < arr.Length - 3; i++)
        {
            if (arr[i].Equals("Event-View") && arr[i + 1].Equals("Event-Assign") &&
                arr[i + 2].Equals("Event-Acept") && arr[i + 3].Equals("Event-Delete"))
            {
                countEvent++;
            }
        }
        Console.WriteLine("Số lượng giao dịch: " + countEvent);
        Console.WriteLine("Số lượng Event-Acept: " + count);


        Console.ReadKey();
        //123
    }
}