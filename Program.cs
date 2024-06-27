using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Task
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
           
            Shipment[] shipmentsArr = new Shipment[3];
            Console.WriteLine("Loading Process: ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"enter value no.{i+1}: ");
                string value = Console.ReadLine();
                shipmentsArr[i] = new Shipment(value);
            }

            Console.WriteLine("Unloading process.\n");
            PrintInRecusirve(shipmentsArr);
            Console.ReadKey();
        }


        public static void PrintInRecusirve(Shipment[] arr, int counter = 0)
        {
            // base case: if the counter is bigger
            // than the length of the array
            if (counter > arr.Length - 1)
                return;

            // recurive call to the func
            PrintInRecusirve(arr, counter + 1);

            // This will work after the recursion is over
            Console.Write($"value no.{arr[counter].shipmentID}: ");
            Console.WriteLine(arr[counter].shipmentContent);
        }


    }

    class Shipment
    {
        public int shipmentID;
        public string shipmentContent;
        public static int shipmentsCount = 0;
        public Shipment(string content)
        {
            shipmentID = ++shipmentsCount;
            shipmentContent = content;
        }
    }

}
