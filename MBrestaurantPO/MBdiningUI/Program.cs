using MBdiningUI;


bool repeat = true;
Imenu menu = new MainMenu();
menu.Display();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice(); //to return output in string format

    switch (ans)
    {
        case "MenuandWineSelections":   //calling the method from MainMenu.cs
            break;
        case "Music and Show Options":
            break;
        case "Floor or Balcony Seatinng":
            menu = new MainMenu();
            Console.WriteLine("Please check in at the Chandelier Room upon arrival");
            break;
        
        
        default:
            Console.WriteLine("Please make a selection to continue")
            Console.ReadLine();
            break;

    }
}
