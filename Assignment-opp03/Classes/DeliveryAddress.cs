using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp03.Classes
{
    public struct DeliveryAddress
    {
        #region Feilds
        public string City;
        public string Street;
        public int BuildingNumber;
        #endregion

        #region Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region Methode
        public string GetFullAddress()
        {
            return $"{City} :: {Street} :: {BuildingNumber}";
        }
        #endregion
    }
}
