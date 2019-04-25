using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.BL
{
    public class AddressRepository
    {

        /// <summary>
        /// Retrieves the requested address.
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // create and instance of the address class.
            // pass in the reqested id.
            Address address = new Address(addressId);

            // code that retrieves address.

            // Temp hard coded address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Street1";
                address.StreetLine2 = "Street2";
                address.City = "London";
                address.State = "Shire";
                address.Country = "United Kindom";
                address.PostalCode = "SE1 7PB";
            }
            return address;
        }

        // IEnumerable returns a sequence of addresses.
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves the defiened addresses for the customer.

            // temp hard coded values
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Street1",
                StreetLine2 = "Street2",
                City = "London",
                State = "Shire",
                Country = "United Kindom",
                PostalCode = "SE1 7PB"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "First Street",
                StreetLine2 = "Second Street",
                City = "Brighton",
                State = "Shire",
                Country = "United Kindom",
                PostalCode = "BN1"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // Make call to insert stored procedure.
                    }
                    else
                    {
                        // Make call to update stored procedure.
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
    }

