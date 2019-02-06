using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{   
    class Animal
    {
        private string name;
        private int size;
        private bool meateater;
        public Animal(string Name,int Size,bool Meateater)
        {
            name = Name;
            size = Size;
            meateater = Meateater;
        }
        public string Name()
        {
            return name;
        }

        public int Size()
        {
            return size;
        }

        public bool Meateater()
        {
            return meateater;
        }
    }
}
