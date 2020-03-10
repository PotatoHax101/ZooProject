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
 

        public void CheckDimension() //Dimension stuff must be remade as an array instead. For now it can remain as this but it would be better to prepare it for use just incase it is ever decided to need it.
        {
            Console.WriteLine("The Height is " + _Height + "The Width is " + _Width + "The Length is " + _Length);
        }   

        private void SetDimension(float ChosenHeight, float ChosenWidth, float ChosenLength)
        {
            _Height = ChosenHeight;
            _Width = ChosenWidth;
            _Length = ChosenLength;
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
