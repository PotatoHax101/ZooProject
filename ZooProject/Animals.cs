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
        private float[] _Dimensions = new float[2];
        private bool _HavingOffspring;
        private int _StageofLife;
        private bool _SearchingForMate;
        private bool _HasDisease;
        private int _AmountOfEggs;
        private int _AgeOfFertility;

        public Animals(string GeneratedName, int GeneratedAge, bool LaysEggsVal, float GeneratedTemp, string ChosenDiet, int ChosenAgeofFertility, bool ChosenDiseaseStatus, float[] GeneratedDimensions, bool SearchingforMateStatus)
        {
            _Name = GeneratedName;
            _Age = GeneratedAge;
            _StageofLife = 1; // this will depend on the age as well but we could have an if statement check a passed variable that shows the typical ages and then determine if it is or isn't. An array sounds good for this but it depends on how we want to do this.
            _Health = 100;
            for (int i = 0; i < 2; i++)
            {
                _Dimensions[i] = GeneratedDimensions[i];
            }
            _LaysEggs = LaysEggsVal;
            _Temperature = GeneratedTemp;
            _FoodStatus = 5;
            _Diet = ChosenDiet;
            _IsMature = false; //We can have an if statement which chooses the maturity depending on the age. For now I'll just leave as false, so that it looks nicer.
            _AgeOfFertility = ChosenAgeofFertility;
            _HavingOffspring = false; //I don't know if we want it to start with this as a possible true or it should start off as a no for everyone, it also should be an if statement of other variables.
            if (_Age == _AgeOfFertility)
            {
                _SearchingForMate = SearchingforMateStatus;
            }
            else
            {
                _SearchingForMate = false;
            }
            _HasDisease = ChosenDiseaseStatus;
            _AmountOfEggs = 0;

        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {               

                if (value.Length <= 12 && value.Length >= 4)
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("The Name needs to be between 4 and 12 characters");
                }
            }
        }

        public float AnimalTemperature
        {
            get
            {
                return _Temperature;
            }

            private set
            {
                _Temperature = value;
            }
        }

        public int AnimalAge
        {
            get
            {
                return _Age;
            }

            private set
            {
                _Age = value;
            }
        }

        public int AnimalFoodStatus
        {
            get
            {
                return _FoodStatus;
            }

            set
            {
                _FoodStatus = value;
            }

        }

        public string AnimalDiet
        {
            get
            {
                return _Diet;
            }

            private set
            {
                _Diet = value;
            }

        }

        public bool AnimalMaturity
        {
            get
            {
                return _IsMature;
            }

            private set
            {
                _IsMature = value;
            }
        }
 

        public float CheckDimension(string RequestedDimension) 
        {
            if (RequestedDimension == "Width")
            {
                return _Dimensions[1];
            }
            else if (RequestedDimension == "Height")
            {
                return _Dimensions[2];
            }
            else
            {
                return _Dimensions[3];
            }
        }   

        private void SetDimension(float[] ChosenDimensionsArray)
        {
            for (int i = 0; i < 2; i++)
            {
                _Dimensions[i] = ChosenDimensionsArray[i];
            }
        }

        public bool AnimalPregnancy
        {
            get
            {
                return _HavingOffspring;
            }

            private set
            {
                _HavingOffspring = value;
            }
        }

        public int AnimalStageOfLife
        {
            get
            {
                return _StageofLife;
            }
            
            private set
            {
                _StageofLife = value;
            }
        }

        public bool AnimalMatingSeason
        {
            get
            {
                return _SearchingForMate;
            }

            set
            {
                _SearchingForMate = value;
            }
        }

        public int AnimalHealth
        {
            get
            {
                return _Health;
            }

           private set
            {
                _Health = value;
            }
        }

        public bool AnimalDiseaseStatus
        {
            get
            {
                return _HasDisease;
            }

            private set
            {
                _HasDisease = value;
            }
        }

        public int AnimalEggStatus
        {
            get
            {
                return _AmountOfEggs;
            }

            private set
            {
                _AmountOfEggs = value;
            }
        }

        public int AnimalsFertileAge
        {
            get
            {
                return _AgeOfFertility;
            }

            private set
            {
                _AgeOfFertility = value;
            }
        }

    }
}