using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{   
    class Animal
    {
        public string Name { get; }
        public int Size { get; }
        public int Diet { get; }

        public Animal(string Name,int Size,int Diet)
        {
            this.Name = Name;
            this.Size = Size;
            this.Diet = Diet;
        }
        //public string Name()
        //{
        //    return name;
        //}

        //public int Size()
        //{
        //    return size;
        //}

        //public int Meatater()
        //{
        //    return diet;
        //}

        public override string ToString()
        {
            return Name+":"+Diet+":"+Size;
        }
    }
}
