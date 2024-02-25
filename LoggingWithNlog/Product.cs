using NLog;

namespace LoggingWithNlog
{
    class Product
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
        public Person Owner { get; set; }

        public Product(int productID, string name, string color, int cost, Person owner)
        {
            ProductID = productID;
            Name = name;
            Color = color;
            Cost = cost;
            Owner = owner;

            logger.Debug("Created a product {@product} at {now}", this, DateTime.Now);
        }
    }
}


