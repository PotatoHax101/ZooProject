﻿using System;
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
        private int _StageofLife;
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

        private void SetDiet(string ChosenDiet)
        {
            _Diet = ChosenDiet;
        }

        public bool CheckMaturity()
        {
            return _IsMature;
        }

        private void UpdateMaturity(bool MaturityChange)
        {
            _IsMature = MaturityChange;
        }

        public void CheckDimension()
        {
            Console.WriteLine("The Height is " + _Height);
            Console.WriteLine("The Width is " + _Width);
            Console.WriteLine("The Length is " + _Length);
        }

        private void SetDimension(float ChosenHeight, float ChosenWidth, float ChosenLength)
        {
            _Height = ChosenHeight;
            _Width = ChosenWidth;
            _Length = ChosenLength;
        }

        public bool CheckHavingOffspring()
        {
            return _HavingOffspring;
        }

        private void SetHavingOffspring(bool HavingOffspringUpdate)
        {
            _HavingOffspring = HavingOffspringUpdate;
        }

        public int CheckStageofLife()
        {
            return _StageofLife;
        }

        private void SetStageofLife(int StageUpdate)
        {
            _StageofLife = StageUpdate;
        }

        public bool CheckSearchingForMate()
        {
            return _SearchingForMate;
        }

        private void SetSearchingForMate(bool SearchingForMateUpdate)
        {
            _SearchingForMate = SearchingForMateUpdate;
        }

        public int CheckHealth()
        {
            return _Health;
        }

        private void SetHealth(int HealthUpdate)
        {
            _Health = HealthUpdate;
        }



    }
}
