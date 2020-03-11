using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class AnimalEnclosure
    {
        protected float BiodiversityIndex;
        protected string FoodSupplyType, HabitatType, TerrainType;
        protected string[] Environment = new string[4];
        protected List<Animal> AnimalList = new List<Animal>();
        protected readonly int MaxFood = 100;

        public string Name { get; set; }

        private float temperature;
        public float EnclosureTemperature
        {
            get { return temperature; }
            protected set 
            {
                Console.WriteLine("Temperature has been changed from " + temperature + " to " + value + ".");
                temperature = value; 
            }
        }

        private int food;
        public int FoodLevel
        {
            get { return food; }
            protected set 
            {
                Console.WriteLine("Food level has been changed from " + food + " to " + value + ".");
                food = value; 
            }
        }

        // -a reference for how to use properties-
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public List<Animal> CheckAnimals()
        {
            return AnimalList;
        }

        protected void AddAnimals(Animal animal)
        {
            Console.WriteLine("The animal " + animal + " has been added to the Animal Enclosure '" + Name + "'!");
            AnimalList.Add(animal);
        }

        protected void RemoveAnimals(Animal animal)
        {
            Console.WriteLine("The animal " + animal + " has been removed to the Animal Enclosure '" + Name + "'!");
            AnimalList.Remove(animal);
        }

        private int population;
        public int Population
        {
            get { return population; }
            protected set
            {
                Console.WriteLine("The population has been been offset by " + value + "; moving from " + population + " to " + (population + value) + ".");
                population += value;
            }
        }

        public float CheckBiodiversity()
        {
            return BiodiversityIndex;
        }

        protected void CalculateBiodiversity()
        {
            //Come back to this
        }

        public void GetEnvironment()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(Environment[i]);
            }
        }

        protected bool IsFoodFilled(int FoodLevel)
        {
            if (FoodLevel >= MaxFood)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}