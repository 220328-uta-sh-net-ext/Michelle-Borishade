using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningModels
{
    public class Menu
    {
        public string Entree { get; set; }
        private int _combo1;
        public int Combo1
        {
            get { 
                 return _combo1;
            }
            set
            {
                if (value > 3)
                    _combo1 = value;
                else
                    throw new Exception("Please select entree 1, 2, or 3");
            }
        }
        public int Combo2 { get; set; }
        public int Combo3 { get; set; }
        
        public Menu()
        {
            Entree = "KingsFeast";
            Combo1 = 1;
            Combo2 = 2;
            Combo3 = 3;
        }
    }
}