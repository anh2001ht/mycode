using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.UTF8;
        string input = Console.ReadLine();
        switch (input)
        {
            case "2":
                Console.WriteLine("Thứ 2");
                break;
            case "3":
                Console.WriteLine("Thứ 3");
                break;
            case "4":
                Console.WriteLine("Thứ 4");
                break;
            case "5":
                Console.WriteLine("Thứ 5");
                break;
            case "6":
                Console.WriteLine("Thứ 6");
                break;
            case "7":
                Console.WriteLine("Thứ 7");
                break;
            case "CN":
                Console.WriteLine("Chủ nhật");
                break;
            default:
                Console.WriteLine("Không phải ngày trong tuần");
                break;
        }
        Console.ReadKey();

    }
}