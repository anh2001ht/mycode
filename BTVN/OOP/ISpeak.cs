using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{


    class Program
    {
        private static List<Animal> pets = new List<Animal>
        {
            new Cat
            {
                Id = 1,
                Height = 50,
                Weight = 5,
                Color = "Yellow"
            },
            new Dog
            {
                Id = 2,
                Height = 70,
                Weight = 20,
                Color = "Black"
            },
            new Chicken
            {
                Id = 3,
                Height = 61,
                Weight = 3,
                Color = "White"
            },
            new Pig
            {
                Id = 4,
                Height = 65,
                Color = "Pink",
                Weight = 40
            }
        };
        private static readonly PetRepository petRepository = new PetRepository();

        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                
                Console.WriteLine("1. Show all:");
                Console.WriteLine("2. Add a pet");
                Console.WriteLine("3. Update a pet");
                Console.WriteLine("4. Delete a");
                Console.WriteLine("5. Exit");
                var choice = UserInput.GetInt("Enter your choice here: ");

                switch (choice)
                {
                    case 1:
                        ShowAllPets(pets);
                        break;
                    case 2:
                        AddPet();
                        break;
                    case 3:
                        UpdatePet();
                        break;
                    case 4:
                        Delete();
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
            petRepository.GetAll(pets);
        }

        private static void AddPet()
        {
            petRepository.Add(pets);
        }

        private static void UpdatePet()
        {
            //Update
            var id = UserInput.GetInt("Nhap pet's id can update: ");

            var height = UserInput.GetDouble("Nhap height moi (cm): ");
            var weight = UserInput.GetDouble("Nhap weight moi (kg): ");
            var color = UserInput.GetString("Nhap color moi: ");

            petRepository.UpdateById(pets, id, height, weight, color);
        }

        private static void Delete()
        {
            var id = UserInput.GetInt("Nhap pet's id can delete: ");
            petRepository.Delete(pets, id);
        }

        
    }
}