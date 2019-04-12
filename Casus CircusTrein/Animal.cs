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
        public Enums.Sizes Size { get; }
        public Enums.Diets Diet { get; }

        public Animal(string name, Enums.Sizes size, Enums.Diets diet)
        {
            Name = name;
            Size = size;
            Diet = diet;
        }

        public int GetAnimalPoints(Animal animal)
        {
            switch (animal.Size)
            {
                case Enums.Sizes.Small: return 1;
                case Enums.Sizes.Medium: return 3;
                case Enums.Sizes.Large: return 5;
                default: return 1;
            }
        }

        public override string ToString()
        {
            return Name + ":" + Diet + ":" + Size;
        }
    }
}
