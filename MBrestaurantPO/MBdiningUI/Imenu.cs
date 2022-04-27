using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBdiningUI
{
    //interface is best way to implement abstraction
    //every interface method is implicitly abstract so no need to define; and also default keyword is public
    public interface Imenu
    {
    //will display the menu and user choices 
        void Display();

        //will return user's choice and change accordingly
        string UserChoice();
    }
}
