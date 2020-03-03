using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Animals
    {
        private string _Name;
        private int _Age;
        private int _Health;
        private bool _LaysEggs;
        private float _Temperature;
        private int _FoodStatus;
        private string _Diet;
        private bool _IsMature;
        private float _Length;
        private float _Width;
        private float _Height;
        private bool _HavingOffspring;
        private Enum _StageOfLife;
        private bool _SearchingForMate;
        private bool _HasDisease;
        private int _AmountOfEggs;
        private int _AgeOfFertility;

        public Animals(string GeneratedName, int GeneratedAge, bool LaysEggsVal)
        {
            _Name = GeneratedName;
            _Age = GeneratedAge;
            _Health = 100;
            _LaysEggs = LaysEggsVal;


        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string ChosenName)
        {
            if (ChosenName.Length <= 12 && ChosenName.Length >= 4)
            {
                _Name = ChosenName;
            }
            else
            {
                Console.WriteLine("The Name needs to be between 4 and 12 characters");
            }

            
        }


        public float CheckTemperature()
        {
            return _Temperature;
        }    

        private void SetTemperature(float ChosenTemperature)
        {
            _Temperature = ChosenTemperature;
        }

        public int GetAge()
        {
            return _Age;
        }

        private void SetAge(int ChosenAge)
        {
            _Age = ChosenAge;
        }

        public int CheckFoodStatus()
        {
            return _FoodStatus;
        }

        private void SetFoodStatus(int ChosenStatus)
        {
            _FoodStatus = ChosenStatus;
        }

        public string CheckDiet()
        {
            return _Diet;
        }

    }
}
