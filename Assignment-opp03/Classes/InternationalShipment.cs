using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp03.Classes
{
    public class InternationalShipment : Shipment
    {
        #region Feilds
        private string DestinationCountry;
        private decimal CustomsFee;
        #endregion

        #region Constructor
        public InternationalShipment(string destinationCountry, decimal customsFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }

            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }

        #endregion

        #region FunctionOverride
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5) + CustomsFee;

            }
        }

        protected override void PrintInfo()
        {

            Console.WriteLine($"Delivery Fee: {DestinationCountry}");
            Console.WriteLine($"Extra Fee: {CustomsFee} EGP");


        }

        #endregion
    }
}
