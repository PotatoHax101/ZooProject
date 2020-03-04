using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class AnimalEnclosure
    {
        public float _Temperature, _BiodiversityIndex;
        public int _Population, _FoodLevel, N, n, D;
        public string _Name,_FoodSupplyType, HabitatType, TerrianType;
        public bool _FoodFilled;
        public List<string> _AnimalList = new List<string>();
        public string[] _Environment = new string[4];


        public void GetName()
        {
            Console.WriteLine(_Name);
        }

        private void SetName(string name)
        {
            _Name = name;
        }

        public float CheckTemperature()
        {
            return _Temperature;
        }

        private void SetTemperatire(float NewTemperature)
        {
            Console.WriteLine("Temperature has been changed from " + _Temperature + " to " + NewTemperature + ".");
            _Temperature = NewTemperature;
        }

        public int CheckFoodLevel()
        {
            return _FoodLevel;
        }

        private void SetFoodLevel(int NewFoodLevel)
        {
            Console.WriteLine("Food level has been changed from " + _FoodLevel + " to " + NewFoodLevel + ".");
            _FoodLevel = NewFoodLevel;
        }

        public List<string> CheckAnimals()
        {
            return _AnimalList;
        }

        private void AddAnimals(string animal)
        {
            Console.WriteLine("The animal " + animal + " has been added to the Animal Enclosure '" + _Name + "'!");
            _AnimalList.Add(animal);
        }

        private void RemoveAnimals(string animal)
        {
            Console.WriteLine("The animal " + animal + " has been removed to the Animal Enclosure '" + _Name + "'!");
            _AnimalList.Remove(animal);
        }

        public int CheckPopulation()
        {
            return _Population;
        }

        private void SetPopulation(int number)
        {
            Console.WriteLine("The population has been increased by " + number);
            _Population += number;
        }

        public float CheckBiodiversity()
        {
            return _BiodiversityIndex;
        }

        private void CalculateBiodiversity()
        {
            //Come back to this
        }

        public void GetEnvironment()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(_Environment[i]);
            }
        }
    }

    class AmphibianEnclosure: AnimalEnclosure
    {
        private int _FilterHealth;
        private int _CleanPeriod;
        private List<string> _UnderwaterCosmetics = new List<string>();
        private float _WaterFlow;

        public AmphibianEnclosure(string Name)
        {
            _Name = Name;
        }

        public int CheckFilterHealth()
        {
            return _FilterHealth;
        }

        public int GetCleanPeriod()
        {
            return _CleanPeriod;
        }

        public void CheckUnderwaterCosmetics()
        {
            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine(_UnderwaterCosmetics[i]);
            }
        }

        public float CheckWaterFlow()
        {
            return _WaterFlow;
        }

        private void SetFilterHealth(int NewHealth)
        {
            _FilterHealth = NewHealth;
        }

        public void ChangeCleanPeriod(int NewPeriod)
        {
            _CleanPeriod = NewPeriod;
        }

        public void AddUnderWaterCosmetic(string CosmeticName)
        {
            _UnderwaterCosmetics.Add(CosmeticName);
        }
        public void RemoveUnderWaterCosmetic(string CosmeticName)
        {
            _UnderwaterCosmetics.Remove(CosmeticName);
        }

        public void SetWaterFlow(int NewFlow)
        {
            _WaterFlow = NewFlow;
        }
    }
}
