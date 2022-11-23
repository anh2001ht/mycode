using System;

namespace OOP
{
    public class Animal : ISpeaking
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public virtual string Type { get; set; }
        public virtual void Speak()
        {

        }

    }

}