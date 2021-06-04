using System;

namespace ConsoleApp1
{
    delegate void StateHandler(string message);
    class Pet : BodyData
    {
        public event StateHandler Done;
        public event StateHandler Doing;
        StateHandler _del;
        public void RegisterSatietyHandler(StateHandler del) 
        {
            _del = del;
        }
        public virtual void ShowInformation()
        {
            Console.Write("Name: {0}\n" +
                "Weight: {1} kg\n" +
                "Height: {2} cm\n" +
                "Daily food intake rate: {3}\n",
                Name, Weight, Height, NormalAmountOfFood);
        }
        private int satiety = 0;
        public int Satiety
        {
            get { return satiety; }
            set
            {
                if (value == 105 || value == 110)
                {
                    if (Done != null)
                        Done("The pet is not hungry");
                }
                else if (value < 0)
                {
                    if (Doing != null)
                        Doing("The pet is hungry");
                }
                else
                {
                    if (Doing != null)
                        Doing("You have fed your pet");
                    satiety = value;
                }
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
                    if (Done != null)
                         Done("The pet's energy is overflowing");
                }
                else
                {
                    if (Doing != null)
                        Doing("You change the pet's energy state");
                    energy = value; 
                }
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
                    if (Done != null)
                        Done("The pet is happy");
                }
                else
                {
                    if (Doing != null)
                        Doing("You have changed the emotional state of your pet");
                    happiness = value;
                }
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
                    if (Done != null)
                        Done("Pet wants to sleep");
                }
                else
                {
                    if (Doing != null)
                        Doing("The pet has a reserve of cheerfulness");
                    sleep = value;
                }
            }
        }
        public Pet(string name, float weight, float height, int normalAmountOfFood) : base(name, weight, height, normalAmountOfFood) { }
        public virtual void Feel()
        {
            Console.WriteLine("Satiety level: " + Satiety + " out of  100");
        }
        public virtual void Hunt()
        {
            Console.WriteLine("Energy level" + Energy + " out of 100");
        }
        public virtual void Caress()
        {
            Console.WriteLine("Happiness level: " + Happiness + " out of 100");
        }
        public virtual void Drowsiness()
        {
            Console.WriteLine("Sleep level: " + Sleep + " out of 100");
        }
        public void StateInformation()
        {
            Console.WriteLine("Satiety level: " + Satiety + " out of 100");
            Console.WriteLine("Energy level:" + Energy + " out of 100");
            Console.WriteLine("Happiness level: " + Happiness + " out of 100");
            Console.WriteLine("Sleep level: " + Sleep + " out of 100");
        }
    }
}