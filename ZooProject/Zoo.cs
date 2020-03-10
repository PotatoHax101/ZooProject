using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    class Zoo
    {
        private string _Name;

        private List<AnimalEnclosure> animalEnclosures;

        public Zoo(string SetName)
        {
            animalEnclosures = new List<AnimalEnclosure>();
            AmphibianEnclosure AxolotlEnclosure = new AmphibianEnclosure("Axolotl Enclosure", 15.0f, 100, 100, 7, 2.0f);

            Name = SetName;
        }

        private string name;
        public string Name 
        {
            get { return name; }
            private set { name = value; }
        }
    }
}
