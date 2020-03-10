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
        protected List<Animals> AnimalList = new List<Animals>();
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

        public List<Animals> CheckAnimals()
        {
            return AnimalList;
        }

        protected void AddAnimals(Animals animal)
        {
            Console.WriteLine("The animal " + animal + " has been added to the Animal Enclosure '" + Name + "'!");
            AnimalList.Add(animal);
        }

        protected void RemoveAnimals(Animals animal)
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

    class AmphibianEnclosure: AnimalEnclosure
    {
        private int filterHealth, cleanPeriod;
        private List<string> underwaterCosmetics = new List<string>();
        private float waterFlow;

        public int FilterHealth
        {
            get { return filterHealth; }
            private set { filterHealth = value; }
        }

        public int GetCleanPeriod
        {
            get { return cleanPeriod; }
            private set { cleanPeriod = value; }
        }

        public float WaterFlow
        {
            get { return waterFlow; }
            private set { waterFlow = value; }
        }

        public AmphibianEnclosure(string NewName, float Temp, int SetFoodLevel, int fhealth, int cdelta, float flow)
        {
            Name = NewName;
            EnclosureTemperature = Temp;
            FoodLevel = SetFoodLevel;
            HabitatType = "Amphibian";
            TerrainType = "Riverside";
            filterHealth = fhealth;
            cleanPeriod = cdelta;
            waterFlow = flow;
        }

        public void CheckUnderwaterCosmetics()
        {
            foreach (string underwateItem in underwaterCosmetics)
            {
                Console.WriteLine(underwateItem);
            }
        }

        public void AddUnderWaterCosmetic(string CosmeticName)
        {
            underwaterCosmetics.Add(CosmeticName);
        }
        public void RemoveUnderWaterCosmetic(string CosmeticName)
        {
            underwaterCosmetics.Remove(CosmeticName);
        }
    }
}
