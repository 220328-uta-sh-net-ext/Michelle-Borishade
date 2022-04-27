using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBdiningUI
{
        internal class MainMenu : Imenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Mick Fancy Dining Events");
            Console.WriteLine("Sign in as a guest or register for White Glove Service");
            Console.WriteLine("Press <2> for Menu and Wine Selections");
            Console.WriteLine("Press <3> for Music and Show Options");
            Console.WriteLine("Press <4> to request Floor or Balcony Seating");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "2":
                    return "Menu ad Wine Selections";
                case "3":
                    return "Music and Show Options";
                case "4":
                    return "Floor or Balcony Seating";
                default:
                    Console.WriteLine("Please make a selection to continue");
                    Console.ReadLine();
                    return "MainMenu";
            } 
        }
    }
}
