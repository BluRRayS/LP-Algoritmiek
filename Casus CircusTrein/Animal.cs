using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    internal class Animal
    {
        public string Name { get; }
        public int Size { get; }
        public int Diet { get; }

        public Animal(string name, Enums.Sizes size, Enums.Diets diet)
        {
            Name = name;
            Size = (int) size;
            Diet = (int) diet;
        }

        public override string ToString()
        {
            return Name + ":" + Diet + ":" + Size;
        }
    }
}
