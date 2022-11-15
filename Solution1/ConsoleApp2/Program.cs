using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên: ");
            
            string name =Console.ReadLine();
            Console.WriteLine("Nhập tuổi: ");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tôi tên là {name}");
            Console.WriteLine($"Năm nay tôi {age} tuổi");
            Console.ReadKey();
        }
    }
}
