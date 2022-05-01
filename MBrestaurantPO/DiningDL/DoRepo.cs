using System.Collections.Generic;
using System.IO;
using System.Data;
using DiningModels;

namespace DiningDL
{
    public class DoRepo : IntfcRepo
            {
        readonly string filePath = "C:/Users/mbori/Desktop/Michelle/Revature/GIT/Michelle-Borishade/MBrestaurantPO";
           // "../../../..RestaurantDL/sensitive.txt";  //place to store db details
        private string jsonString;
        public Menu AddMenu(Menu dinner)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// This will take my code and run it through the server via Azure
        /// </summary>
        List<Menu> IntfcRepo GetAllMenu()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Menu.Json");
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Console.WriteLine("Please check the path " + ex.Message);
            }
        }
            //public Menu AddMenu(Menu dinner)
        
               // throw new System.NotImplementedException();
            
            // List<Menu> IntfcRepo.GetAllMenu()
        
        }
    }

