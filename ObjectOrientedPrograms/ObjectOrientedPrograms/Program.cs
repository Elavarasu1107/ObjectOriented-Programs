using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InventoryMain jsonfile = new InventoryMain();
            jsonfile.Convert(@"D:\BridgeLabz\ObjectOriented-Programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory.json");
        }
    }
}
