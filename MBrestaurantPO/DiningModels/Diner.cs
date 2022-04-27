namespace DiningModels
{
    public class Diner
    {
        public string User { get; set; }
        public string Restaurant { get; set; }
        public decimal Reviews { get; set; }
        public int RsvpTable { get; set; }

        
        //combo menu 3 options
        private List<Menu> _menus;
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
        public int RsvpTable()
        {
            Entree = "Sides";
            User = 1;
            Restaurant = 34;
            Reviews = _4;
            _menus = new List<Menu>()
            {
                new Menu(),
            }
        }
        public override string ToString()
        {
            return base.ToString()
              {
                return $"Entree: {Entree}\nUser: {User}\nRestaurant: {Restaurant}\nReviews: {Reviews}\nRsvpTable: {RsvpTable}";
              }
           
        }

    }
}