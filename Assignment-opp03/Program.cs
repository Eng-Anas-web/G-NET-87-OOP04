using Assignment_opp03.Classes;
using System.Numerics;
using System.Xml.Linq;

namespace Assignment_opp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1- 
            //a)  What is the difference between Method Overloading and Method Overriding?
            //A:
            //Method Overloading:  It means having multiple methods with the same name but different parameters. It is determined at compile time.
            //Method Overriding:It means a derived class provides a new implementation for a method inherited from the base class. It uses virtual in the base class and override in the derived class. It is determined at runtime.
            //b)  What is the difference between Static Binding and Dynamic Binding?
            //A: 
            //Static Binding: The method to be executed is determined at compile time. It is commonly used with method overloading.
            //Dynamic Binding: The method to be executed is determined at runtime based on the actual type of the object.It is used with method overriding.

            #endregion

            #region Question002
            //2- 
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //A: Prevent it from inheriting to any other class
            //b)  What is the difference between a sealed class and a sealed method?
            //A: Sealed Class => it Prevents inheritance from it   ,    Sealed Method => it Prevensts override from it
            //c)  Can a sealed method be overridden? Why?
            //A: No , Because the Sealed Methode Prevents methone from override
            #endregion

            #region Question02

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            Console.Write("Enter Delivery Center Name: ");
            string center = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Delivery Center: {center}");
            Console.WriteLine("===============================================================");
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode01 = Console.ReadLine();
            Console.Write("Description: ");
            string description01 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight01 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee01 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city01 = Console.ReadLine();
            Console.Write("Street: ");
            string street01 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber01 = int.Parse(Console.ReadLine());
            DeliveryAddress address = new DeliveryAddress(
                  city01,
                  street01,
                  buildingNumber01
                  );
            StandardShipment standard = new StandardShipment(
                tracingCode01,
                description01,
                weight01,
                deliveryFee01,
              address
                );

            if (deliveryCenter.AddShipment(standard))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");
            }
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode02 = Console.ReadLine();
            Console.Write("Description: ");
            string description02 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight02 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee02 = decimal.Parse(Console.ReadLine());
            Console.Write("Extra Fee: ");
            decimal extraaFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city02 = Console.ReadLine();
            Console.Write("Street: ");
            string street02 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber02 = int.Parse(Console.ReadLine());
            DeliveryAddress address02 = new DeliveryAddress(
      city02,
      street02,
      buildingNumber02
      );
            ExpressShipment express = new ExpressShipment(
                extraaFee,
                tracingCode02,
                description02,
                weight02,
                deliveryFee02,
              address02
                );

            if (deliveryCenter.AddShipment(express))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");

            }
            /////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode03 = Console.ReadLine();
            Console.Write("Description: ");
            string description03 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight03 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee03 = decimal.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();
            Console.Write("Custom Fee: ");
            decimal customFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city03 = Console.ReadLine();
            Console.Write("Street: ");
            string street03 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber03 = int.Parse(Console.ReadLine());
            DeliveryAddress address03 = new DeliveryAddress(
      city03,
      street03,
      buildingNumber03
      );
            InternationalShipment International = new InternationalShipment(
                destinationCountry,
                customFee,
                tracingCode03,
                description03,
                weight03,
                deliveryFee03,
              address03
                );

            if (deliveryCenter.AddShipment(International))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");

            }

            Console.WriteLine("--- All Shipments ---");
            for (int i = 0; i < 20; i++)
            {
                Shipment shipmentt = deliveryCenter[i];
                if (shipmentt != null)
                {
                    Console.WriteLine($"Shipments {i + 1}");
                    deliveryCenter[i].PrintShipment();
                    Console.WriteLine("=================================================================");
                }
            }


            //===========================Search==============================================//

            Console.WriteLine("\n Enter Tracing Code Search: ");
            string codeSarch = Console.ReadLine();

            Shipment result = deliveryCenter[codeSarch];

            if (result != null)
            {
                result.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            //===========================Remove==============================================//

            Console.WriteLine("\n Enter Tracing Code to Rmove: ");
            string removeCode = Console.ReadLine();
            bool remove = deliveryCenter.RemoveShipment(removeCode);

            if (remove == true)
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");

            }

            Console.WriteLine("========================================================================");
            Console.WriteLine("Remaining Shipments:");
            Console.WriteLine("\n========================================================================");
            for (int i = 0; i < 20; i++)
            {
                if (deliveryCenter[i] != null)
                {
                    Console.WriteLine("Shipments01");
                    deliveryCenter[i].PrintShipment();
                    Console.WriteLine("=================================================================");
                }
            }

            #endregion


        }
        public void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment();
        }
    }
}
