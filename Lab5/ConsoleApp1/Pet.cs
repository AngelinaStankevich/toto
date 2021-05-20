using System;

namespace ConsoleApp1
{
    class Pet:Animal
    {
        private int satiety = 0;
        public int Satiety
        {
            get { return satiety; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("The pet is not hungry");
                }
                else satiety = value;
            }
        }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("The pet's energy is overflowing");
                }
                else energy = value;
            }
        }
        private int happiness = 0;
        public int Happiness
        {
            get { return happiness; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("The pet is happy");
                }
                else happiness = value;
            }
        }
        private int sleep = 0;
        public int Sleep
        {
            get { return sleep; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Pet wants to sleep");
                }
                else sleep = value;
            }
        }
        public Pet() { }
        public Pet(float weight, float height, int normalAmountOfFood) : base(weight, height, normalAmountOfFood) { }
        public virtual void Feel()
        {
            Console.WriteLine("Satiety level: " + Satiety + " out of 100");
        }
        public virtual void Hunt()
        {
            Console.WriteLine("Energy level " + Energy + " out of 100");
        }
        public virtual void Caress()
        {
            Console.WriteLine("Happiness level: " + Happiness + " out of 100");
        }
        public virtual void Drowsiness()
        {
            Console.WriteLine("Sleepiness level: " + Sleep + " out of 100");
        }
        public void StateInformation()
        {
            Console.WriteLine("Satiety level: " + Satiety + " out of 100");
            Console.WriteLine("Energy level " + Energy + " out of 100");
            Console.WriteLine("Happiness level: " + Happiness + " out of 100");
            Console.WriteLine("Sleepiness level: " + Sleep + " out of 100");
        }
    }
}
