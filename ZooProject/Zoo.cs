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

        private AnimalEnclosure selectedEnclosure;

        public Zoo(string SetName)
        {
            animalEnclosures = new List<AnimalEnclosure>();
            AmphibianEnclosure AxolotlEnclosure = new AmphibianEnclosure("Axolotl Enclosure", 15.0f, 100, 100, 7, 2.0f);

            Name = SetName;
        }



        public void SelectEnclosure()
        {

        }

        public void AddAnimal(Animal animal)
        {
            selectedEnclosure.AddAnimal(animal);
        }

        private string name;
        public string Name 
        {
            get { return name; }
            private set { name = value; }
        }
    }
}
