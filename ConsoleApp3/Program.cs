using System;

namespace AnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            NewAnimal a = new NewAnimal();
            a.name = "lion";
            a.description = "a very big and hungry cat";
            a.location = "lives in Africa";
            a.height = 1.0;//meters
            a.weight = 200;//kg

                       
        }
    }

        public class NewAnimal
    {
        public string name;
        public string description;
        public string location;
        public double height;
        public int weight;
        

        public void CanRun()
        {
            Console.WriteLine("This animal can run");
        }
        public void NeedToEat()
        {
            Console.WriteLine("This animal needs to eat");
        }
        public void NeedToSleep()
        {
            Console.WriteLine("This animal needs to sleep");
        }

        

    }

}
