using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal abstract class Entity
    {
        // region for properties
        #region Properties
        // automatic properties for address and phone number
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        // region for constructor
        #region Constructor
        // primary constructor to initialize address and phone number
        public Entity(string streetAddress, string city, string state, string zip, string phoneNumber)
        {
            Address = new Address(streetAddress, city, state, zip);
            PhoneNumber = phoneNumber;
        }
        #endregion

        // region for methods
        #region Methods
        // abstract method to print entity details
        public abstract void PrintEntity();
        #endregion
    }
    internal class Business : Entity
    {
        // region for properties
        #region Properties
        // automatic property for business name
        public string BusinessName { get; set; }
        #endregion

        // region for constructor
        #region Constructor
        // primary constructor to initialize business properties
        public Business(string streetAddress, string city, string state, string zip, string phoneNumber, string businessName)
            : base(streetAddress, city, state, zip, phoneNumber)
        {
            BusinessName = businessName;
        }
        #endregion

        // region for methods
        #region Methods
        // override method to print business details
        public override void PrintEntity()
        {
            Console.WriteLine(BusinessName);
            Address.PrintAddress();
            Console.WriteLine(PhoneNumber);
        }
        #endregion
    }
    internal class Person : Entity
    {
        // region for properties
        #region Properties
        // automatic properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        // region for constructor
        #region Constructor
        // primary constructor to initialize person properties
        public Person(string streetAddress, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
            : base(streetAddress, city, state, zip, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        // region for methods
        #region Methods
        // override method to print person details
        public override void PrintEntity()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Address.PrintAddress();
            Console.WriteLine(PhoneNumber);
        }
        #endregion
    }
}
