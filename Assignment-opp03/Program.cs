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
            StandardShipment standard = new StandardShipment("A001", "Labtop", 10.5, 50, new DeliveryAddress("Cairo ", "oooo", 2));
            ExpressShipment express = new ExpressShipment(20, "A002", "Iphone", 15.2, 70, new DeliveryAddress("Alex" , "dddd" , 5));
            InternationalShipment international = new InternationalShipment("Cairo", 70, "A003", "Cam", 7.2, 60, new DeliveryAddress("Alex" , "ffff" ,8));

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.AddShipment(standard);
            deliveryCenter.AddShipment(express);
            deliveryCenter.AddShipment(international);

            Console.WriteLine("=================================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("=================================================");
            for(int i = 0; i <20; i++)
            {
                Shipment shipment = deliveryCenter[i];
                if(shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("----------------------------------------------------------");
                }
            }


            Console.WriteLine("===========================Datils======================");
            DeliveryHelper helper = new DeliveryHelper();
            helper.PrintShipmentDetails(standard);
            Console.WriteLine("=================================================");

            helper.PrintShipmentDetails(express);
            Console.WriteLine("=================================================");

            helper.PrintShipmentDetails(international);
            Console.WriteLine("=================================================");

            Console.WriteLine("Updating Weight...");

            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            standard.UpdateWeight(5, 2.5);

            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
            Console.WriteLine("=================================================");

            #endregion

        }
    }
}
