using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp03.Classes
{
    public class StandardShipment : Shipment
    {
        #region Constructor
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        #endregion
    }
}
