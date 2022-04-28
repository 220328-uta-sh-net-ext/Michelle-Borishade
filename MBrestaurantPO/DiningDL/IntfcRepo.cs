using System.Collections.Generic;
using DiningModels;

namespace DiningDL
{
    public interface IntfcRepo
    {
        Menu AddMenu(Menu dinner); //enables to add item(s) to Json and returns as name="dinner x"
        List<Menu> GetAllMenu(); //enables to add all choices to Json and returns collection as Generic list
        List<Menu> GetAllMenu();
    }
}
