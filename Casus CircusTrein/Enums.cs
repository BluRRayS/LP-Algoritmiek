using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    public class Enums
    {
        public int GetSize(int index)
        {
            switch (index)
            {
                case 1:
                    return (int)Sizes.medium;
                case 2:
                    return (int)Sizes.large;
                default:
                    return (int)Sizes.small;
            }
        }

        public enum Diets :int
        {
            herbivore = 0,
            carnivore
        };

        public enum Sizes 
        {
            small = 0,
            medium = 3,
            large = 5
        };
    }
}


       
    

