using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp03.Classes
{
    public class ExpressShipment : Shipment
    {

        #region Feildes
        private decimal ExtraFee;

        #endregion

        #region Constructors
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }

        #endregion

        #region FunctionOverride
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5) + ExtraFee;

            }
        }

        protected override void PrintInfo()
        {

            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");


        }
        #endregion


    }
}
