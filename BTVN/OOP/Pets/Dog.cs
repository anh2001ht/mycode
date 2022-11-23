using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Pets
{
    public class Dog : Animal
    {
        public override string Type { get; set; } = "Dog";
        public override void Speak()
        {
            Console.WriteLine("gaugau");
        }
    }
}
