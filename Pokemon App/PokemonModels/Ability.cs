using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonModels
{
        public class Ability
        {
            public string Name { get; set; }
            private int _PP; //Pokemon Power
            public int PP
        {
            get { 
                return _PP; 
            }
            set
            {
                if (value > 0)
                    _PP = value;
                else
                    throw new Exception("Must set PP higher than 0");
            }
        }
        public int Power { get; set; }
        public int Accuracy { get; set; }

        public Ability() //Default Constructor is used to assign values to the data members starting 0 and null
        {
            Name = "Tackle";
            PP = 40;
            Power = 40;
            Accuracy = 80;
        }
    }
}
