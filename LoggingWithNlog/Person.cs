using NLog;

namespace LoggingWithNlog
{
    class Person
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(int personID, string firstName, string lastName, string address, DateTime dateOfBirth)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;

            logger.Info("Created a person {@person} at {now}", this, DateTime.Now);
        }
    }
}

