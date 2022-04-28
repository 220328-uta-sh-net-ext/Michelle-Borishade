using System.Collections.Generic;
using System.IO;
using DiningModels;

namespace DiningDL
{
    public class DoRepo : IntfcRepo
    {
        private string filePath = "..DiningDL/Database";  //place to store db details
        private string jsonString;
        public Menu AddMenu(Menu dinner)
        {
            throw new System.NotImplementedException();
        }

        List<Menu> IntfcRepo.GetAllMenu()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Menu.Json");
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Console.WriteLine("Please check the path " + ex.Message);
            }

            Menu IntfcRepo.AddMenu(Menu dinner)
        {
                throw new System.NotImplementedException();
            }

            List<Menu> IntfcRepo.GetAllMenu()
        
        }
    }
}
