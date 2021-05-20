using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight;
            float height;
            int normalAmountOfFood;
            string input;
            int number;
            string numberPet;
            string coatColor = "Black";
            string eyesColor = "Green";
            do
            {
                Console.WriteLine("Enter the weight of the animal: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.WriteLine("Enter the height of the animal: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out height));
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the amount of food consumed by the animal daily: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out normalAmountOfFood));
            Pet pet = new Cat(weight, height, normalAmountOfFood, coatColor);
            do
            {
                Console.Clear();
                Console.WriteLine("Select an animal:\n" +
                    "1. Hamster\n" +
                    "2. Dog\n");
                numberPet = Console.ReadLine();
            } while (numberPet != "1" && numberPet != "2");
            if (numberPet == "1") pet = new Hamster(weight, height, normalAmountOfFood, coatColor);
            else if (numberPet == "2") pet = new Dog(weight, height, normalAmountOfFood, eyesColor);
            while (true)
            {
                do
                {
                    Console.WriteLine("Choose an action:\n" +
                        "1. Display information\n" +
                        "2. Show status\n" +
                        "3. Feed them\n" +
                        "4. Hunt\n" +
                        "5. Pat it\n" +
                        "6. Sleep");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number <1 || number>6));
                Console.Clear();
                switch (number)
                {
                    case 1:
                        pet.ShowInformation();
                        break;
                    case 2:
                        pet.StateInformation();
                        break;
                    case 3:
                        pet.Feel();
                        break;
                    case 4:
                        pet.Hunt();
                        break;
                    case 5:
                        pet.Caress();
                        break;
                    case 6:
                        pet.Drowsiness();
                        break;
                }
            }
        }
    }
}
