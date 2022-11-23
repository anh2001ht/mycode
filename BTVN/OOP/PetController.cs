using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Pets
{
    public class PetController
    {
        public void GetAllPets(List<Animal> pet)
        {
            foreach (var p in pet)
            {
                Console.WriteLine($"{p.Id,5}{p.Type,5} Height: {p.Height,5} Weight: {p.Weight} Color: {p.Color}");
                p.Speak();
                Console.WriteLine();
            }
        }
        public Animal FindPetByID(int id, List<Animal> pet)
        {
            var result = new Animal();
            foreach (var p in pet)
            {
                if (p.Id.Equals(id))
                {

                    result.Height = p.Height;
                    result.Weight = p.Weight;
                    result.Color = p.Color;
                    result.Type = p.Type;
                }
            }
            return result;
        }
        public void DeletePetByID(int id, List<Animal> pet)
        {
            foreach (var p in pet.ToList())
            {
                if (p.Id.Equals(id))
                {
                    pet.Remove(p);
                    Console.WriteLine($"Deleted Pet Id = {id}");
                }
            }
        }
        public void AddPet(List<Animal> pet)
        {
            Console.WriteLine("Add new pet: ");
            var p = new Animal();
            Console.WriteLine("ID: ");
            var pId = Input.GetInt(); p.Id = pId;
            Console.WriteLine("Height: ");
            var pHeight = Input.GetInt(); p.Height = pHeight;
            Console.WriteLine("Weight: ");
            var pWeight = Input.GetInt(); p.Weight = pWeight;
            Console.WriteLine("Color: ");
            var pColor = Input.GetString(); p.Color = pColor;
            Console.WriteLine("Type: ");
            var pType = Input.GetString(); p.Type = pType;
            pet.Add(p);
        }
    }

}
