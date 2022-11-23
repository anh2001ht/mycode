using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Pets
{
    public class Chicken : Animal
    {
        public override string Type { get; set; } = "Chicken";
        public override void Speak()
        {
            Console.WriteLine("O O O");
        }
    }
}
