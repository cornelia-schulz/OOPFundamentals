using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // constructor with no params is the default constructor, don't define if you have nothing to go in it,
        // it will be defined automatically, however you need to create one if you create one or more overloaded constructors
        public Customer(): this(0)
        {
            
        }
        // because customerId has a private setter below, create another constructor
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        // long syntax to define getter and setter - only use if you have logic in getter or setter
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public List<Address> AddressList { get; set; }
        // short syntax
        public string FirstName { get; set; }
        // right click - Snippet/Insert Snippet
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FullName 
        { 
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string Log()
        {
            return $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        }

        public override string ToString() => FullName;

        public static int InstanceCount { get; set; }

        public Customer Retrieve(int customerId)
        {
            // code that retrieves the defined customer

            return new Customer();
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
