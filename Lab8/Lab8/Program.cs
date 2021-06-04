using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Display(string message) 
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            float weight;
            float height;
            int normalAmountOfFood;
            string name;
            string input;
            int number;
            string numberPet;
            string coatColor = "Black";
            string eyesColor = "Green";
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter your pet's weight: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.WriteLine("Enter your pet's height: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out height));
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the amount of food your pet consumes daily: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out normalAmountOfFood));
            Pet pet = new Pet(name, weight, height, normalAmountOfFood);
            do
            {
                Console.Clear();
                Console.WriteLine("Select an animal:\n" +
                    "1. Hamster\n" +
                    "2. Dog\n");
                numberPet = Console.ReadLine();
            } while (numberPet != "1" && numberPet != "2");
            if (numberPet == "1") pet = new Hamster(name, weight, height, normalAmountOfFood, coatColor);
            else if (numberPet == "2") pet = new Dog(name, weight, height, normalAmountOfFood, eyesColor);
            pet.RegisterSatietyHandler(Display);
            while (true)
            {
                do
                {
                    Console.WriteLine("Select an action:\n" +
                        "1. Display information\n" +
                        "2. Show status\n" +
                        "3. Feed them\n" +
                        "4. Hunt\n" +
                        "5. Pat it\n" +
                        "6. Sleep\n" +
                        "7. Compare animals");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number < 1 || number > 7));
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
                        pet.Doing += Display;
                        pet.Done += Display;
                        pet.Feel();
                        break;
                    case 4:
                        pet.Doing += new StateHandler (Display);
                        
                        pet.Done += new StateHandler (Display);
                        pet.Hunt();
                        break;
                    case 5:
                       
                        pet.Caress();
                        break;
                    case 6:
                        
                        pet.Drowsiness();
                        break;
                    case 7:
                        List<BodyData> dic = new List<BodyData>();
                        dic.Add(new BodyData(name, weight, height, normalAmountOfFood));
                        dic.Add(new BodyData("Charlie", 9, 10, 1));
                        dic.Add(new BodyData("Poppy ", 8, 12, 2));
                        dic.Add(new BodyData("Lola", 11, 9, 1));
                        dic.Add(new BodyData("Max", 10, 8, 1));
                        dic.Add(new BodyData("Teddy", 7, 13, 1));
                        Console.WriteLine("Animals: ");
                        foreach (BodyData i in dic)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Sorted by weight: ");
                        dic.Sort();
                        foreach (BodyData i in dic)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
