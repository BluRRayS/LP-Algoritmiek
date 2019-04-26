using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    public class Animal
    {
        public string Name { get; }
        public Enums.Size Size { get; }
        public Enums.Diet Diet { get; }

        public Animal(string name, Enums.Size size, Enums.Diet diet)
        {
            Name = name;
            Size = size;
            Diet = diet;
        }

        public int GetAnimalPoints(Animal animal)
        {
            switch (animal.Size)
            {
                case Enums.Size.Small: return 1;
                case Enums.Size.Medium: return 3;
                case Enums.Size.Large: return 5;
                default: return 1;
            }
        }

        public override string ToString()
        {
            return Name + ":" + Diet + ":" + Size;
        }
    }
}
