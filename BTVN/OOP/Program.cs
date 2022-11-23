using OOP.Pets;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{


    class Program
    {
        private static List<Animal> pets = new List<Animal>
        {
            new Dog
            {
                Id = 1,
                Height = 150,
                Weight = 25,
                Color = "Black"
            },
            new Cat
            {
                Id = 2,
                Height = 70,
                Weight = 20,
                Color = "Yellow"
            },
            new Pig
            {
                Id = 3,
                Height = 161,
                Weight = 66,
                Color = "Pink"
            },
            new Chicken
            {
                Id = 4,
                Height = 35,
                Color = "Gray",
                Weight = 20
            }
        };
        private static readonly PetController c = new PetController();

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {

                Console.WriteLine("1. Show all:");
                Console.WriteLine("2. Add a pet");
                Console.WriteLine("3. Update a pet");
                Console.WriteLine("4. Delete a pet");
                Console.WriteLine("5. Exit");
                var choice = Input.GetInt();

                switch (choice)
                {
                    case 1:
                        ShowAllPets(pets);
                        break;
                    case 2:
                        AddPet();
                        break;
                    case 3:
                        //UpdatePetById();
                        break;
                    case 4:
                        Console.WriteLine("Delete Pet Id = ");
                        var id = Input.GetInt();
                        c.DeletePetByID(id, pets);
                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("ReInput");
                        break;
                }
            }
        }

        private static void ShowAllPets(List<Animal> pets)
        {
            c.GetAllPets(pets);
        }

        private static void AddPet()
        {
            c.AddPet(pets);
        }
    }
}