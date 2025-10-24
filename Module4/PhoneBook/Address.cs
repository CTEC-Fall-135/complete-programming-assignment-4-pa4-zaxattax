using System;

namespace PhoneBook
{
    internal class Address
    {
        // region for properties
        #region Properties
        // automatic properties for address components
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        #endregion

        // region for constructor
        #region Constructor
        // primary constructor to initialize address properties
        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        #endregion

        #region Methods
        // method to print the full address
        public void PrintAddress()
        {
            Console.WriteLine(StreetAddress);
            Console.WriteLine($"{City}, {State} {Zip}");
        }
        #endregion
    }
}