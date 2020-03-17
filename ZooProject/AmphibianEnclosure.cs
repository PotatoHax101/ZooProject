using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class AmphibianEnclosure : AnimalEnclosure
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
