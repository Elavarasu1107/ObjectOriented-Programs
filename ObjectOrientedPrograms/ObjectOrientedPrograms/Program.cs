using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Inventory management \nEnter 2 for Stock Management");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        InventoryMain jsonfile = new InventoryMain();
                        jsonfile.Convert(@"D:\BridgeLabz\ObjectOriented-Programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory.json");
                        break;
                    }
                case 2:
                    {
                        StockMain stockfile = new StockMain();
                        stockfile.Convert(@"D:\BridgeLabz\ObjectOriented-Programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Stock.json");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid number");
                        break;
                    }
            }   
        }
    }
}
