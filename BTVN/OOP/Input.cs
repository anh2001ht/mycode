using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public static class Input
    {
        public static int GetInt()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static string GetString()
        {
            var str = Console.ReadLine();
            return str;
        }




    }
}
