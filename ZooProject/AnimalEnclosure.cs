using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class AnimalEnclosure
    {
        private float _Temperature, _BiodiversityIndex;
        private int _Population, _FoodLevel;
        private string _Name, _FoodSupplyType, HabitatType, TerrianType;
        private bool _FoodFilled;
        private List<string> _AnimalList = new List<string>();
        private string[] _Environment = new string[4];

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
        

        private void hello(string animal)
        {
            Console.WriteLine("The animal " + animal + " has been removed to the Animal Enclosure '" + _Name + "'!");
            _AnimalList.Remove(animal);
        }
    }
}
