global using Serilog;
using MBdiningUI;

Log.Logger = (ILogger)new LoggerConfiguration()
    .WriteTo.File("./Logs/user.txt");
    CreateLogger();

void CreateLogger()
{
    throw new NotImplementedException();
}

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
            Log.Debug("Displaying option menu to the user");
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
            Log.Error("cannot inherit this class");
            break;

    }
}
