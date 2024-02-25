using NLog;

namespace LoggingWithNlog
{
    class Program
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            // create 2 persons
            var person1 = new Person(0001,"Serkut", "Yildirim", "address", new DateTime(2024, 02,25));
            var person2 = new Person(0002, "John", "Csharp", "address2", new DateTime(2024, 02, 25));
            // create 2 product
            var product1 = new Product(680, "HL Road Frame", "Purple", 1059, person1);
            var product2 = new Product(790, "Sport-100 Helmet", "Red", 308, person2);
            // logging
            logger.Trace("Some verbose log");
            logger.Debug("Some debug log");
            logger.Info("Person1: {@person}", person1);
            logger.Info("product2: {@product}", product2);
            logger.Warn("Warning accrued at {now}", DateTime.Now);
            logger.Error("Error accrued at {now}", DateTime.Now);
            logger.Fatal("Serious problem with product {@product} accrued at {now}", product1, DateTime.Now);
        }
    }
}



