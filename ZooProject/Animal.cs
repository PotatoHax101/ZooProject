using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Animal
    {
       public enum StageOfLife
        {
            Newborn = 1,
            Young = 2,
            Old = 3,
            Dying = 4
        }

        protected string name;
        protected int Age;
        protected int Health;
        protected bool LaysEggs;
        protected float Temperature;
        protected int FoodStatus;
        protected string Diet;
        protected bool IsMature;
        protected float[] Dimensions = new float[2];
        protected bool HavingOffspring;
        protected StageOfLife StageofLife;
        protected bool SearchingForMate;
        protected bool HasDisease;
        protected int AmountOfEggs;
        protected int AgeOfFertility;

        public Animal(string Name, int Age)
        {
            this.Age = Age;
            this.Name = name;
            this.Health = 100;
        }

        public Animal(string GeneratedName, int GeneratedAge, bool LaysEggsVal, float GeneratedTemp, string ChosenDiet, int ChosenAgeofFertility, bool ChosenDiseaseStatus, float[] GeneratedDimensions, bool SearchingforMateStatus)
        {
            Name = GeneratedName;
            Age = GeneratedAge;
            StageofLife = (StageOfLife)1; // this will depend on the age as well but we could have an if statement check a passed variable that shows the typical ages and then determine if it is or isn't. An array sounds good for this but it depends on how we want to do this.
            Health = 100;
            LaysEggs = LaysEggsVal;
            Temperature = GeneratedTemp;
            FoodStatus = 5;
            Diet = ChosenDiet;
            IsMature = false;               //We can have an if statement which chooses the maturity depending on the age. For now I'll just leave as false, so that it looks nicer.
            AgeOfFertility = ChosenAgeofFertility;
            HavingOffspring = false;
            Dimensions = GeneratedDimensions;
            HasDisease = ChosenDiseaseStatus;
            AmountOfEggs = 0;

        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {               

                if (value.Length <= 12 && value.Length >= 4)
                {
                    Name = value;
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
                return Temperature;
            }

            protected set
            {
                Temperature = value;
            }
        }

        public int AnimalAge
        {
            get
            {
                return Age;
            }

            protected set
            {
                Age = value;
            }
        }

        public int AnimalFoodStatus
        {
            get
            {
                return FoodStatus;
            }

            set
            {
                FoodStatus = value;
            }

        }

        public string AnimalDiet
        {
            get
            {
                return Diet;
            }

            protected set
            {
                Diet = value;
            }

        }

        public bool AnimalMaturity
        {
            get
            {
                return IsMature;
            }

            protected set
            {
                IsMature = value;
            }
        }
 

        public float CheckDimension(string RequestedDimension) 
        {
            if (RequestedDimension == "Width")
            {
                return Dimensions[1];
            }
            else if (RequestedDimension == "Height")
            {
                return Dimensions[2];
            }
            else
            {
                return Dimensions[3];
            }
        }   

        protected void SetDimension(float[] ChosenDimensionsArray)
        {
            for (int i = 0; i < 2; i++)
            {
                Dimensions[i] = ChosenDimensionsArray[i];
            }
        }

        public bool AnimalPregnancy
        {
            get
            {
                return HavingOffspring;
            }

            protected set
            {
                HavingOffspring = value;
            }
        }

        public StageOfLife AnimalStageOfLife
        {
            get
            {
                return StageofLife;
            }
            
            protected set
            {
                StageofLife = value;
            }
        }

        public bool AnimalMatingSeason
        {
            get
            {
                return SearchingForMate;
            }

            set
            {
                SearchingForMate = value;
            }
        }

        public int AnimalHealth
        {
            get
            {
                return Health;
            }

           protected set
            {
                Health = value;
            }
        }

        public bool AnimalDiseaseStatus
        {
            get
            {
                return HasDisease;
            }

            protected set
            {
                HasDisease = value;
            }
        }

        public int AnimalEggStatus
        {
            get
            {
                return AmountOfEggs;
            }

            protected set
            {
                AmountOfEggs = value;
            }
        }

        public int AnimalsFertileAge
        {
            get
            {
                return AgeOfFertility;
            }

            protected set
            {
                AgeOfFertility = value;
            }
        }

    }
}