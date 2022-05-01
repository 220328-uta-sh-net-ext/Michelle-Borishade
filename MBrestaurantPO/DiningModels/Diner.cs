namespace DiningModels
{
    public class Diner
    {
        public string User { get; set; }
        public int Restaurant { get; set; }
        public decimal Reviews { get; set; }
        public int RsvpTable { get; set; }


        //combo menu 3 options
        public List<Menu> _menus;
        private readonly string Client;

        public List<Menu> Menus
        {
            get { return _menus; }
            set
            {
                if (value.Count > 3)
                    _menus = value;
                else
                    throw new Exception("Please select 1, 2, or 3");
            }
        }
        //Default constructor to add default values to the properties
        public Diner() 
        {
            RsvpTable = 7;
            User = "Client";
            Restaurant = 8;
            Reviews = 80;
            _menus = new List<Menu>();
            
                
            new Menu();
        }
    public override string ToString()
    {
        return base.ToString();
        {
            return $"Entree: {Entree}\nUser: {User}\nRestaurant: {Restaurant}\nReviews: {Reviews}\nRsvpTable: {RsvpTable}";
        }

    }
    }
}

