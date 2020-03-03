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

        public Zoo(string name)
        {
            SetName(name);
        }

        public string GetName()
        {
            return _Name;
        }

        private void SetName(string name)
        {
            _Name = name;
            Console.WriteLine("The name of the zoo is " + _Name + "!");
        }
    }
}
