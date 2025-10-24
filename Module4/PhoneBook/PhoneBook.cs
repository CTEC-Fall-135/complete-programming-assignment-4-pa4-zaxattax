using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        // region for fields
        #region Fields
        // array to hold entities in the phonebook
        private Entity[] entities;
        #endregion

        // region for constructor
        #region Constructor
        // primary constructor to initialize the entities array
        public PhoneBook()
        {
            entities = new Entity[10];
        }
        #endregion

        // region for methods
        #region Methods
        // add a generic entity to the phonebook
        public void AddEntity(Entity entity)
        {
            for (int i = 0; i < entities.Length; i++)
            {
                if (entities[i] == null)
                {
                    entities[i] = entity;
                    break;
                }
            }
        }

        // add a business entity by creating it and calling AddEntity
        public void AddBusinessEntity(string streetAddress, string city, string state, string zip, string phoneNumber, string businessName)
        {
            Business business = new Business(streetAddress, city, state, zip, phoneNumber, businessName);
            AddEntity(business);
        }

        // add a person entity by creating it and calling AddEntity
        public void AddPersonEntity(string streetAddress, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
        {
            Person person = new Person(streetAddress, city, state, zip, phoneNumber, firstName, lastName);
            AddEntity(person);
        }

        // print all non-null entities in the phonebook
        public void PrintPhonebook()
        {
            Console.WriteLine("====== PHONE BOOK ======");
            for (int i = 0; i < entities.Length; i++)
            {
                if (entities[i] != null)
                {
                    entities[i].PrintEntity();
                    Console.WriteLine("------------------------");
                }
            }
        }
        #endregion
    }
}