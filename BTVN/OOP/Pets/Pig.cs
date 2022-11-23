using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Pets
{
    public class Pig : Animal
    {
        public override string Type { get; set; } = "Pig";
        public override void Speak()
        {
            Console.WriteLine("un in");
        }
    }
}
