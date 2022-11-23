using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Pets
{
    public class Cat : Animal
    {
        public override string Type { get; set; } = "Cat";
        public override void Speak()
        {
            Console.WriteLine("meomeo");
        }
    }
}
